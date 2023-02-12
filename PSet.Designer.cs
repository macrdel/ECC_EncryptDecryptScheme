
namespace ECCryptoSystem
{
    partial class PassSet
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
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OK1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(29, 33);
            this.first.Name = "first";
            this.first.PasswordChar = '*';
            this.first.Size = new System.Drawing.Size(242, 22);
            this.first.TabIndex = 0;
            this.first.TextChanged += new System.EventHandler(this.first_TextChanged);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(29, 88);
            this.second.Name = "second";
            this.second.PasswordChar = '*';
            this.second.Size = new System.Drawing.Size(242, 22);
            this.second.TabIndex = 1;
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "увидеть";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OK1
            // 
            this.OK1.Enabled = false;
            this.OK1.Location = new System.Drawing.Point(107, 180);
            this.OK1.Name = "OK1";
            this.OK1.Size = new System.Drawing.Size(92, 34);
            this.OK1.TabIndex = 3;
            this.OK1.Text = "Сохранить";
            this.OK1.UseVisualStyleBackColor = true;
            this.OK1.Click += new System.EventHandler(this.OK1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 226);
            this.Controls.Add(this.OK1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Name = "Form3";
            this.Text = "Задать пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button OK1;
    }
}