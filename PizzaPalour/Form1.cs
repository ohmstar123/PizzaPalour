using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPalour
{
    public partial class Form1 : Form
    {
        int topings;
        double total;

        const double BASE = 7.00;
        const double TOPING = 1.25;
        //const

        public Form1()
        {
            InitializeComponent();
        }
        
    
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Take the toppings value from the input box and put it in the appropriate variable.
                topings = Convert.ToInt32(TopingsImput.Text);

                /// Calculate the price of the pizza and put the result in the appropriate variable.

                /// (base price + toppings * number of toppings)
                total = BASE + TOPING * topings;

                //  Display the price from the variable to the screen, (see example below), formatted to 2 decimal places with dollar sign in front.
                outputLabel.Text = " The price of a pizza with " + topings + " topings is: " + "\n" + total.ToString("C");
            }
            catch
            {
                outputLabel.Text = "  please enter the number of topings";
            }
        }
       
    } 
}
