namespace MiniShop
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
            this.IdetiBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MerchInfo = new System.Windows.Forms.TabControl();
            this.Pavadinimas = new System.Windows.Forms.TextBox();
            this.Svoris = new System.Windows.Forms.TextBox();
            this.Kaina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdetiBtn
            // 
            this.IdetiBtn.Location = new System.Drawing.Point(291, 297);
            this.IdetiBtn.Name = "IdetiBtn";
            this.IdetiBtn.Size = new System.Drawing.Size(100, 25);
            this.IdetiBtn.TabIndex = 0;
            this.IdetiBtn.Text = "Deti i krepseli";
            this.IdetiBtn.UseVisualStyleBackColor = true;
            this.IdetiBtn.Click += new System.EventHandler(this.IdetiBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Krepselis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MerchInfo
            // 
            this.MerchInfo.Location = new System.Drawing.Point(60, 12);
            this.MerchInfo.Name = "MerchInfo";
            this.MerchInfo.SelectedIndex = 0;
            this.MerchInfo.Size = new System.Drawing.Size(331, 241);
            this.MerchInfo.TabIndex = 2;
            this.MerchInfo.SelectedIndexChanged += new System.EventHandler(this.MerchInfo_SelectedIndexChanged);
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.Location = new System.Drawing.Point(78, 259);
            this.Pavadinimas.Name = "Pavadinimas";
            this.Pavadinimas.Size = new System.Drawing.Size(100, 20);
            this.Pavadinimas.TabIndex = 4;
            // 
            // Svoris
            // 
            this.Svoris.Location = new System.Drawing.Point(78, 291);
            this.Svoris.Name = "Svoris";
            this.Svoris.Size = new System.Drawing.Size(100, 20);
            this.Svoris.TabIndex = 5;
            // 
            // Kaina
            // 
            this.Kaina.Location = new System.Drawing.Point(291, 259);
            this.Kaina.Name = "Kaina";
            this.Kaina.Size = new System.Drawing.Size(100, 20);
            this.Kaina.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aprasymas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kaina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kaina);
            this.Controls.Add(this.Svoris);
            this.Controls.Add(this.Pavadinimas);
            this.Controls.Add(this.MerchInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IdetiBtn);
            this.Name = "Form1";
            this.Text = "Prekes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IdetiBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl MerchInfo;
        private System.Windows.Forms.TextBox Pavadinimas;
        private System.Windows.Forms.TextBox Svoris;
        private System.Windows.Forms.TextBox Kaina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

