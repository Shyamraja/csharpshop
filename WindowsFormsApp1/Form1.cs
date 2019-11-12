using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Blue;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Cadbury");
            cmb_items.Items.Add("Dairymilk");
            cmb_items.Items.Add("Stingers");
            cmb_items.Items.Add("Chocopie");
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Blue;
            
            cmb_items.Items.Clear();
            cmb_items.Items.Add("Car");
            cmb_items.Items.Add("Doll");
            cmb_items.Items.Add("Bike");
            cmb_items.Items.Add("Loader");
        }
        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmb_items.SelectedItem.ToString() == "Cadbury")
           {
                txt_price.Text = "1";
           }
           else if (cmb_items.SelectedItem.ToString() == "Dairymilk")
            {
                txt_price.Text = "2";
            }
            else if (cmb_items.SelectedItem.ToString() == "Stingers")
            {
                txt_price.Text = "4";
            }
            else if (cmb_items.SelectedItem.ToString() == "Chocopie")
            {
                txt_price.Text = "3";
            }
            else if (cmb_items.SelectedItem.ToString() == "Car")
            {
                txt_price.Text = "40";
            }
            else if (cmb_items.SelectedItem.ToString() == "Doll")
            {
                txt_price.Text = "15";
            }
            else if (cmb_items.SelectedItem.ToString() == "Bike")
            {
                txt_price.Text = "13";
            }
            else if (cmb_items.SelectedItem.ToString() == "loader")
            {
                txt_price.Text = "10";
            }
           else
            {
                txt_price.Text = "0";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
    }
}
