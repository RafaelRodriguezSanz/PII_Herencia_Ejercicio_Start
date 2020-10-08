using System;
using System.Collections;

namespace PII_Herencia
{
    public class Common:Driver
    {
        public new string name{get;set;}
        public new string sureName{get;set;}
        public new string id{get;set;}
        public new string biography{get;set;}
        public new Classification classification{get;set;}
         public Common(string name, string sureName, string id, string biography)
            :base(name, sureName, id, biography){}
    }
}
