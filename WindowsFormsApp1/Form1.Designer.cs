namespace Shop_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sweets = new System.Windows.Forms.RadioButton();
            this.toys = new System.Windows.Forms.RadioButton();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.additem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.subtotal = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.Net = new System.Windows.Forms.Label();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.paid = new System.Windows.Forms.Label();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.removeitem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_items
            // 
            this.cmb_items.FormattingEnabled = true;
            this.cmb_items.Location = new System.Drawing.Point(302, 158);
            this.cmb_items.Name = "cmb_items";
            this.cmb_items.Size = new System.Drawing.Size(277, 24);
            this.cmb_items.TabIndex = 1;
            this.cmb_items.SelectedIndexChanged += new System.EventHandler(this.cmb_items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sweets
            // 
            this.sweets.AutoSize = true;
            this.sweets.Location = new System.Drawing.Point(293, 123);
            this.sweets.Name = "sweets";
            this.sweets.Size = new System.Drawing.Size(87, 21);
            this.sweets.TabIndex = 3;
            this.sweets.TabStop = true;
            this.sweets.Text = "SWEETS";
            this.sweets.UseVisualStyleBackColor = true;
            this.sweets.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // toys
            // 
            this.toys.AutoSize = true;
            this.toys.Location = new System.Drawing.Point(439, 123);
            this.toys.Name = "toys";
            this.toys.Size = new System.Drawing.Size(67, 21);
            this.toys.TabIndex = 4;
            this.toys.TabStop = true;
            this.toys.Text = "TOYS\n";
            this.toys.UseVisualStyleBackColor = true;
            this.toys.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(100, 225);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(83, 22);
            this.txt_price.TabIndex = 5;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(108, 205);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(40, 17);
            this.price.TabIndex = 6;
            this.price.Text = "Price";
            this.price.Click += new System.EventHandler(this.label2_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(220, 205);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(30, 17);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Qty";
            this.Quantity.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(199, 225);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(71, 22);
            this.txt_qty.TabIndex = 7;
            this.txt_qty.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(318, 205);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(40, 17);
            this.Total.TabIndex = 10;
            this.Total.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(276, 226);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(89, 22);
            this.txt_total.TabIndex = 9;
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(371, 221);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(91, 32);
            this.additem.TabIndex = 11;
            this.additem.Text = "Add Item\r\n\r\n";
            this.additem.UseVisualStyleBackColor = true;
            this.additem.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(90, 284);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 144);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 65;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(137, 449);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(77, 22);
            this.txt_subtotal.TabIndex = 13;
            this.txt_subtotal.Text = "0";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Location = new System.Drawing.Point(66, 454);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(69, 17);
            this.subtotal.TabIndex = 14;
            this.subtotal.Text = "Sub Total";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(229, 452);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(63, 17);
            this.discount.TabIndex = 16;
            this.discount.Text = "Discount\r\n";
            this.discount.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(302, 447);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(89, 22);
            this.txt_discount.TabIndex = 15;
            this.txt_discount.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Net
            // 
            this.Net.AutoSize = true;
            this.Net.Location = new System.Drawing.Point(470, 454);
            this.Net.Name = "Net";
            this.Net.Size = new System.Drawing.Size(30, 17);
            this.Net.TabIndex = 18;
            this.Net.Text = "Net\r\n";
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(531, 447);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(70, 22);
            this.txt_net.TabIndex = 17;
            // 
            // paid
            // 
            this.paid.AutoSize = true;
            this.paid.Location = new System.Drawing.Point(470, 508);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(36, 17);
            this.paid.TabIndex = 20;
            this.paid.Text = "Paid\r\n";
            this.paid.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_paid
            // 
            this.txt_paid.Location = new System.Drawing.Point(531, 503);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(70, 22);
            this.txt_paid.TabIndex = 19;
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(447, 549);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(59, 17);
            this.balance.TabIndex = 22;
            this.balance.Text = "Balance\r\n";
            // 
            // txt_balance
            // 
            this.txt_balance.Location = new System.Drawing.Point(531, 544);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(70, 22);
            this.txt_balance.TabIndex = 21;
            // 
            // removeitem
            // 
            this.removeitem.Location = new System.Drawing.Point(479, 221);
            this.removeitem.Name = "removeitem";
            this.removeitem.Size = new System.Drawing.Size(100, 32);
            this.removeitem.TabIndex = 23;
            this.removeitem.Text = "Remove Item\r\n";
            this.removeitem.UseVisualStyleBackColor = true;
            this.removeitem.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 600);
            this.Controls.Add(this.removeitem);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.Net);
            this.Controls.Add(this.txt_net);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.price);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.toys);
            this.Controls.Add(this.sweets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_items);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sweets;
        private System.Windows.Forms.RadioButton toys;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label Net;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.Label paid;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button removeitem;
    }
}

