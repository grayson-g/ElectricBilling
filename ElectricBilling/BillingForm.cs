using ElectricBillingData;
using ElectricBillingForm;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ElectricBilling
{
    /*
     * This 
     */
    public partial class BillingForm : Form
    {
        private List<Customer> customers;                                                           // List of customers
        private BillingPeriod billingPeriod;                                                        // BillingPeriod used to calculate billing

        private const decimal PRICE_PER_KWH = 0.07m;                                                // Price per kWh, used to calculate billing
        private const decimal ADMIN_FEE = 12.00m;                                                   // Fixed fee per bill

        public BillingForm()
        {
            InitializeComponent();

            customers = new List<Customer>();                                                       // Create a new list of customers

            billingPeriod = new BillingPeriod(PRICE_PER_KWH);                                       // Create a BillingPeriod used to calculate customer billing
            billingPeriod.FixedFees.Add(new FixedFee("Administration", ADMIN_FEE));                 // Add a fixed admin fee of $12.00
        }

        private void OnLoad(object sender, EventArgs e)
        {
            // Add some customers with a variety of power usages
            customers.Add(new Customer("John", "Smith", 100));
            customers.Add(new Customer("Mark", "McDonald", 0));
            customers.Add(new Customer("Emma", "Caulfield", 1600));
            customers.Add(new Customer("Patricia", "Jones", 570));
            customers.Add(new Customer("Marcus", "Greene"));

            UpdateCustomers();                                                                      // Update display
        }

        private void OnSelectCustomer(object sender, EventArgs e)
        {
            UpdateCustomerDisplay();                                                                // Update the customer display
        }

        private void UpdateCustomers()
        {
            CustomerListBox.Items.Clear();                                                          // Clear and refill ListBox Items to ensure coherency between lists
            foreach (Customer customer in customers)
                CustomerListBox.Items.Add(customer);                                                // Add each customer to ListBox

            UpdateStatistics();                                                                     // Update the overall statistics
            UpdateCustomerDisplay();                                                                // Update the customer display
        }

        private void UpdateCustomerDisplay()
        {
            if (CustomerListBox.SelectedIndex == -1 || customers.Count == 0)                        // If there is no selection (after load or after deleting a customer), clear the displays
            {
                CustomerID.Text = "";
                CustomerName.Text = "";
                CustomerUsage.Text = "";
                CustomerBilled.Text = "";
            }
            else                                                                                    // Otherwise there is a customer, so show their data
            {
                Customer selected = CustomerListBox.SelectedItem as Customer;                       // The selected customer, non-null, since checked above & all elements of the ListBox are Customer objects
                decimal billedAmount = billingPeriod.CalculateBilling(selected);                    // Their power bill, as determined by the billing period

                CustomerID.Text = $"{selected.ID}";                                                 // Display ID
                CustomerName.Text = $"{selected}";                                                  // Display full name (ToString returns full name)
                CustomerUsage.Text = $"{selected.PowerUsedKWh:F2} kWh";                             // Display power usage, formatted as float w/ 2 decimal places
                CustomerBilled.Text = $"{billedAmount:C2}";                                         // Display billed amount, formatted as currency w/ 2 decimal places
            }
        }

        private void UpdateStatistics()
        {
            int customerCount = customers.Count();                                                  // Number of customers

            if (customerCount > 0)                                                                  // There are customers, so show the statistics
            {
                decimal totalBilled, averageBilled,                                                 // Variables for totals & averages of usage and billing
                        totalUsage, averageUsage;
                /* 
                 * I used the built-in List.Sum functions to calculate total billing & usage,
                 * this takes a lambda function for non-value types (Customer) letting me 
                 * set how the "value" of each element is calculated
                 * 
                 * total billed = sum of billingPeriod.CalculateBilling(...) for each customer
                 *                (value of each customer is their calculated billing)
                 *                
                 * total usage  = sum of customer.PowerUsedKWh for each customer
                 *                (value of each customer is the power they used)
                 */
                totalBilled = customers.Sum(customer => billingPeriod.CalculateBilling(customer));
                totalUsage = customers.Sum(customer => customer.PowerUsedKWh);

                averageBilled = totalBilled / customerCount;                                        // Average billing is total / n
                averageUsage = totalUsage / customerCount;                                          // Average usage is total / n

                CustomerCount.Text = $"{customerCount}";                                            // Set the text fields
                TotalBilled.Text = $"{totalBilled:C2}";                                             // Total Billed, currency formatting with 2 decimal places
                TotalUsage.Text = $"{totalUsage:F2} kWh";                                           // Total Usage, float formatting with 2 decimal places
                AverageBilled.Text = $"{averageBilled:C2}";                                         // Avg. Billed, currency formatting with 2 decimal places
                AverageUsage.Text = $"{averageUsage:F2} kWh";                                       // Avg. Usage, float formatting with 2 decimal places
            }
            else                                                                                    // There aren't customers, so clear the statistics
            {
                CustomerCount.Text = "0";                                                           // Reset the customer info fields
                TotalBilled.Text = "";
                TotalUsage.Text = "";
                AverageBilled.Text = "";
                AverageUsage.Text = "";
            }
        }

        private void OnClickAdd(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();                                            // Create a new AddCustomerForm
            var result = addCustomerForm.ShowDialog();                                              // Await the result

            if (result == DialogResult.OK)                                                          // OK means there is customer data to add to the customer list
            {
                customers.Add(addCustomerForm.CustomerData);                                        // Add the new customer data
                UpdateCustomers();                                                                  // Update the display
            }
        }

        private void OnClickRemove(object sender, EventArgs e)
        {
            if (customers.Count == 0)                                                               // If there are no customers, show a prompt and return
            {
                MessageBox.Show("There are currently no customers");
                return;
            }

            if (CustomerListBox.SelectedIndex == -1)                                                // If there's no selection, show a prompt and return
            {
                MessageBox.Show("You must select a customer");
                return;
            }

            Customer selected = CustomerListBox.SelectedItem as Customer;                           // We now know there is a selected customer

            if (MessageBox.Show(
                $"Are you sure you would like to remove {selected}? This action cannot be undone.", // Ask for confirmation to delete
                "Remove Customer",
                MessageBoxButtons.YesNo,                                                            // A Yes/No option
                MessageBoxIcon.Warning,                                                             // Show a warning symbol
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)                               // Auto-Select "No"
            {
                customers.RemoveAt(CustomerListBox.SelectedIndex);                                  // Remove the customer
                UpdateCustomers();                                                                  // Update display
            }
        }
    }
}