using System;
using System.Xml.Linq;

namespace Services.Arithmetic {
    public class ArithmeticService : IArithmeticService {
        public void XmlMethod(XElement xml) {
            Console.WriteLine(xml.ToString());
        }

        public double Sum (double a, double b) {
            var operation = new ArithmeticModel();
            return operation.Sum(a, b);
        }

        public double Div (double a, double b) {
            var operation = new ArithmeticModel();
            return operation.Div(a, b);
        }

        public double Substract (double a, double b) {
            var operation = new ArithmeticModel();
            return operation.Substract(a, b);
        }

        public double Product (double a, double b) {
            var operation = new ArithmeticModel();
            return operation.Product(a, b);
        }

        public ArithmeticModel TestArtithmeticModel (ArithmeticModel arithmeticModel) {
            return arithmeticModel;
        }        
    }
}