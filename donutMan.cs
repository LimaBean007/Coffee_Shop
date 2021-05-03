using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Coffee_Shop
{
    class donutMan
    {
        public void getDonuts(Order newOrder)
        {
            MessageBox.Show("Getting and packing donuts :" + newOrder.NumDonuts);
        }
    }
}
