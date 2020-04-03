using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String Class = " ",Type = " ",Extra = " ";
        int Price = 0;

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNum.Text == "" || txtAddress.Text == "" )
                MessageBox.Show("please fill all the information");
            else
            {
                panel1.Enabled = true;

                tab.SelectedTab = Registration;
            }
            
        }

        
        private void rbClass_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                Class += rb.Text;

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in grpBoxClass.Controls)
            {
                    if (rb.Checked)
                    {
                        if (rb.Text == "Yoga")
                        {
                            if (rdbtnDaily.Checked)
                                Price += 10 * Convert.ToInt32(numericUpDown1.Value);
                            else
                                if (rdbtnMonthly.Checked)
                                    Price += 100;
                        }
                        else
                        {
                            if (rb.Text == "Zumba")
                            {
                                if (rdbtnDaily.Checked)
                                    Price += 10 * Convert.ToInt32(numericUpDown1.Value);
                                else
                                    if (rdbtnMonthly.Checked)
                                        Price += 100;
                            }
                            else
                            {
                                if (rb.Text == "Swimming")
                                {
                                    if (rdbtnDaily.Checked)
                                        Price += 14 * Convert.ToInt32(numericUpDown1.Value);
                                    else
                                        if (rdbtnMonthly.Checked)
                                            Price += 140;
                                }
                                else
                                {
                                    if (rb.Text == "Aqua Zumba")
                                    {
                                        if (rdbtnDaily.Checked)
                                            Price += 14 * Convert.ToInt32(numericUpDown1.Value);
                                        else
                                            if (rdbtnMonthly.Checked)
                                                Price += 140;
                                    }

                                }

                        }
                      
                        }
                    } 
                }
            foreach (CheckBox cb in grpBoxExtra.Controls)
            {
                if (cb.Checked)
                {
                    if (cb.Text == "Treadmill")
                    {
                        Price += 10;
                    }
                    if (cb.Text == "Elliptical")
                    {
                        Price += 10;
                    }
                    if (cb.Text == "Pool")
                    {
                        Price += 30;
                    }
                    if (cb.Text == "Sauna")
                    {
                        Price += 30;
                    }
                }
            }
            
            
                    txtInfo.Text = "Name: " + txtName.Text + " " + "\r\n" + "Telephone: " + txtNum.Text + "\r\n" + "Address: " + txtAddress.Text;
                    txtDetails.Text = "class: " + Class + "\r\n" + "Type: " + Type + "\r\n" + "Extra: " + Extra + "\r\n" + "Price:$ " + Price;
                    tab.SelectedTab = Bill;
                }
          

    
        private void cbExtra_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
                Extra += cb.Text;
        }


        private void btnRegistation_Click(object sender, EventArgs e)
        { 
            txtName.ResetText();
            txtNum.ResetText();
            txtAddress.ResetText();
            panel1.Enabled = false;
            numericUpDown1.Enabled = false;
            rdbtnMonthly.Checked = false;
            rdbtnDaily.Checked = false;
            foreach (RadioButton rb in grpBoxClass.Controls)
                rb.Checked = false;
            foreach (CheckBox cb in grpBoxExtra.Controls)
                cb.Checked = false;
            txtInfo.ResetText();
            txtDetails.ResetText();
            tab.SelectedTab = Info;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbtnMonthly_CheckedChanged(object sender, EventArgs e)
        {
            Type += rdbtnMonthly.Text;
        }

        private void rdbtnDaily_CheckedChanged(object sender, EventArgs e)
        {
            Type += rdbtnDaily.Text;
            numericUpDown1.Enabled = true;
        }
       
    }
}
