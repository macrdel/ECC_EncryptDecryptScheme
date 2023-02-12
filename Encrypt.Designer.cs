
namespace ECCryptoSystem
{
    partial class Encryption
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
            this.File1 = new System.Windows.Forms.Button();
            this.open_key = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.l2 = new System.Windows.Forms.Label();
            this.shifr = new System.Windows.Forms.TextBox();
            this.Crypt = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.File1);
            this.groupBox1.Controls.Add(this.open_key);
            this.groupBox1.Location = new System.Drawing.Point(31, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Файл открытых ключей";
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(614, 33);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(281, 27);
            this.File1.TabIndex = 6;
            this.File1.Text = "Файл открытых ключей";
            this.File1.UseVisualStyleBackColor = true;
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // open_key
            // 
            this.open_key.Enabled = false;
            this.open_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_key.Location = new System.Drawing.Point(27, 33);
            this.open_key.Name = "open_key";
            this.open_key.Size = new System.Drawing.Size(567, 27);
            this.open_key.TabIndex = 0;
            this.open_key.TextChanged += new System.EventHandler(this.open_key_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msg);
            this.groupBox2.Location = new System.Drawing.Point(33, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сообщение";
            // 
            // msg
            // 
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.msg.Location = new System.Drawing.Point(25, 34);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(868, 27);
            this.msg.TabIndex = 0;
            this.msg.Text = "Сообщение";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.l2);
            this.groupBox4.Controls.Add(this.shifr);
            this.groupBox4.Controls.Add(this.Crypt);
            this.groupBox4.Location = new System.Drawing.Point(31, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(926, 128);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Шифрование";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(23, 86);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(0, 20);
            this.l2.TabIndex = 3;
            // 
            // shifr
            // 
            this.shifr.Enabled = false;
            this.shifr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shifr.Location = new System.Drawing.Point(27, 39);
            this.shifr.Name = "shifr";
            this.shifr.Size = new System.Drawing.Size(567, 27);
            this.shifr.TabIndex = 2;
            // 
            // Crypt
            // 
            this.Crypt.Enabled = false;
            this.Crypt.Location = new System.Drawing.Point(614, 52);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(279, 30);
            this.Crypt.TabIndex = 1;
            this.Crypt.Text = "Шифровать и сохранить шифротекст";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 394);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Шифрование";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button File1;
        private System.Windows.Forms.TextBox open_key;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox shifr;
        private System.Windows.Forms.Label l2;
    }
}