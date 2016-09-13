namespace LAB_08_Calc_Reservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtADate = new System.Windows.Forms.TextBox();
            this.txtDDate = new System.Windows.Forms.TextBox();
            this.txtNumNights = new System.Windows.Forms.TextBox();
            this.txtPricePerNight = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrival date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price per night:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of nights";
            // 
            // txtADate
            // 
            this.txtADate.Location = new System.Drawing.Point(153, 29);
            this.txtADate.Name = "txtADate";
            this.txtADate.Size = new System.Drawing.Size(100, 20);
            this.txtADate.TabIndex = 5;
            // 
            // txtDDate
            // 
            this.txtDDate.Location = new System.Drawing.Point(153, 69);
            this.txtDDate.Name = "txtDDate";
            this.txtDDate.Size = new System.Drawing.Size(100, 20);
            this.txtDDate.TabIndex = 6;
            // 
            // txtNumNights
            // 
            this.txtNumNights.Location = new System.Drawing.Point(153, 110);
            this.txtNumNights.Name = "txtNumNights";
            this.txtNumNights.Size = new System.Drawing.Size(100, 20);
            this.txtNumNights.TabIndex = 7;
            // 
            // txtPricePerNight
            // 
            this.txtPricePerNight.Enabled = false;
            this.txtPricePerNight.Location = new System.Drawing.Point(153, 147);
            this.txtPricePerNight.Name = "txtPricePerNight";
            this.txtPricePerNight.Size = new System.Drawing.Size(100, 20);
            this.txtPricePerNight.TabIndex = 8;
            this.txtPricePerNight.Text = "$115.00";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(153, 189);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPricePerNight);
            this.Controls.Add(this.txtNumNights);
            this.Controls.Add(this.txtDDate);
            this.Controls.Add(this.txtADate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Reservation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtADate;
        private System.Windows.Forms.TextBox txtDDate;
        private System.Windows.Forms.TextBox txtNumNights;
        private System.Windows.Forms.TextBox txtPricePerNight;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

