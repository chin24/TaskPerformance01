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
    
    public partial class CustomerView : Form 
    {
        CashierWindowQueueForm cw = new CashierWindowQueueForm();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (CashierClass.peekNumber.Length > 0)
            {
                label3.Text = "";
                label2.Text = CashierClass.peekNumber;
                return;
            }
            else if 

            (CashierClass.peekNumber.Length == 0)
            {

                label3.Text = "(Queue Empty)";
                label2.Text = "";

            }



        }

    }
    }