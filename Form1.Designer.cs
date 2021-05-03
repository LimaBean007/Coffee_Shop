
namespace Coffee_Shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblDonuts = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCoffee = new System.Windows.Forms.TextBox();
            this.txbDonuts = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(165, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Pleas enter your name";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(10, 64);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(250, 21);
            this.lblCoffee.TabIndex = 1;
            this.lblCoffee.Text = "How many coffees would you like?";
            // 
            // lblDonuts
            // 
            this.lblDonuts.AutoSize = true;
            this.lblDonuts.Location = new System.Drawing.Point(10, 107);
            this.lblDonuts.Name = "lblDonuts";
            this.lblDonuts.Size = new System.Drawing.Size(249, 21);
            this.lblDonuts.TabIndex = 2;
            this.lblDonuts.Text = "How many donuts would you like?";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(310, 23);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(173, 29);
            this.txbName.TabIndex = 3;
            // 
            // txbCoffee
            // 
            this.txbCoffee.Location = new System.Drawing.Point(310, 64);
            this.txbCoffee.Name = "txbCoffee";
            this.txbCoffee.Size = new System.Drawing.Size(173, 29);
            this.txbCoffee.TabIndex = 4;
            // 
            // txbDonuts
            // 
            this.txbDonuts.Location = new System.Drawing.Point(310, 107);
            this.txbDonuts.Name = "txbDonuts";
            this.txbDonuts.Size = new System.Drawing.Size(173, 29);
            this.txbDonuts.TabIndex = 5;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(10, 193);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(109, 34);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 264);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txbDonuts);
            this.Controls.Add(this.txbCoffee);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblDonuts);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblDonuts;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCoffee;
        private System.Windows.Forms.TextBox txbDonuts;
        private System.Windows.Forms.Button btnOrder;
    }
}

