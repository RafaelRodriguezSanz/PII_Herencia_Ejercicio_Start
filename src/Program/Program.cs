using System;
using System.Collections;
using CognitiveCoreUCU;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var image1 = ".\\..\\..\\images\\bill.jpg";
            var image2 = ".\\..\\..\\images\\bill2.jpg";
            var image3 = ".\\..\\..\\images\\yacht.jpg";
            Passanger pasajero1 = new Passanger("Rafael", "Rodriguez", "1111111-1", image1);
            Passanger pasajero2 = new Passanger("Estafano", "Giusiano", "2222222-2", image2);
            Passanger pasajero3 = new Passanger("Cristian", "Velázquez", "3333333-3", image3);

            Driver conductor1 = new Driver("Rafael", "Rodriguez", "1111111-1", "Es un buen conductor", image1);
            Driver conductorPool1 = new Pool("Estafano", "Giusiano", "2222222-2", "Manjea como Toreto", 3, image2);
            UcuRideShare rideshare = new UcuRideShare();
            rideshare.Add(conductor1);
            rideshare.Add(conductorPool1);
            rideshare.Add(pasajero1);
            rideshare.Add(pasajero2);
            rideshare.Add(pasajero3);
        }
    }
}
