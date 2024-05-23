
namespace Restuarant_Management_System_DP
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Cheese_pizza = new System.Windows.Forms.Button();
            this.Supreme_pizza = new System.Windows.Forms.Button();
            this.Chickentikka_pizza = new System.Windows.Forms.Button();
            this.Pepperoni_pizza = new System.Windows.Forms.Button();
            this.Beefcheese_pizza = new System.Windows.Forms.Button();
            this.ChickenSupreme_pizza = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cheese_pizza
            // 
            this.Cheese_pizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cheese_pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cheese_pizza.BackgroundImage")));
            this.Cheese_pizza.Location = new System.Drawing.Point(80, 97);
            this.Cheese_pizza.Name = "Cheese_pizza";
            this.Cheese_pizza.Size = new System.Drawing.Size(225, 143);
            this.Cheese_pizza.TabIndex = 0;
            this.Cheese_pizza.UseVisualStyleBackColor = true;
            this.Cheese_pizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // Supreme_pizza
            // 
            this.Supreme_pizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Supreme_pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Supreme_pizza.BackgroundImage")));
            this.Supreme_pizza.Location = new System.Drawing.Point(406, 97);
            this.Supreme_pizza.Name = "Supreme_pizza";
            this.Supreme_pizza.Size = new System.Drawing.Size(221, 143);
            this.Supreme_pizza.TabIndex = 1;
            this.Supreme_pizza.UseVisualStyleBackColor = true;
            // 
            // Chickentikka_pizza
            // 
            this.Chickentikka_pizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Chickentikka_pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chickentikka_pizza.BackgroundImage")));
            this.Chickentikka_pizza.Location = new System.Drawing.Point(711, 97);
            this.Chickentikka_pizza.Name = "Chickentikka_pizza";
            this.Chickentikka_pizza.Size = new System.Drawing.Size(212, 143);
            this.Chickentikka_pizza.TabIndex = 2;
            this.Chickentikka_pizza.UseVisualStyleBackColor = true;
            // 
            // Pepperoni_pizza
            // 
            this.Pepperoni_pizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pepperoni_pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pepperoni_pizza.BackgroundImage")));
            this.Pepperoni_pizza.Location = new System.Drawing.Point(86, 323);
            this.Pepperoni_pizza.Name = "Pepperoni_pizza";
            this.Pepperoni_pizza.Size = new System.Drawing.Size(219, 145);
            this.Pepperoni_pizza.TabIndex = 3;
            this.Pepperoni_pizza.UseVisualStyleBackColor = true;
            // 
            // Beefcheese_pizza
            // 
            this.Beefcheese_pizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Beefcheese_pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Beefcheese_pizza.BackgroundImage")));
            this.Beefcheese_pizza.Location = new System.Drawing.Point(404, 325);
            this.Beefcheese_pizza.Name = "Beefcheese_pizza";
            this.Beefcheese_pizza.Size = new System.Drawing.Size(223, 143);
            this.Beefcheese_pizza.TabIndex = 4;
            this.Beefcheese_pizza.UseVisualStyleBackColor = true;
            // 
            // ChickenSupreme_pizza
            // 
            this.ChickenSupreme_pizza.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChickenSupreme_pizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChickenSupreme_pizza.BackgroundImage")));
            this.ChickenSupreme_pizza.Location = new System.Drawing.Point(705, 328);
            this.ChickenSupreme_pizza.Name = "ChickenSupreme_pizza";
            this.ChickenSupreme_pizza.Size = new System.Drawing.Size(218, 140);
            this.ChickenSupreme_pizza.TabIndex = 5;
            this.ChickenSupreme_pizza.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(326, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 73);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "--Menu--";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(975, 552);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChickenSupreme_pizza);
            this.Controls.Add(this.Beefcheese_pizza);
            this.Controls.Add(this.Pepperoni_pizza);
            this.Controls.Add(this.Chickentikka_pizza);
            this.Controls.Add(this.Supreme_pizza);
            this.Controls.Add(this.Cheese_pizza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cheese_pizza;
        private System.Windows.Forms.Button Supreme_pizza;
        private System.Windows.Forms.Button Chickentikka_pizza;
        private System.Windows.Forms.Button Pepperoni_pizza;
        private System.Windows.Forms.Button Beefcheese_pizza;
        private System.Windows.Forms.Button ChickenSupreme_pizza;
        private System.Windows.Forms.TextBox textBox1;
    }
}