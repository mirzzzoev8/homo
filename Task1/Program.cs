Person person = new Person();
person.FirstName = Console.ReadLine();
person.LastName = Console.ReadLine();
person.Age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(person.GetFullName());
System.Console.WriteLine(person.GetBirthYear());


public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Address;
    public string GetFullName(){
        return $"My name is {FirstName} {LastName}";
    }
    public int GetBirthYear(){
        return Age;
    }
}