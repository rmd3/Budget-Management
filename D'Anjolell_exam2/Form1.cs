using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace D_Anjolell_exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Closes the program
            this.Close();
        }

        private double CalculateBill()
        {
            //Declaring variables
            double billTotal = 0;
            int count = 0;
            int numberOfBills;
            string billCost;
            string billNumber;

            //Gaining input from user
            numberOfBills = int.Parse(txtBills.Text);

            //While statement to determine the cost of each bill and their total
            while (count < numberOfBills){
                //Count accumalation to keep track of what bill we're on
                count += 1;

                //Conversion of the count to the bill number we are on
                billNumber = count.ToString();

                //Input box for the user to enter the amount that numbered bill cost
                billCost = Interaction.InputBox("Enter Bill " + billNumber + " Amount", "Bill Amount", "0.00", -1, -1);

                //Accumalation of all bill costs
                billTotal += Convert.ToDouble(billCost);
            }

            //Returns the total cost of bills the user entered
            return billTotal;
        }

        private double CalculateBudget() 
        {
            //Declaring variables
            double budgetAmount;
            double billsAmount;
            double remainingBudget;

            //Gaining input from user
            budgetAmount = double.Parse(txtBudget.Text);

            //Gain info from CalculateBill function
            billsAmount = CalculateBill();

            //Calculate for remaining budget
            remainingBudget = budgetAmount - billsAmount;

            //Returns the remaing budget after paying the bills
            return remainingBudget;
        }

        private string CalculateMonth() 
        {
            //Declare variable
            string budgetMonth;

            //If statements to determine the month
            if (radJan.Checked)
            {
                budgetMonth = "January";
            }

            else if (radFeb.Checked)
            {
                budgetMonth = "February";
            }

            else if (radMarch.Checked)
            {
                budgetMonth = "March";
            }

            else if (radApril.Checked)
            {
                budgetMonth = "April";
            }

            else if (radMay.Checked)
            {
                budgetMonth = "May";
            }

            else if (radJune.Checked)
            {
                budgetMonth = "June";
            }

            else if (radJuly.Checked)
            {
                budgetMonth = "July";
            }

            else if (radAug.Checked)
            {
                budgetMonth = "August";
            }

            else if (radSept.Checked)
            {
                budgetMonth = "September";
            }

            else if (radOct.Checked)
            {
                budgetMonth = "October";
            }

            else if (radNov.Checked)
            {
                budgetMonth = "November";
            }

            else if (radDec.Checked)
            {
                budgetMonth = "December";
            }

            else
            {
                budgetMonth = "Month not selected";
            }

            //Returns month that is being budgeted
            return budgetMonth;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Declaring variables
            double monthBudget = double.Parse(txtBudget.Text);
            double budgetTotal = CalculateBudget();
            double billTotal = (budgetTotal - monthBudget) * -1;
            string budgetMonth = CalculateMonth();

            //To clear any remaining info from last use
            lstResult.Items.Clear();

            //Add text to the listbox result
            lstResult.Items.Add("Month: " + budgetMonth);
            lstResult.Items.Add("Budget: $" + txtBudget.Text);
            lstResult.Items.Add("Number of Bills: " + txtBills.Text);
            lstResult.Items.Add("Bills Total: $" + billTotal);

            //If statement to determine if the budget went over
            if (budgetTotal < 0){
                lstResult.Items.Add("You went over the budget!");
            }

            else{
                lstResult.Items.Add("You didn't go over the budget!");
            }
        }
    }
}
