using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop
{
    class Order
    {
        private string name;
        private int numCoffee;
        private int numDonuts;

        public Order(string name, int numCoffee, int numDonuts)
        {
            this.name = name;
            this.numCoffee = numCoffee;
            this.numDonuts = numDonuts;
        }

        public string Name { get => name; set => name = value; }
        public int NumCoffee { get => numCoffee; set => numCoffee = value; }
        public int NumDonuts { get => numDonuts; set => numDonuts = value; }
        public override string ToString()
        {
            return this.name + " : " + this.numDonuts + " donuts & " + this.numCoffee + "coffee";
        }
    }
}
