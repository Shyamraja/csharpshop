using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
    
    
    }
}
