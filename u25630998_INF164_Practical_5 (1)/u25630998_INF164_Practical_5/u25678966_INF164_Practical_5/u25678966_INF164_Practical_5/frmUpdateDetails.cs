using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static u25678966_INF164_Practical_5.frmCellularExpress;

namespace u25678966_INF164_Practical_5
{
    public partial class frmUpdateDetails : Form
    {

        private Contracts contractToUpdate;

        public frmUpdateDetails(Contracts contract)
        {
            InitializeComponent();
            contractToUpdate = contract;

            //Fill fields with existing data
            txtUName.Text = contract.mClientName;
            txtUSurname.Text = contract.mClientSurname;
            txtUDName.Text = contract.mDeviceName;
            dtpUCDate.Value = contract.mContractDate;
            nudUMonths.Value = contract.mMonthsRemaining;
        }
        
        private void frmUpdateDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnUAdd_Click_1(object sender, EventArgs e)
        {
            //Update contract with new values
            contractToUpdate.mClientName = txtUName.Text;
            contractToUpdate.mClientSurname = txtUSurname.Text;
            contractToUpdate.mDeviceName = txtUDName.Text;
            contractToUpdate.mContractDate = dtpUCDate.Value;
            contractToUpdate.mMonthsRemaining = (int)nudUMonths.Value;

            MessageBox.Show("Contract has been updated!");
            this.Close();
        }
    }
}
