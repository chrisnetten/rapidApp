/*By: Christopher Netten
Date Due: 2015-11-24 11AM
Purpose: To Calculate the cost of shipment depending on weight and shipping zone */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        DialogResult responseDialogResult;
       

       

        public Form1()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Message Box to confirm Exit
            responseDialogResult = MessageBox.Show("Exit The Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If YES pressed
            if (responseDialogResult == DialogResult.Yes)
            {
                //Close the Application
                this.Close();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
             

            responseDialogResult = MessageBox.Show("Clear the current order?", "Clear order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //check if user confirms
           if(responseDialogResult == DialogResult.Yes)
            {
                //Clearing price box and returning default color, aswell as reseting combobox and radiobuttons   
                priceTextBox.Clear();
                priceTextBox.BackColor = default(Color);
                zoneComboBox.Items.Clear(); 
                lb1RadioButton.Checked = false;
                lb3RadioButton.Checked = false;
                lb5RadioButton.Checked = false;
                lb10RadioButton.Checked = false;
                lb10PlusRadioButton.Checked = false;

                
             

                
            }
        }

        private void zoneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //initialize variable choiceDouble
            double choiceDouble = 0;
            
            // Creating the 2D array and setting its values
            double[,] shipPriceDouble = new double[,] { { 1,1.50,1.65,1.85}, {1.58,2,2.40,3.05 }, {1.71,2.52,3.10,4 }, {2.04,3.12,4,5.01 }, {2.52,3.75,5.10,7.25 } };

            // Has to be better way to do this
            // If statement to validate users choice and print it to priceTextBox

            if (zoneComboBox.SelectedItem.ToString() == "Zone A" & lb1RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[0, 0];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone A" & lb3RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[1, 0];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone A" & lb5RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[2, 0];
            }else if (zoneComboBox.SelectedItem.ToString() == "Zone A" & lb10RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[3, 0];
            }else if (zoneComboBox.SelectedItem.ToString() == "Zone A" & lb10PlusRadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[4, 0];

            }else if( zoneComboBox.SelectedItem.ToString() == "Zone B" & lb1RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[0, 1];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone B" & lb3RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[1, 1];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone B" & lb5RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[2, 1];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone B" & lb10RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[3, 1];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone B" & lb10PlusRadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[4, 1];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone C" & lb1RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[0, 2];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone C" & lb3RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[1, 2];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone C" & lb5RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[2, 2];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone C" & lb10RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[3, 2];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone C" & lb10PlusRadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[4, 2];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone D" & lb1RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[0, 3];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone D" & lb3RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[1, 3];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone D" & lb5RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[2, 3];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone D" & lb10RadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[3, 3];
            }
            else if (zoneComboBox.SelectedItem.ToString() == "Zone D" & lb10PlusRadioButton.Checked)
            {
                choiceDouble = shipPriceDouble[4, 3];
            }
            priceTextBox.Text = choiceDouble.ToString("c");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            responseDialogResult = MessageBox.Show("Clear the current order?", "Clear order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //check if user confirms
            if (responseDialogResult == DialogResult.Yes)
            {

                //Clearing price box and returning default color, aswell as reseting combobox and radiobuttons
                priceTextBox.Clear();
                zoneComboBox.SelectedIndex = -1;
                lb1RadioButton.Checked = false;
                lb3RadioButton.Checked = false;
                lb5RadioButton.Checked = false;
                lb10RadioButton.Checked = false;
                lb10PlusRadioButton.Checked = false;





            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Message Box to confirm Exit
            responseDialogResult = MessageBox.Show("Exit The Application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if YES pressed 
            if (responseDialogResult == DialogResult.Yes)
            {
                //Close the Application
                this.Close();
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show font dialog
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                // Set TextBox properties.
                this.priceTextBox.Font = font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show color dialog
            DialogResult result = colorDialog1.ShowDialog();

            //See if OK was pressed
            if(result == DialogResult.OK)
            {
                //Set Textbox backcolor to chosen color
                priceTextBox.BackColor = colorDialog1.Color;

            }
        }

 
    }
}
