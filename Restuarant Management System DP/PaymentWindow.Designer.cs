
namespace Restuarant_Management_System_DP
{
    partial class PaymentWindow
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
            System.Windows.Forms.Button paypal_btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.credit_card = new System.Windows.Forms.Button();
            this.cash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            paypal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // paypal_btn
            // 
            paypal_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            paypal_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paypal_btn.BackgroundImage")));
            paypal_btn.Location = new System.Drawing.Point(216, 133);
            paypal_btn.Name = "paypal_btn";
            paypal_btn.Size = new System.Drawing.Size(178, 109);
            paypal_btn.TabIndex = 1;
            paypal_btn.UseVisualStyleBackColor = true;
            paypal_btn.Click += new System.EventHandler(this.paypal_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment:";
            // 
            // credit_card
            // 
            this.credit_card.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.credit_card.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credit_card.BackgroundImage")));
            this.credit_card.Location = new System.Drawing.Point(423, 133);
            this.credit_card.Name = "credit_card";
            this.credit_card.Size = new System.Drawing.Size(178, 109);
            this.credit_card.TabIndex = 2;
            this.credit_card.UseVisualStyleBackColor = true;
            this.credit_card.Click += new System.EventHandler(this.button1_Click);
            // 
            // cash
            // 
            this.cash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cash.BackgroundImage")));
            this.cash.Location = new System.Drawing.Point(631, 133);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(178, 109);
            this.cash.TabIndex = 3;
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Pay Method:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "PayPal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Credit/Debit card";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cash On Delivery";
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 326);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cash);
            this.Controls.Add(this.credit_card);
            this.Controls.Add(paypal_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentWindow";
            this.Text = "PaymentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button credit_card;
    }
}