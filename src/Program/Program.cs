using System;
using System.Collections;
using System.Drawing;
using CognitiveCoreUCU;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Passanger pasajero1 = new Passanger("Rafael","Rodriguez","5014932-3");
            Passanger pasajero2 = new Passanger("Estafano","Giusiano","5198049-5");
            Passanger pasajero3 = new Passanger("Cristian","Velázquez","xxxxxxx-x");

            Driver conductor1 = new Driver("Rafael","Rodriguez","5014932-3","Es un buen conductor");
            Driver conductorPool1 = new Pool("Estafano","Giusiano","5198049-5","Manjea como Toreto",3);
            
            UcuRideShare rideshare = new UcuRideShare();
            rideshare.Add(conductor1);
            rideshare.Add(conductorPool1);
            rideshare.Add(pasajero1);
            rideshare.Add(pasajero2);
            rideshare.Add(pasajero3);


            #region Reconocimiento Facial
            CognitiveFace cog = new CognitiveFace("a36648d3c5134ab692acd35605d491f7", false);
            cog.Recognize(@"bill.jpg");
            FoundFace(cog);
            cog.Recognize(@"bill2.jpg");
            FoundFace(cog);
            cog.Recognize(@"yacht.jpg");
            FoundFace(cog);
            static void FoundFace(CognitiveFace cog)
        {
            if (cog.FaceFound)
            {
                Console.WriteLine("Face Found!");
                if (cog.SmileFound)
                {
                    Console.WriteLine("Found a Smile :)");
                }
                else
                {
                    Console.WriteLine("No smile found :(");
                }
            }
            else
                Console.WriteLine("No Face Found");
        }
            #endregion

            
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
