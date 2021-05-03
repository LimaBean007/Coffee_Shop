using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Coffee_Shop
{
    class paymentService
    {
        public void getPayment(Order newOrder)
        {
            MessageBox.Show("Collecting payment from :" + newOrder.Name);
        }
    }
}
