using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u25630998_INF154_practical_4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            string CustomerName, output;
            int UnitsUsed, units;
            const double rate1 = 2.5, rate2 = 5, rate3 = 7.5, rate4 = 10, supercharge = 0.14;
            double Bill, SuperCharge;

            
           

            if (txt_CustomerName.Text.Length == 0 || txt_UnitsUsed.Text.Length == 0)
            {
                MessageBox.Show("Your Name and/or Water Units can not be mepty");
                return;
            }
            
            
            if(!int.TryParse(txt_UnitsUsed.Text, out UnitsUsed))
            {
                MessageBox.Show("Your Water Units value must be an integer");
                return;
            }

            UnitsUsed = Convert.ToInt32(txt_UnitsUsed.Text);
            CustomerName = txt_CustomerName.Text;

            Bill = 0;
            SuperCharge = 0;




            if (UnitsUsed >= 40 && UnitsUsed <= 200)
            {
                Bill = UnitsUsed * rate1;
                rtb_BillOutput.Text = "Customer Name: " + CustomerName + "\n" + "Units Used: " + UnitsUsed + "\n" + "Charge Rate: R" + rate1 + "\n" + " SuperCharge Amount: R" + SuperCharge + "\n" + "Monthly Bill Due: R" + Bill;

            }else if(UnitsUsed > 200 && UnitsUsed <= 400)
            {
                Bill = UnitsUsed * rate2;
                rtb_BillOutput.Text = "Customer Name: " + CustomerName + "\n" + "Units Used: " + UnitsUsed + "\n" + "Charge Rate: R" + rate2 + "\n" + " SuperCharge Amount: R" + SuperCharge + "\n" + "Monthly Bill Due: R" + Bill;


            }
            else if (UnitsUsed > 400 && UnitsUsed <= 600)
            {
                Bill = UnitsUsed * rate3;
                rtb_BillOutput.Text = "Customer Name: " + CustomerName + "\n" + "Units Used: " + UnitsUsed + "\n" + "Charge Rate: R" + rate3 + "\n" + " SuperCharge Amount: R" + SuperCharge + "\n" + "Monthly Bill Due: R" + Bill;
                if (Bill > 3000)
                {
                    SuperCharge = supercharge * Bill;
                    Bill = Bill + SuperCharge;
                    rtb_BillOutput.Text = "Customer Name: " + CustomerName + "\n" + "Units Used: " + UnitsUsed + "\n" + "Charge Rate: R" + rate3 + "\n" + " SuperCharge Amount: R" + SuperCharge + "\n" + "Monthly Bill Due: R" + Bill;

                }
            }
            else if (UnitsUsed < 40)
            {
                Bill = 100;
                rtb_BillOutput.Text = "Customer Name: " + CustomerName + "\n" + "Units Used: " + UnitsUsed + "\n" + "Charge Rate: R" + rate1 + "\n" + " SuperCharge Amount: R" + SuperCharge + "\n" + "Monthly Bill Due: R" + Bill;

            }
            else
            {
                Bill = UnitsUsed * rate4;
                if (Bill > 3000)
                {
                    SuperCharge = supercharge * Bill;
                    Bill = Bill + SuperCharge;
                    rtb_BillOutput.Text = "Customer Name: " + CustomerName + "\n" + "Units Used: " + UnitsUsed + "\n" + "Charge Rate: R" + rate4 + "\n" + " SuperCharge Amount: R" + SuperCharge + "\n" + "Monthly Bill Due: R" + Bill;

                }
            }



        }
    }
}

               

                


