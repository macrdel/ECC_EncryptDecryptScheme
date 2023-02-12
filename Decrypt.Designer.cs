
namespace ECCryptoSystem
{
    partial class Decryption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.file1 = new System.Windows.Forms.Button();
            this.shifr1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.file2 = new System.Windows.Forms.Button();
            this.pr_key = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.msg1 = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.file1);
            this.groupBox1.Controls.Add(this.shifr1);
            this.groupBox1.Location = new System.Drawing.Point(25, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл с шифротекстом";
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(630, 42);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(244, 27);
            this.file1.TabIndex = 1;
            this.file1.Text = "Открыть файл с шифротекстом";
            this.file1.UseVisualStyleBackColor = true;
            this.file1.Click += new System.EventHandler(this.file1_Click);
            // 
            // shifr1
            // 
            this.shifr1.Enabled = false;
            this.shifr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifr1.Location = new System.Drawing.Point(70, 42);
            this.shifr1.Name = "shifr1";
            this.shifr1.Size = new System.Drawing.Size(528, 27);
            this.shifr1.TabIndex = 0;
            this.shifr1.TextChanged += new System.EventHandler(this.shifr1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.file2);
            this.groupBox2.Controls.Add(this.pr_key);
            this.groupBox2.Location = new System.Drawing.Point(25, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Файл закрытого ключа";
            // 
            // file2
            // 
            this.file2.Location = new System.Drawing.Point(630, 48);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(244, 27);
            this.file2.TabIndex = 1;
            this.file2.Text = "Открыть файл закрытого ключа";
            this.file2.UseVisualStyleBackColor = true;
            this.file2.Click += new System.EventHandler(this.file2_Click);
            // 
            // pr_key
            // 
            this.pr_key.Enabled = false;
            this.pr_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pr_key.Location = new System.Drawing.Point(70, 48);
            this.pr_key.Name = "pr_key";
            this.pr_key.Size = new System.Drawing.Size(528, 27);
            this.pr_key.TabIndex = 0;
            this.pr_key.TextChanged += new System.EventHandler(this.pr_key_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msg1);
            this.groupBox3.Controls.Add(this.decrypt);
            this.groupBox3.Location = new System.Drawing.Point(25, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(912, 99);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Расшифрованное сообщение";
            // 
            // msg1
            // 
            this.msg1.Enabled = false;
            this.msg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg1.Location = new System.Drawing.Point(47, 44);
            this.msg1.Name = "msg1";
            this.msg1.Size = new System.Drawing.Size(646, 27);
            this.msg1.TabIndex = 1;
            // 
            // decrypt
            // 
            this.decrypt.Enabled = false;
            this.decrypt.Location = new System.Drawing.Point(742, 43);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(134, 28);
            this.decrypt.TabIndex = 0;
            this.decrypt.Text = "Расшифровать";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Расшифрование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button file1;
        private System.Windows.Forms.TextBox shifr1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button file2;
        private System.Windows.Forms.TextBox pr_key;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox msg1;
    }
}