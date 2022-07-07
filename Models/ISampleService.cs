using System.ServiceModel;

namespace Models {

    [ServiceContract]
    public interface ISampleService {
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        PersonModel TestPersonModel(PersonModel inputPerson);

        [OperationContract]
        string GreetingsMessage (int Id, string FullName, string Email);
    }
}