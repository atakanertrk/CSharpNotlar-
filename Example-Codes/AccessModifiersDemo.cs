using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {
        // test method
        private void Demo() 
        {
            PrivateDemo();
        }
        // ***************
        private void PrivateDemo()
        {
            //only inside the same class or object that was declared in
        }

        private protected void PrivateProtectedDemo()
        {
            //only available inside the class that delclared it, as well as from a class inherits from it but only in the same assembly
        }

        protected void ProtectedDemo()
        {
            //inside of class it was created in or inside of anything it derives from that class
        }

        protected internal void ProtectedInternalDemo()
        {
            //inside of assembly which it was created in and whereever inherits from (derives)
        }

        internal void InternalDemo()
        {
            //anywhere inside the same assembly
        }

        public void PublicDemo()
        {
            //can be accessed everywhere
        }
    }
}
