namespace Celebrations
{
    partial class Info
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
            this.components = new System.ComponentModel.Container();
            this.datewilllable = new System.Windows.Forms.Label();
            this.datelost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datewill = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // datewilllable
            // 
            this.datewilllable.AutoSize = true;
            this.datewilllable.Font = new System.Drawing.Font("SF Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datewilllable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datewilllable.Location = new System.Drawing.Point(30, 23);
            this.datewilllable.Name = "datewilllable";
            this.datewilllable.Size = new System.Drawing.Size(68, 25);
            this.datewilllable.TabIndex = 1;
            this.datewilllable.Text = "Дата";
            // 
            // datelost
            // 
            this.datelost.AutoSize = true;
            this.datelost.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datelost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelost.Location = new System.Drawing.Point(125, 156);
            this.datelost.Name = "datelost";
            this.datelost.Size = new System.Drawing.Size(53, 19);
            this.datelost.TabIndex = 3;
            this.datelost.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Осталось: ";
            // 
            // datewill
            // 
            this.datewill.AutoSize = true;
            this.datewill.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datewill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datewill.Location = new System.Drawing.Point(31, 59);
            this.datewill.Name = "datewill";
            this.datewill.Size = new System.Drawing.Size(53, 19);
            this.datewill.TabIndex = 4;
            this.datewill.Text = "Дата";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(558, 217);
            this.Controls.Add(this.datewill);
            this.Controls.Add(this.datelost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datewilllable);
            this.Name = "Info";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label datewilllable;
        private System.Windows.Forms.Label datelost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label datewill;
        private System.Windows.Forms.Timer timer1;
    }
}