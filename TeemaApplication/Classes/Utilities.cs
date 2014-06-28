using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeemaApplication.Datasets;

namespace TeemaApplication.Classes
{
    static class Utilities
    {

        public static void ShowInformationBox(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowWarningBox(string message)
        {
            return MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static void ShowUnAuthorizedAccessBox(string message)
        {
            MessageBox.Show(message, "Un Athorized Access", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static void ShowExceptionBox(string message)
        {
            ShowErrorBox("Ooops!, Something went wrong while excecuting. Please try again. If you frequntly get this error please contact administrator. Error information : " + message);
        }

        public static void fillBranchComboBox(TeemaDBDataContext db, ComboBox comboBox)
        {
            comboBox.DisplayMember = "BranchName";
            comboBox.ValueMember = "BranchID";
            comboBox.DataSource = db.Branches;
        }

        public static void fillDepartmentComboBox(Branch branch, ComboBox comboBox)
        {
            comboBox.DisplayMember = "DepartmentName";
            comboBox.ValueMember = "DepartmentID";
            comboBox.DataSource = branch.Departments;
        }

        public static void fillSubDepartmentComboBox(Department department, ComboBox comboBox)
        {
            comboBox.DisplayMember = "SubDepartmentName";
            comboBox.ValueMember = "SubDepartmentID";
            comboBox.DataSource = department.SubDepartments;
        }

        public static double getDoubleValueFromTextBox(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                double value = 0;
                if (double.TryParse(textBox.Text, out value))
                {
                    return value;
                }
                else
                {
                    textBox.Text = "0.00";
                    return 0.0;
                }
            }
            else
            {
                textBox.Text = "0.00";
                return 0.0;
            }
        }

        public static int getIntValueFromTextBox(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                int value = 0;
                if (int.TryParse(textBox.Text, out value))
                {
                    return value;
                }
                else
                {
                    textBox.Text = "0";
                    return 0;
                }
            }
            else
            {
                textBox.Text = "0";
                return 0;
            }
        }

        public static void checkIfContainIntegerValue(TextBox textBox)
        {
            int value = 0;
            if (!int.TryParse(textBox.Text, out value))
            {
                ShowErrorBox("Please enter correct value for text field.");
                textBox.Text = "0";
                textBox.Focus();
            }
        }

        public static void checkIfContainDoubleValue(TextBox textBox)
        {
            double value = 0;
            if (!double.TryParse(textBox.Text, out value))
            {
                ShowErrorBox("Please enter correct value for text field.");
                textBox.Text = "0";
                textBox.Focus();
            }
        }

        public static bool checkIfContainText(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ShowErrorBox("Please enter correct text for text field.");
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool checkIfValueSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                ShowErrorBox("Please select a value from drop down list.");
                comboBox.Focus();
                return false;
            }
            return true;
        }
    }
}
