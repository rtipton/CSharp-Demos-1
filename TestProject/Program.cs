using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var person = new Person { Age = 30, Name = "Rhonda", Hobby = "Nothing", FaveShow = "Fringe", FaveMovie = "Star Trek", FaveSong = "Second Chance" };
        var type = typeof(Person);
        var properties = type.GetProperties();

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine("{0} = {1}", property.Name, property.GetValue(person, null));
        }

        Console.Read();
    }
}

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public string Hobby { get; set; }
    public string FaveShow { get; set; }
    public string FaveMovie { get; set; }
    public string FaveSong { get; set; }
}