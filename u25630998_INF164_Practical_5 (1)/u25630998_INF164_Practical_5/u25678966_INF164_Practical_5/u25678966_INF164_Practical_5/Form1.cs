using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u25678966_INF164_Practical_5
{
    public partial class frmCellularExpress : Form
    {
        //Bind list to hold contracts
        private BindingList<Contracts> contractList = new BindingList<Contracts>();

        
        public frmCellularExpress()
        {
            InitializeComponent();
            dgvContractRecords.DataSource = contractList;
        }

        private void frmCellularExpress_Load(object sender, EventArgs e)
        {
            //Load some contract data
            contractList.Add(new Contracts("John", "Doe", "iPhone 14", DateTime.Now, 12));
            contractList.Add(new Contracts("Sarah", "Smith", "Samsung S23", DateTime.Now, 24));
            contractList.Add(new Contracts("Mike", "Brown", "Huawei P50", DateTime.Now, 6));
        }

        public class Contracts
        {
            public string mClientName { get; set; }
            public string mClientSurname { get; set; }
            public string mDeviceName { get; set; }
            public DateTime mContractDate { get; set; }
            public int mMonthsRemaining { get; set; }

            //Constructor
            public Contracts(string clientName, string clientSurname, string deviceName, DateTime contractDate, int month)
            {
                mClientName = clientName;
                mClientSurname = clientSurname;
                mDeviceName = deviceName;
                mContractDate = contractDate;
                mMonthsRemaining = month;
            }

            //Method to extend contract by 3 months
            public void ExtendContract()
            {
                mMonthsRemaining += 3;
            }
        }

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            if (dgvContractRecords.CurrentRow != null)
            {
                Contracts selected = (Contracts)dgvContractRecords.CurrentRow.DataBoundItem;
                contractList.Remove(selected);
                MessageBox.Show("Contract has been cancelled.");
            }
            else
            {
                MessageBox.Show("Please select a contract to cancel.");
            }
        }

        private void btnExtendC_Click(object sender, EventArgs e)
        {
             if (dgvContractRecords.CurrentRow != null)
             {
                Contracts selected = (Contracts)dgvContractRecords.CurrentRow.DataBoundItem;
                selected.ExtendContract();
                dgvContractRecords.Refresh();
                MessageBox.Show("Contract has been extended by 3 months.");
             }
            else
            {
                MessageBox.Show("Please select a contract to extend.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvContractRecords.CurrentRow != null)
            {
                Contracts selected = (Contracts)dgvContractRecords.CurrentRow.DataBoundItem;
                frmUpdateDetails updateForm = new frmUpdateDetails(selected);
                updateForm.ShowDialog();
                dgvContractRecords.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a contract to update.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create a new contract from textboxes and add to list
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string device = txtDName.Text;
            DateTime date = dtpCDate.Value;
            int months = (int)nudMonths.Value;

            Contracts c = new Contracts(name, surname, device, date, months);
            contractList.Add(c);

            MessageBox.Show("Contract has been added successfully!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvContractRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
