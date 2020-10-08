using System;
using System.Collections;

namespace PII_Herencia
{
    public enum Classification{Driver, Passanger}
    public interface IPerson
    {
        string name{get;set;}
        string sureName{get;set;}
        string id{get;set;}
        Classification classification{get;set;}
        public void Public();
    }
}
