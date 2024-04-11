namespace WebApplication1.Controlers;

public class Visit
{
    public Visit(int id, DateTime date, int animalId, string description, decimal price)
    {
        Id = id;
        Date = date;
        AnimalId = animalId;
        Description = description;
        Price = price;
    }

    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    
    public override string ToString()
    {
        return $"Visit: {Id}, Date: {Date.ToShortDateString()}, AnimalId: {AnimalId}, Description: {Description}, Price: {Price:C}";
    }

}
