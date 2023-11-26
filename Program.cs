// Cat class

class Cat
{
    public string name;
    public int age;

    public void Meow()
    {
        Console.WriteLine(name + " says meow!");
    }
}

// Main code

class Program
{
    static void Main(string[] args)
    {
        
        Cat cat01 = new Cat();
        cat01.name = "steven";
        cat01.age = 1;
        cat01.Meow();
        
        Cat cat02 = new Cat(); 
        cat02.name = "lucy";
        cat02.age = 2;
        cat02.Meow();

        Cat cat03 = new Cat();
        cat03.name = "milo";
        cat03.age = 3;
        cat03.Meow();

        Cat cat04 = new Cat();
        cat04.name = "bella";
        cat04.age = 4;
        cat04.Meow();

        Cat cat05 = new Cat();
        cat05.name = "max";
        cat05.age = 5;
        cat05.Meow();

        Cat cat06 = new Cat();
        cat06.name = "lily";
        cat06.age = 6;
        cat06.Meow();

    }
}
