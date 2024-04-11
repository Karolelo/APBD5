namespace WebApplication1;

public class Animal
{
    public Animal(int id, string name, string category, int wage, string color)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.wage = wage;
        this.color = color;
    }

    public int id;
    public string name;
    public string category;
    public int wage;
    public string color;
    public override string ToString()
    {
        return id + " " + "Imie: " + name + " kategoria: " + category + " waga zwierzaka: " + wage + " kolor " + color;
    }
}