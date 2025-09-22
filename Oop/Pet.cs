namespace Oop;

public interface IPetMovement
{
    void Bark();
}

public class Pet
{
    public string Name { get; set; }
    protected int Age { get; set; }
    private int year = 2025;

    protected void SetAge(int yearOfBirth)
    {
        Age = year - yearOfBirth;
    }
    
    protected void SetAge(int yearOfBirth, int currentYear)
    {
        Age = currentYear - yearOfBirth;
    }
    
    public virtual void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
    }
}

public class Dog : Pet, IPetMovement
{
    public string Breed { get; set; }
    
    public Dog(string name, string breed)
    {
        Name = name;
        Breed = breed;
    }

    public Dog(string name, int yearOfBirth, string breed)
    {
        Name = name;
        SetAge(yearOfBirth);
        Breed = breed;
    }

    public override void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(Breed);
    }

    public void Bark()
    {
        Console.WriteLine("Woof Woof");
    }
}

public class Cat : Pet, IPetMovement
{
    public void Bark()
    {
        throw new NotImplementedException();
    }
}