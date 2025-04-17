// AnimalItemDTO is a class you use when you want to limit the data you want to send to the Database, ex. sensitive information.
public class AnimalItemDTO {
    public int Id { get; set; }
    public string? Image { get; set; }
    public string? Name { get; set; }
    public string? LatinName { get; set; }
    public string? Species { get; set; } 
    public List<string>? Environment { get; set; }
    public string? FoodPreference { get; set;}
    public string? Description { get; set; }

    public AnimalItemDTO() {}
    public AnimalItemDTO(Animal animalItem) => (Id, Image,  Name, LatinName, Species, Environment, FoodPreference, Description) = (animalItem.Id, animalItem.Image, animalItem.Name, animalItem.LatinName,
         animalItem.Species, animalItem.Environment, animalItem.FoodPreference, animalItem.Description);
}