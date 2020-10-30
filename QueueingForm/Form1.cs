using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueingForm
{
    public partial class QueuingForm : Form
    {
        CustomerView cV = new CustomerView();
        CashierClass cashier;
        public QueuingForm()
        {
            cashier = new CashierClass();
            InitializeComponent();
           
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
            


        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            new CashierWindowQueueForm().Show();
            new CustomerView().Show();
            cV.label2.Visible = true;
            cV.label2.Text = "empty";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}