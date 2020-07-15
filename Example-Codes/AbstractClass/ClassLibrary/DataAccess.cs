using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
// abstract classes are like mix of base class(inheritence) and interface
// + BENEFIT OF ABSTRACT 1:
// - you cant create instance of abstract class.
// - but who inherits the abstract class, gets the LoadConnectionString method. (its like interface) and LoadData SaveData contract/promise
    public abstract class DataAccess 
    {
        public string LoadConnectionString(string name) // base class part
        {                                               // if we want to make LoadConnectionString overrideable than we should define it like =>  public virtual string LoadConnectionString(string name)
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }
        public abstract void LoadData(string sql); //interface part.(contract/promise)
        public abstract void SaveData(string sql); //interface part.(contract/promise)
    }
}
