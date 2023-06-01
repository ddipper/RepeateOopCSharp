Person<int> tom = new Person<int>(546, "Tom");
Person<string> sam = new Person<string>("abc123", "Sam");
int tomId = tom.Id; //распаковка не нужна
string samId = sam.Id; //проебразование типов не требуется

Console.WriteLine(tomId);
Console.WriteLine(samId);

class Person<T> //обобщенный класс
{
    public T Id { get; set; }
    public string Name { get; set; }

    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}
































/*var rectangle = new Rectangle(){Width = 20, Height = 20};
var circle = new Circle() { Radius = 200 };

PrintShape(rectangle); 
PrintShape(circle);

void PrintShape(Shape shape)
{
    Console.WriteLine($"Perimentr: {shape.GetPerimentr()}, Area: {shape.GetArea()}");
}

abstract class Shape
{
    public abstract double GetPerimentr();
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public float Width { get; set; }
    public float Height { get; set; }

    public override double GetPerimentr() => Width * 2 + Height * 2;
    public override double GetArea() => Width * Height;


}

class Circle : Shape
{
    public float Radius { get; set; }

    public override double GetPerimentr() => Radius * 2 * 3.14;
    public override double GetArea() => Radius * Radius * 3.14;
}*/



/*Person bob = new Person("Bob");
Console.WriteLine(bob.Name);    // Bob
 
Employee tom = new Employee("Tom", "Microsoft");
Console.WriteLine(tom.Name);    // Mr./Ms. Tom
 
class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
}
class Employee : Person
{
    public new string Name
    {
        get => $"Mr./Ms. {base.Name}";
        set => base.Name = value;
    }
    public string Company { get; set; }
    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}*/



/*Person bob = new Person("Bob");
Employee sam = new Employee("Sam", "Epam");
bob.Print();
sam.Print();

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }

    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }

    public new void Print()
    {
        //Console.WriteLine($"Name: {Name}, Company: {Company}");
        base.Print();
        Console.Write($"Company: {Company}");
    }
}*/



/*Person bob = new Person("Bob");
Employee sam = new Employee("Sam", "Microsoft");
bob.Print();
sam.Print();    

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }w

    public virtual void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string Company { get; set; }

    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Company: {Company}");
    }
}*/



/*Employee employee = new Employee("Tom", "Microsoft");
Person person = employee;
Employee employee2 = (Employee)person;
Console.WriteLine(employee2.Company);

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"Person name: {Name}");
    }
}

class Employee : Person
{
    public string Company { get; set; }

    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

class Client : Person
{
    public string Bank { get; set; }

    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}*/



/*class Person
{
    private string name;
    private int age;

    public Person(string name)
    {
        this.name = name;
        Console.WriteLine($"Person {name}");
    }

    public Person(string name, int age) : this(name)
    {
        this.age = age;
        Console.WriteLine($"Person {name}, {age} y.o.");
    }
}

class Employee : Person
{
    private string company;

    public Employee(string name, int age, string company) : base(name, age)
    {
        this.company = company;
        Console.WriteLine($"Employee {name}, {age} y.o., working at {company}");
    }
}*/



/*class Person //inheritance
{
    private string _name = "Bob";

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Person(string name)
    {
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine(Name);
    }

}

class Employee : Person //inheritance
{
    public string Company { get; set; }
    public Employee(string name, string company)
        : base(name)
    {
        Company = company;
    }

    public void PrintNameWithCompany()
    {
        Console.WriteLine($"Name: {Name}\nCompany: {Company}");
    }
}*/