using Models;
using System;
using System.Xml.Linq;

public class SampleService : ISampleService {
    public string Test (string s){
        Console.WriteLine("Test method executed");
        return $"This was your text: {s}";
    }

    public void XmlMethod(XElement xml) {
        Console.WriteLine(xml.ToString());
    }

    public PersonModel TestPersonModel (PersonModel personModel) {
        return personModel;
    }

    public string GreetingsMessage (int Id, string FullName, string  Email) {
        PersonModel person = new PersonModel(Id, FullName, Email);
        Console.WriteLine("GreetingsMesse method has been executed!");
        return $"Welcome {person.FullName}/{person.Email}";
    }
}