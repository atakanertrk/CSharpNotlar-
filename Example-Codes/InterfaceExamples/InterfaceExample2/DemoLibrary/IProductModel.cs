using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //interface is a contract. Contract says: here is the things that whatever class 
    //implements, here is the things that it will have.

    // everything in interface is public because it is a contract.
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; } //prop signature
        void ShipItem(CustomerModel customer); //method signature
    }
}
