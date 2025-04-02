public class AnimalItemDTO {
    public int Id { get; set; }
    public string? Image { get; set; }
    public string? Name { get; set; }
    public string? Species { get; set; } 
    public List<string>? Environment { get; set; }
    public string? FoodPreference { get; set;}
    public string? Description { get; set; }

    public AnimalItemDTO() {}
    public AnimalItemDTO(Animal animalItem) => (Id, Image,  Name, Species, Environment, FoodPreference, Description) = (animalItem.Id, animalItem.Image, animalItem.Name,
         animalItem.Species, animalItem.Environment, animalItem.FoodPreference, animalItem.Description);
}