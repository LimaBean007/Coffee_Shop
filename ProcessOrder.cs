using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop
{
    class ProcessOrder
    {
        public delegate void ProcessOrderDelegate(Order newOrder);
        public event ProcessOrderDelegate OrderSubmittted;
        public void processOrder(Order newOrder) {
            paymentService newPay = new paymentService();
            donutMan newDonut = new donutMan();
            baristaEmployee newBarista = new baristaEmployee();

            OrderSubmittted += newPay.getPayment;
            OrderSubmittted += newDonut.getDonuts;
            OrderSubmittted += newBarista.makeCoffee;

            //newPay.getPayment(newOrder);
            //  newBarista.makeCoffee(newOrder);
            //  newDonut.getDonuts(newOrder);

            onOrderSubmitted(newOrder);

        }
        protected virtual void onOrderSubmitted(Order newOrder) {
            if (OrderSubmittted != null) {
                OrderSubmittted(newOrder);
            }
        }
    }
}
