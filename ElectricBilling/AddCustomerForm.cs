using ElectricBillingData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricBillingForm
{
    public partial class AddCustomerForm : Form
    {
        private Customer _customerData;
        public Customer CustomerData { get => _customerData; }
        public AddCustomerForm()
        {
            InitializeComponent();

            CustomerID.Text = $"{Customer.NextID}";
        }

        private void OnClickConfirm(object sender, EventArgs e)
        {
            bool validData = true;
            string firstName = FirstName.Text.Trim();
            string lastName = LastName.Text.Trim();
            decimal kWhUsed;

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please provide a first name");
                validData = false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please provide a last name");
                validData = false;
            }

            if (!decimal.TryParse(Usage.Text, out kWhUsed))
            {
                MessageBox.Show("Please provide the amount of kWh used");
                validData = false;
            }

            if (validData && kWhUsed < 0)
            {
                MessageBox.Show("kWh usage must be non-negative");
                validData = false;
            }

            if (validData)
            {
                _customerData = new Customer(firstName, lastName, kWhUsed);
                DialogResult = DialogResult.OK;
            }
        }

        private void OnClickCancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
