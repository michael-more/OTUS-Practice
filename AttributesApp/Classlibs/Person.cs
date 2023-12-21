namespace AttributesApp;

[AgeValidation(18)]
public class Person
{
    public string Name { get; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
