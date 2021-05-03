using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Coffee_Shop
{
    class baristaEmployee
    {
        public void makeCoffee(Order newOrder)
        {
            MessageBox.Show("Making coffee :" + newOrder.NumCoffee);

        }
    }
}
