namespace Dersane1
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
            this.PasstextBox1 = new System.Windows.Forms.TextBox();
            this.IDtextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Giris_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasstextBox1
            // 
            this.PasstextBox1.Location = new System.Drawing.Point(93, 91);
            this.PasstextBox1.Multiline = true;
            this.PasstextBox1.Name = "PasstextBox1";
            this.PasstextBox1.Size = new System.Drawing.Size(120, 20);
            this.PasstextBox1.TabIndex = 1;
            this.PasstextBox1.TextChanged += new System.EventHandler(this.PasstextBox1_TextChanged);
            // 
            // IDtextBox2
            // 
            this.IDtextBox2.Location = new System.Drawing.Point(93, 49);
            this.IDtextBox2.Multiline = true;
            this.IDtextBox2.Name = "IDtextBox2";
            this.IDtextBox2.Size = new System.Drawing.Size(120, 20);
            this.IDtextBox2.TabIndex = 2;
            this.IDtextBox2.TextChanged += new System.EventHandler(this.IDtextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // Giris_button
            // 
            this.Giris_button.Location = new System.Drawing.Point(116, 117);
            this.Giris_button.Name = "Giris_button";
            this.Giris_button.Size = new System.Drawing.Size(75, 23);
            this.Giris_button.TabIndex = 5;
            this.Giris_button.Text = "Giriş";
            this.Giris_button.UseVisualStyleBackColor = true;
            this.Giris_button.Click += new System.EventHandler(this.Giris_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Giris_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtextBox2);
            this.Controls.Add(this.PasstextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasstextBox1;
        private System.Windows.Forms.TextBox IDtextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Giris_button;


    }
}

