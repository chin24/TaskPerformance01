using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        public String peekNumber; 

        public CashierWindowQueueForm()
        {

            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            if (CashierClass.CashierQueue.Count == 0)
            {
           
                label1.Text = "(Queue Empty)";
                btnNext.Enabled = false;
                label1.Visible = true;
            }
                DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        
            CashierClass.peekNumber = CashierClass.CashierQueue.Dequeue();
            DisplayCashierQueue(CashierClass.CashierQueue);
            CashierClass.peekNumber = "";

        }

        private void DisplayCashierQueue(IEnumerable CashierList)
        {
           
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
      

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.peekNumber = CashierClass.CashierQueue.Peek();
       
                label1.Text = "";
                btnNext.Enabled = true;
                btnRefresh.Enabled = true;
                label1.Visible = false;
                
                
            }
            else
            {
                CashierClass.peekNumber = "";
                label1.Text = "(Queue Empty)";
                btnNext.Enabled = false;
                btnRefresh.Enabled = false;
                label1.Visible = true;
            }
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
