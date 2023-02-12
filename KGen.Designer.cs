
namespace ECCryptoSystem
{
    partial class KeysGen
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sz = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.file2 = new System.Windows.Forms.Button();
            this.File1 = new System.Windows.Forms.Button();
            this.private_key = new System.Windows.Forms.TextBox();
            this.open_key = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sz);
            this.groupBox3.Controls.Add(this.l1);
            this.groupBox3.Controls.Add(this.Save);
            this.groupBox3.Location = new System.Drawing.Point(25, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 107);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сохранение ключей";
            // 
            // sz
            // 
            this.sz.Enabled = false;
            this.sz.Location = new System.Drawing.Point(59, 35);
            this.sz.Name = "sz";
            this.sz.Size = new System.Drawing.Size(214, 30);
            this.sz.TabIndex = 2;
            this.sz.Text = "Выбрать длину ключей";
            this.sz.UseVisualStyleBackColor = true;
            this.sz.Click += new System.EventHandler(this.sz_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(686, 35);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 20);
            this.l1.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Enabled = false;
            this.Save.Location = new System.Drawing.Point(370, 35);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(224, 30);
            this.Save.TabIndex = 0;
            this.Save.Text = "Генерировать и сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.file2);
            this.groupBox1.Controls.Add(this.File1);
            this.groupBox1.Controls.Add(this.private_key);
            this.groupBox1.Controls.Add(this.open_key);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключи";
            // 
            // file2
            // 
            this.file2.Location = new System.Drawing.Point(614, 98);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(219, 27);
            this.file2.TabIndex = 7;
            this.file2.Text = "Файл закрытого ключа";
            this.file2.UseVisualStyleBackColor = true;
            this.file2.Click += new System.EventHandler(this.file2_Click);
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(614, 33);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(219, 27);
            this.File1.TabIndex = 6;
            this.File1.Text = "Файл открытых ключей";
            this.File1.UseVisualStyleBackColor = true;
            this.File1.Click += new System.EventHandler(this.File1_Click);
            // 
            // private_key
            // 
            this.private_key.Enabled = false;
            this.private_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.private_key.Location = new System.Drawing.Point(49, 98);
            this.private_key.Name = "private_key";
            this.private_key.Size = new System.Drawing.Size(545, 27);
            this.private_key.TabIndex = 2;
            this.private_key.TextChanged += new System.EventHandler(this.private_key_TextChanged);
            // 
            // open_key
            // 
            this.open_key.Enabled = false;
            this.open_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_key.Location = new System.Drawing.Point(49, 33);
            this.open_key.Name = "open_key";
            this.open_key.Size = new System.Drawing.Size(545, 27);
            this.open_key.TabIndex = 0;
            this.open_key.TextChanged += new System.EventHandler(this.open_key_TextChanged);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 364);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form7";
            this.Text = "Генерация ключей";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button file2;
        private System.Windows.Forms.Button File1;
        private System.Windows.Forms.TextBox private_key;
        private System.Windows.Forms.TextBox open_key;
        private System.Windows.Forms.Button sz;
        private System.Windows.Forms.Label l1;
    }
}