using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
   
        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            int coffee = Convert.ToInt32(txbCoffee.Text);
            int donut = Convert.ToInt32(txbDonuts.Text);
            Order newOrder = new Order(name, coffee, donut);

            ProcessOrder newProcess = new ProcessOrder();
            newProcess.processOrder(newOrder);
            MessageBox.Show("Order Ready!");
        }



      
    }
}
