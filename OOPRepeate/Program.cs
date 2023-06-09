﻿Person<string> person1 = new Person<string>("34");
Person<int> person2 = new Person<int>(45);
UniversalPerson<int> person3 = new UniversalPerson<int>(33);

Console.WriteLine(person1.Id);
Console.WriteLine(person2.Id);
Console.WriteLine(person3.Id);

class Person<T>
{
    public T Id { get; }

    public Person(T id)
    {
        Id = id;
    }
}

class UniversalPerson<T> : Person<T>
{
    public UniversalPerson(T id) : base(id) { }
}















/*Messenger<Message> telegram = new Messenger<Message>();
telegram.SendMessage(new Message("Hello tg world"));
Messenger<EmailMessage> outlook = new Messenger<EmailMessage>();
outlook.SendMessage(new EmailMessage("Hello outlook world"));

class Messenger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Send message: {message.Text}");
    }
}

class Message
{
    public string Text { get; }

    public Message(string text)
    {
        Text = text;
    }
}

class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}*/



/*SendMessage<Message>(new Message("Hello world!"));
SendMessage<EmailMessage>(new EmailMessage("Hello email world"));

void SendMessage<T>(T message) where T: Message
{
    Console.WriteLine($"Send message: {message.Text}");
}

class Message
{
    public string Text { get; }

    public Message(string text)
    {
        Text = text;
    }
}

class EmailMessage : Message
{
    public EmailMessage(string text) : base(text) { }
}

class SmsMessage : Message
{
    public SmsMessage(string text) : base(text) { }
}*/



/*int x = 7;
int y = 12;

string str1 = "Hello";
string str2 = "World";

Swap<int>(ref x, ref y);
Console.WriteLine($"x: {x}, y: {y}");
Swap<string>(ref str1, ref str2);
Console.WriteLine($"str1: {str1}, str2: {str2}");

void Swap<T>(ref T x, ref T y)
{
    T temp = x;
    x = y;
    y = temp;
}*/



/*Person<int, string> bob = new Person<int, string>(12, "qwerty123", "Bob");
Console.WriteLine($"Id: {bob.Id}, Name: {bob.Name}, Password: {bob.Password}");

class Person<T, K>
{
    public T Id { get; set; }
    public K Password { get; set; }
    public string Name { get; }

    public Person(T id, K password, string name)
    {
        Id = id;
        Password = password;
        Name = name;
    }
}*/



/*Person<int> bob = new Person<int>(546, "Bob");
Person<int>.code = 1234;

Person<string> tom = new Person<string>("abcId", "Tom");
Person<string>.code = "meta";

Console.WriteLine(Person<int>.code);
Console.WriteLine(Person<string>.code);

class Person<T>
{
    public static T? code;
    public T Id { get; set; }
    public string Name { get; set; }

    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}*/



/*Person<int> bob = new Person<int>(1052, "Bob");
Company<Person<int>> microsoft = new Company<Person<int>>(bob);

Console.WriteLine(microsoft.CEO.Id);
Console.WriteLine(microsoft.CEO.Name);
class Company<P>
{
    public P CEO { get; set; }

    public Company(P ceo)
    {
        CEO = ceo;
    }
}

class Person<T>
{
    public T Id { get; }
    public string Name { get; }
    public Person(T id, string name)
    {
        Id = id;
        Name = name;
    }
}*/



/*Person<int> tom = new Person<int>(546, "Tom");
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
}*/



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