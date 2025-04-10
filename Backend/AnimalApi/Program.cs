
using AnimalApi.Data;
using Microsoft.EntityFrameworkCore;

// Builder initiates the project and uses UseInMemoeryDatabase to create a per session Database for the API.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AnimalDb>(opt => opt.UseInMemoryDatabase("AnimalFacts"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


// Initiates API Endpoints and implements metadata for the API.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config => {
    config.DocumentName = "AnimalAPI";
    config.Title = "AnimalFacts v1";
    config.Version = "v1";
});
var app = builder.Build();

// Creates and instance where you can initiate the Database seeding per session.
using(var scope = app.Services.CreateScope()){
    var context = scope.ServiceProvider.GetRequiredService<AnimalDb>();
    var seeder = new DataSeeder(context);
    seeder.SeedData();
}

// Implements swagger for easier testing of CRUD functionality.
if (app.Environment.IsDevelopment()) {
    app.UseOpenApi();
    app.UseSwaggerUi(config => {
        config.DocumentTitle = "AnimalAPI";
        config.Path = "/swagger";
        config.DocumentPath = "/swagger/{documentName}/swagger.json";
        config.DocExpansion = "list";
    });
}

// MapGroup only sets the common url path. For making the other code shorter.
var animalItems = app.MapGroup("/animals");

// CRUD functionality
animalItems.MapGet("/", GetAllAnimals);
animalItems.MapGet("/{id}", GetAnimalById);
animalItems.MapPost("/", CreateAnimal);
animalItems.MapPut("/{id}", UpdateAnimal);
animalItems.MapDelete("/{id}", DeleteAnimal);

   

app.Run();

// Outputs all entities from the database to a JSON file.
static async Task<IResult> GetAllAnimals(AnimalDb db) {
    return TypedResults.Ok(await db.Animals.Select(x => new AnimalItemDTO(x)).ToArrayAsync());
}

// Outputs a single entity by ID from the database to a JSON file.
static async Task<IResult> GetAnimalById(int id, AnimalDb db) {
    return await db.Animals.FindAsync(id) is Animal animal ? TypedResults.Ok(new AnimalItemDTO(animal)) : TypedResults.NotFound();
}

// CRUD Create an Animal model entity to the Database(only exists during current session).
static async Task<IResult> CreateAnimal(AnimalItemDTO animalItemDTO, AnimalDb db) {
    
    var animalItem = new Animal{
        Image = animalItemDTO.Image,
        Name = animalItemDTO.Name,
        Species = animalItemDTO.Species,
        Environment = animalItemDTO.Environment,
        FoodPreference = animalItemDTO.FoodPreference,
        Description = animalItemDTO.Description
    };
    
    db.Animals.Add(animalItem);
    await db.SaveChangesAsync();

    animalItemDTO = new AnimalItemDTO(animalItem);

    return TypedResults.Created($"/animals/{animalItem.Id}", animalItemDTO);
}

// CRUD Updates an Animal model entity from the Database(only exists during current session).
static async Task<IResult> UpdateAnimal(int id, AnimalItemDTO animalItemDTO, AnimalDb db) {
    
    var animal = await db.Animals.FindAsync(id);

    if(animal is null) return TypedResults.NotFound();

    animal.Image = animalItemDTO.Image;
    animal.Name = animalItemDTO.Name;
    animal.Species = animalItemDTO.Species;
    animal.Environment = animalItemDTO.Environment;
    animal.FoodPreference = animalItemDTO.FoodPreference;
    animal.Description = animalItemDTO.Description;

    await db.SaveChangesAsync();

    return TypedResults.NoContent();
}

// CRUD Deletes an Animal model entity from the Database(only exists during current session).
static async Task<IResult> DeleteAnimal(int id, AnimalDb db){
    if(await db.Animals.FindAsync(id) is Animal animal){
        db.Animals.Remove(animal);
        await db.SaveChangesAsync();
        return TypedResults.NoContent();
    }

    return TypedResults.NotFound();
}