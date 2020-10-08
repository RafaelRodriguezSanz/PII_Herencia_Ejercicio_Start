using System;
using System.Collections;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class UcuRideShare
    {
        public List<IPerson> rideShare;
    
        public UcuRideShare()
        {
            this.rideShare = new List<IPerson>{};
        }
        public void Add(IPerson person)
        {
            rideShare.Add(person);
            person.Public();

        }
    }
}
