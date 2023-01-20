using System;
using System.Xml.Linq;

namespace Services.PersonService {
    public class PersonService : IPersonService {
        public void XmlMethod(XElement xml) {
            Console.WriteLine(xml.ToString());
        }      
        public string GreetingsMessage (int Id, string FirstName, string LastName) {
            PersonModel person = new PersonModel(Id, FirstName, LastName);
            Console.WriteLine($"GreetingsMessage executed  {Id},{FirstName},{LastName}");
            return $"Welcome {person.FullName}!";
        }
    }
}