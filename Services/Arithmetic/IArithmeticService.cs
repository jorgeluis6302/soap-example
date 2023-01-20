using System.Runtime.Serialization;
using System.ServiceModel;

namespace Services.Arithmetic {
    [ServiceContract]
    public interface IArithmeticService {
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        double Sum (double a, double b);
        [OperationContract]
        double Substract (double a, double b);
        [OperationContract]
        double Div (double a, double b);
        [OperationContract]
        double Product (double a, double b);
    }

    [DataContract]
    public class ArithmeticModel {
        public double Sum (double a, double b) => a + b;
        public double Substract(double a, double b) => a - b;
        public double Div (double a, double b) => b != 0 ? a / b : double.NaN;
        public double Product (double a, double b) => a * b;
    }
}