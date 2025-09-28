using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u25630998_INF164_Practical_4
{
    public partial class Form1 : Form
    {
        Orders[] orders = new Orders[3];
        int orderCount = 0;

        public Form1()
        {
            InitializeComponent();
            dgvOrders.ColumnCount = 5;
            dgvOrders.Columns[0].Name = "Item";
            dgvOrders.Columns[1].Name = "Time";
            dgvOrders.Columns[2].Name = "Distance";
            dgvOrders.Columns[3].Name = "Super";
            dgvOrders.Columns[4].Name = "Price";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (orderCount >= 3)
            {
                MessageBox.Show("You can only place 3 orders.");
                return;
            }

            string item = cmbItem.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please select an item.");
                return;
            }

            DateTime time = dtpTime.Value;
            int distance = (int)nudDistance.Value;
            bool superSize = chkSuperSize.Checked;

            Orders newOrder = new Orders(item, time, distance, superSize);
            orders[orderCount] = newOrder;

            dgvOrders.Rows.Add(newOrder.Item, newOrder.Time.ToLongTimeString(),
                               newOrder.Distance, newOrder.SuperSize, "R" + newOrder.Price);

            orderCount++;

            if (orderCount == 3)
                grpSearch.Enabled = true;  // enable search after 3 orders
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (orderCount < 3)
            {
                MessageBox.Show("Add 3 orders first!");
                return;
            }

            int index = rdoOrder1.Checked ? 0 : rdoOrder2.Checked ? 1 : 2;
            Orders selectedOrder = orders[index];

            string result = "";
            if (chkItem.Checked) result += $"Item: {selectedOrder.Item}\n";
            if (chkTime.Checked) result += $"Time: {selectedOrder.Time.ToLongTimeString()}\n";
            if (chkDistance.Checked) result += $"Distance: {selectedOrder.Distance}\n";
            if (chkSuper.Checked) result += $"Super: {selectedOrder.SuperSize}\n";
            if (chkPrice.Checked) result += $"Price: R{selectedOrder.Price}\n";

            MessageBox.Show(result, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
