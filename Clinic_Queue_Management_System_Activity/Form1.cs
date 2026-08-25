using System;
using System.Windows.Forms;

namespace Clinic_Queue_Management_System_Activity
{
    public partial class Form1 : Form
    {
        // Shared Queue Counter across button clicks
        private int queueCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all patient fields and select a Patient Type.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out int age) || age < 0)
            {
                MessageBox.Show("Please enter a valid numeric age.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Shared Queue Logic (Q001, Q002, etc.)
            queueCounter++;
            string queueNumber = $"Q{queueCounter:D3}";

            // Priority Logic
            string selectedType = comboBox1.SelectedItem.ToString();
            string priorityDisplay = "";

            switch (selectedType)
            {
                case "Emergency":
                    priorityDisplay = "EMERGENCY";
                    break;
                case "Senior":
                    priorityDisplay = "SENIOR PRIORITY";
                    break;
                case "Pregnant":
                    priorityDisplay = "PRIORITY";
                    break;
                case "Regular":
                    priorityDisplay = "REGULAR";
                    break;
                default:
                    priorityDisplay = "REGULAR";
                    break;
            }

            // Output Results
            lblQueueNumber.Text = queueNumber;
            lblPatientTypeOutput.Text = selectedType;
            lblPriority.Text = priorityDisplay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear inputs
            textBox1.Clear(); // Name
            textBox2.Clear(); // Age
            textBox3.Clear(); // Reason
            comboBox1.SelectedIndex = -1; // Patient Type

            // Reset outputs
            lblQueueNumber.Text = "---";
            lblPatientTypeOutput.Text = "---";
            lblPriority.Text = "---";

            textBox1.Focus();
        }
    }
}