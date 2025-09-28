using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INF164_Practical_1C_u25630998
{
    public partial class FrmPersonalDetails: Form
    {
        public FrmPersonalDetails()
        {
            InitializeComponent();
        }

        
        private void FrmPersonalDetails_Load(object sender, EventArgs e)
        {
            string[] faculty = { "EBIT", "Humanities" };
            cbxFaculty.Items.AddRange(faculty);
        }
        private void cbxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDegree.Items.Clear();
            if (cbxFaculty.SelectedItem != null)
            {
                string selectedValue = cbxFaculty.SelectedItem.ToString();

                if (selectedValue == "EBIT")
                {
                    string[] EBITdegrees = { "Computer Science", "Information Science" };
                    cbxDegree.Items.AddRange(EBITdegrees);
                }
                else if (selectedValue == "Humanities") // Use else if for clarity
                {
                    string[] Humanititesdegrees = { "Sociology", "Philosophy" };
                    cbxDegree.Items.AddRange(Humanititesdegrees);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblName.Text = "Name: " + txtName.Text;
            lblFaculty.Text = "Faculty: "+ cbxFaculty.Text;
            lblDegree.Text = "Degree: "+ cbxDegree.Text;
            lblSurname.Text = "Surname:"+ txtSurname.Text;

            
            
        }

        private void btnViewBiography_Click(object sender, EventArgs e)
        {
            frmBiography myForm = new frmBiography();
            myForm.ShowDialog();
        }

       
    }
}
