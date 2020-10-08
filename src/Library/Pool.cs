using System;
using System.Collections;

namespace PII_Herencia
{
    public class Pool:Driver
    {
        public new string name{get;set;}
        public new string sureName{get;set;}
        public new string id{get;set;}
        public new string biography{get;set;}
        public new Classification classification{get;set;}
        public int passangerCapacity{get;set;}
        public Pool(string name, string sureName, string id, string biography, int passangerCapacity)
            :base(name, sureName, id, biography)
        {
            this.passangerCapacity = passangerCapacity;
        }
    }
}
