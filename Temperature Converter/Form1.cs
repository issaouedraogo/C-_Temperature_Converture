using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double userInput = 0; // declare the variable to containe the usetr input

            double fahrenheit = 0; // declare the varaible for fahrenhei

            double celsuis= 0; // declare the varaible for celsuis

            double kelvin = 0; // declare the varaible for kelvin

            // we going make sure that the user enter a raisonable value
            // if it si no, we sent him back for a new input

            if (double.TryParse(txtInput.Text, out userInput ) == false)
            {   
                //let us clean up in case  the User enter an input that is not reasonable

                lblFahrenhiet.Text = " ";
                lblCelsuis.Text = "";
                lblKelvin.Text = "";
                MessageBox.Show("tempurature cannot be this type of valus you enter" + Environment.NewLine +
                     "please enter a reasonble value" );
                txtInput.Focus(); //we fucus on the input text box 
                txtInput.SelectAll(); // we select all the non reasonble data the uesr enter
                return;
            }
            switch (cboSelect.Text)
            {
                case "fahrenheit":
                    // In this case the user input is in fahrenheit 
                    fahrenheit = userInput; // assignment of user input to fahrenheit varaible
                    // now we are going to use the formala  of figure out the input
                    // value in celsuis and in kelvin
                    celsuis = (fahrenheit - 32) * 5 / 9; // celsuis calculation
                    kelvin = celsuis + 273.15; // kelvin calculation
                    break;
                case "celsuis":
                    //  In this case the user input is in celsuis
                    celsuis = userInput; // assignment of user input to celsuis 
                    // now we are going to use the formala  figure out the input
                    // value in celsuis and in kelvin
                    fahrenheit = celsuis * 1.8 + 32; ;
                    kelvin = celsuis + 273.15;
                    break;
                case "kelvin":
                    //  In this case the user input is in kelvin
                    kelvin = userInput; // assingnment of user inout to celsuid 
                    // now we are going to use the conversion formula to find out the user input 
                    //value in fahranheit and in celsuis;
                    celsuis = kelvin - 273.15; // celsuis calculation; 
                    fahrenheit = celsuis * 1.8 + 15; // kelvin calculation;
                    break;
            }
            // now let go head and display the three temperature varaibles un three labels

            lblFahrenhiet.Text = fahrenheit.ToString("N2"); // display for Fahrenhiet  value at two digit numbers

            lblCelsuis.Text = celsuis.ToString("N2"); // display for celsuis value at two digit numbers

            lblKelvin.Text = kelvin.ToString("N2"); // display for Kelvin  value at two digit numbers


        }

        private void btnExit_Click(object sender, EventArgs e)
        {   
            // In case the user finish using the software, he has a very easy way to exit 
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // This gave the user the possibility to clear the value between temperature convertion
            txtInput.Text = "";
            lblFahrenhiet.Text = "";
            lblCelsuis.Text = "";
            lblKelvin.Text = "";
            // after cleaning up everything; we focus on text box so the user can enter the datafor the next convertion
            txtInput.Focus(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
