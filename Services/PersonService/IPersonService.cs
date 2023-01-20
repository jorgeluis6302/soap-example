using System.Runtime.Serialization;
using System.ServiceModel;

namespace Services.PersonService {
    [ServiceContract]
    public interface IPersonService {
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        string GreetingsMessage (int Id, string FirstName, string LastName);
    }

    [DataContract]
    public class PersonModel {
        [DataMember]
        private int Id { set; get; }
        [DataMember]
        public string FirstName { set; get; } = string.Empty;
        [DataMember]
        public string LastName { set; get; } = string.Empty;
        [DataMember]
        public string FullName => $"{FirstName} {LastName}";

        public PersonModel(int id, string firstName, string lastName) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}