﻿using System;
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
              txt_total.Text = "";
              txt_qty.Text = "";
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        
         private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);
       //Add different items ,quantity and  their total price in list
         txt_subtotal.Text = (Convert.ToInt16(txt_subtotal.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        //calculates subtotal of items price after adding total price for every different items
        }

         private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_subtotal.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if(txt_paid.Text.Length > 0)
            {
                 txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }
        
        //Function added fro removing items from list 
        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                for (int i= 0; i< listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_subtotal.Text = (Convert.ToInt16(txt_subtotal.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }
        
        
    }
}
