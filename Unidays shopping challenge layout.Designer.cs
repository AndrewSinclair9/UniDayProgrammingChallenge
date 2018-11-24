using System;

namespace WindowsFormsApp2
{
    partial class Unidayschallenge
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
            this.AddAtobasket = new System.Windows.Forms.Button();
            this.AmountofA = new System.Windows.Forms.NumericUpDown();
            this.Value = new System.Windows.Forms.TextBox();
            this.AmountofC = new System.Windows.Forms.NumericUpDown();
            this.AddCtobasket = new System.Windows.Forms.Button();
            this.AmountofB = new System.Windows.Forms.NumericUpDown();
            this.AddBtobasket = new System.Windows.Forms.Button();
            this.AmountofE = new System.Windows.Forms.NumericUpDown();
            this.AddEtobasket = new System.Windows.Forms.Button();
            this.AmountofD = new System.Windows.Forms.NumericUpDown();
            this.AddDtobasket = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delivery = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Cart = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofD)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAtobasket
            // 
            this.AddAtobasket.Location = new System.Drawing.Point(317, 145);
            this.AddAtobasket.Name = "AddAtobasket";
            this.AddAtobasket.Size = new System.Drawing.Size(120, 20);
            this.AddAtobasket.TabIndex = 0;
            this.AddAtobasket.Text = "Add To Basket";
            this.AddAtobasket.UseVisualStyleBackColor = true;
            this.AddAtobasket.Click += new System.EventHandler(this.Addatobasket_Click);
            // 
            // AmountofA
            // 
            this.AmountofA.Location = new System.Drawing.Point(191, 145);
            this.AmountofA.Name = "AmountofA";
            this.AmountofA.Size = new System.Drawing.Size(120, 20);
            this.AmountofA.TabIndex = 1;
            this.AmountofA.ValueChanged += new System.EventHandler(this.AmountofA_ValueChanged);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(580, 171);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 2;
            this.Value.Text = "Price: £";
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // AmountofC
            // 
            this.AmountofC.Location = new System.Drawing.Point(191, 197);
            this.AmountofC.Name = "AmountofC";
            this.AmountofC.Size = new System.Drawing.Size(120, 20);
            this.AmountofC.TabIndex = 4;
            this.AmountofC.ValueChanged += new System.EventHandler(this.AmountofB_ValueChanged);
            // 
            // AddCtobasket
            // 
            this.AddCtobasket.Location = new System.Drawing.Point(317, 197);
            this.AddCtobasket.Name = "AddCtobasket";
            this.AddCtobasket.Size = new System.Drawing.Size(120, 20);
            this.AddCtobasket.TabIndex = 3;
            this.AddCtobasket.Text = "Add To Basket";
            this.AddCtobasket.UseVisualStyleBackColor = true;
            this.AddCtobasket.Click += new System.EventHandler(this.AddCtobasket_Click);
            // 
            // AmountofB
            // 
            this.AmountofB.Location = new System.Drawing.Point(191, 171);
            this.AmountofB.Name = "AmountofB";
            this.AmountofB.Size = new System.Drawing.Size(120, 20);
            this.AmountofB.TabIndex = 6;
            this.AmountofB.ValueChanged += new System.EventHandler(this.AmountofC_ValueChanged);
            // 
            // AddBtobasket
            // 
            this.AddBtobasket.Location = new System.Drawing.Point(317, 169);
            this.AddBtobasket.Name = "AddBtobasket";
            this.AddBtobasket.Size = new System.Drawing.Size(120, 20);
            this.AddBtobasket.TabIndex = 5;
            this.AddBtobasket.Text = "Add To Basket";
            this.AddBtobasket.UseVisualStyleBackColor = true;
            this.AddBtobasket.Click += new System.EventHandler(this.AddBtobasket_Click);
            // 
            // AmountofE
            // 
            this.AmountofE.Location = new System.Drawing.Point(191, 249);
            this.AmountofE.Name = "AmountofE";
            this.AmountofE.Size = new System.Drawing.Size(120, 20);
            this.AmountofE.TabIndex = 8;
            this.AmountofE.ValueChanged += new System.EventHandler(this.AmountofD_ValueChanged);
            // 
            // AddEtobasket
            // 
            this.AddEtobasket.Location = new System.Drawing.Point(317, 249);
            this.AddEtobasket.Name = "AddEtobasket";
            this.AddEtobasket.Size = new System.Drawing.Size(120, 20);
            this.AddEtobasket.TabIndex = 7;
            this.AddEtobasket.Text = "Add To Basket";
            this.AddEtobasket.UseVisualStyleBackColor = true;
            this.AddEtobasket.Click += new System.EventHandler(this.AddEtobasket_Click);
            // 
            // AmountofD
            // 
            this.AmountofD.Location = new System.Drawing.Point(191, 223);
            this.AmountofD.Name = "AmountofD";
            this.AmountofD.Size = new System.Drawing.Size(120, 20);
            this.AmountofD.TabIndex = 10;
            this.AmountofD.ValueChanged += new System.EventHandler(this.AmountofE_ValueChanged);
            // 
            // AddDtobasket
            // 
            this.AddDtobasket.Location = new System.Drawing.Point(317, 223);
            this.AddDtobasket.Name = "AddDtobasket";
            this.AddDtobasket.Size = new System.Drawing.Size(120, 20);
            this.AddDtobasket.TabIndex = 9;
            this.AddDtobasket.Text = "Add To Basket";
            this.AddDtobasket.UseVisualStyleBackColor = true;
            this.AddDtobasket.Click += new System.EventHandler(this.AddDtobasket_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(259, 275);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(115, 23);
            this.Checkout.TabIndex = 11;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(631, 121);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear Basket";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delivery
            // 
            this.Delivery.Location = new System.Drawing.Point(580, 198);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(100, 20);
            this.Delivery.TabIndex = 13;
            this.Delivery.Text = "Delivery Fee: Free";
            this.Delivery.TextChanged += new System.EventHandler(this.Delivery_TextChanged);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(580, 224);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 14;
            this.Total.Text = "Total: £";
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(457, 35);
            this.Cart.Multiline = true;
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(249, 80);
            this.Cart.TabIndex = 15;
            this.Cart.Text = "My Order:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(158, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 13);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "A =";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(158, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(27, 13);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "C =";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(158, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(27, 13);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "B =";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.Location = new System.Drawing.Point(158, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(27, 13);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "E =";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox5.Location = new System.Drawing.Point(158, 225);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(27, 13);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "D =";
            // 
            // Unidayschallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Delivery);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.AmountofD);
            this.Controls.Add(this.AddDtobasket);
            this.Controls.Add(this.AmountofE);
            this.Controls.Add(this.AddEtobasket);
            this.Controls.Add(this.AmountofB);
            this.Controls.Add(this.AddBtobasket);
            this.Controls.Add(this.AmountofC);
            this.Controls.Add(this.AddCtobasket);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.AmountofA);
            this.Controls.Add(this.AddAtobasket);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Unidayschallenge";
            this.Text = "Unidays Shopping";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmountofA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountofD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        #endregion

        private System.Windows.Forms.Button AddAtobasket;
        private System.Windows.Forms.NumericUpDown AmountofA;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.NumericUpDown AmountofC;
        private System.Windows.Forms.Button AddCtobasket;
        private System.Windows.Forms.NumericUpDown AmountofB;
        private System.Windows.Forms.Button AddBtobasket;
        private System.Windows.Forms.NumericUpDown AmountofE;
        private System.Windows.Forms.Button AddEtobasket;
        private System.Windows.Forms.NumericUpDown AmountofD;
        private System.Windows.Forms.Button AddDtobasket;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Delivery;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox Cart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

