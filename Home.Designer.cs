namespace Celebrations
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.opener = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Compact Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите праздник";
            // 
            // opener
            // 
            this.opener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.opener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opener.FlatAppearance.BorderSize = 0;
            this.opener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opener.Font = new System.Drawing.Font("SF Compact Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opener.ForeColor = System.Drawing.Color.White;
            this.opener.Location = new System.Drawing.Point(155, 243);
            this.opener.Name = "opener";
            this.opener.Size = new System.Drawing.Size(195, 30);
            this.opener.TabIndex = 2;
            this.opener.Text = "узнать, сколько осталось";
            this.opener.UseVisualStyleBackColor = false;
            this.opener.Click += new System.EventHandler(this.opener_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "День программиста",
            "Междунарожный день без интернета",
            "День тестировщика",
            "День рождения интернета"});
            this.comboBox1.Location = new System.Drawing.Point(64, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(362, 285);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.opener);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opener;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

