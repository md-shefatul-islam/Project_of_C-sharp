using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double result, value;
        private string operation;
        private bool performed = false;
        public Form1()
        {
            InitializeComponent();
            //this.txtDisplay.ReadOnly = true;
        }
       /* public Form1(double value)
        {
            InitializeComponent();
            this.txtDisplay.ReadOnly = true;
            this.value = value;
        }*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text = "";
            //result = 0;
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            
            if ((this.txtDisplay.Text == "0")|| performed)
            {
                this.txtDisplay.Text = "";
            }

            performed = false;
            Button btn = (Button)sender;
            //this.txtDisplay.Text =btn.Text;
            if (btn.Text == ".")
            {
                if (!this.txtDisplay.Text.Contains("."))
                {
                    this.txtDisplay.Text += btn.Text;
                }
            }
            else
            {
                this.txtDisplay.Text += btn.Text;
            }

        }

        private void operator_clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            /*if (this.txtDisplay.Text == "")
            {
                this.txtDisplay.Text = "0";
            }*/

            //this.txtDisplay.Text = btn.Text;
            /*if (result != 0)
            {
                
                    btnEqual.PerformClick();
                operation = btn.Text;
                txtDisplay.Text = result + " " + operation;
                performed = true;
            }
            else*/ {
                if (btn.Text == "+")
                {
                    if (!this.txtDisplay.Text.Contains("+"))
                    {
                        result = Convert.ToDouble(this.txtDisplay.Text);
                        this.txtDisplay.Text = result + "" + operation;
                        performed = true;
                    }
                }
                else if (btn.Text == "-")
                {
                    if (!this.txtDisplay.Text.Contains("-"))
                    {
                        result = Convert.ToDouble(this.txtDisplay.Text);
                        this.txtDisplay.Text = result + "" + operation;
                        performed = true;
                    }
                }
                else if (btn.Text == "*")
                {
                    if (!this.txtDisplay.Text.Contains("*"))
                    {
                        result = Convert.ToDouble(this.txtDisplay.Text);
                        this.txtDisplay.Text = result + "" + operation;
                        performed = true;
                    }
                }
                else if (btn.Text == "/")
                {
                    if (!this.txtDisplay.Text.Contains("/"))
                    {
                        result = Convert.ToDouble(this.txtDisplay.Text);
                        this.txtDisplay.Text = result + "" + operation;
                        performed = true;
                    }
                }
                else
                {
                    this.txtDisplay.Text += btn.Text;
                }

            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "=")
            {
                if (!this.txtDisplay.Text.Contains("="))
                {



                    switch (operation)
                    {
                        case "+":
                            result = (result + Convert.ToDouble(this.txtDisplay.Text));
                            //this.Operationperformed();
                            this.txtDisplay.Text = result.ToString();
                            result = 0;
                            break;

                        case "-":
                            result = result - Convert.ToDouble(this.txtDisplay.Text);
                            this.txtDisplay.Text = result.ToString();
                            result = 0;
                            break;

                        case "*":
                            result = result * Convert.ToDouble(this.txtDisplay.Text);
                            this.txtDisplay.Text = result.ToString();
                            result = 0;
                            break;

                        case "/":
                            result = result / Convert.ToDouble(this.txtDisplay.Text);
                            
                            if (this.txtDisplay.Text == value.ToString())
                            {
                                value = (Convert.ToDouble(this.txtDisplay.Text)) / 0;
                                MessageBox.Show("Undefiend");
                                this.txtDisplay.Text = "";
                            }
                            this.txtDisplay.Text = result.ToString();
                            result = 0;
                            break;

                        default:
                    
                            break;
                    }



                }
            }
            else
            {
                this.txtDisplay.Text = "";
            }



        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            result = Convert.ToDouble(this.txtDisplay.Text);
            value = result / 100;
            this.txtDisplay.Text = value.ToString();
            performed = true;
        }

        //public void Operationperformed(object sender)
        //{
        //    Button btn = (Button)sender;
        //    if (btn.Text == "=")
        //    {
        //        if (!this.txtDisplay.Text.Contains("="))
        //        {
        //            this.txtDisplay.Text = "0";
        //        }
        //    }
        //    else
        //    {
        //        btnEqual.PerformClick();
        //    }


        //}
    }
}
