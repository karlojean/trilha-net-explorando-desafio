namespace DesafioProjetoHospedagem.Models;

public class Person
{
    public Person() { }

    public Person(string name)
    {
        Name = Name;
    }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string FullName => $"{Name} {Surname}".ToUpper();
}