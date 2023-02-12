
namespace ECCryptoSystem
{
    partial class PassEnterAndCheck
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
            this.passW = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.OK2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passW
            // 
            this.passW.Location = new System.Drawing.Point(25, 35);
            this.passW.Name = "passW";
            this.passW.PasswordChar = '*';
            this.passW.Size = new System.Drawing.Size(271, 22);
            this.passW.TabIndex = 0;
            this.passW.TextChanged += new System.EventHandler(this.passW_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "увидеть";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // OK2
            // 
            this.OK2.Enabled = false;
            this.OK2.Location = new System.Drawing.Point(121, 125);
            this.OK2.Name = "OK2";
            this.OK2.Size = new System.Drawing.Size(75, 23);
            this.OK2.TabIndex = 2;
            this.OK2.Text = "ОК";
            this.OK2.UseVisualStyleBackColor = true;
            this.OK2.Click += new System.EventHandler(this.OK2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 172);
            this.Controls.Add(this.OK2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passW);
            this.Name = "Form4";
            this.Text = "Ввести пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passW;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button OK2;
    }
}