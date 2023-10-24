namespace sınav_ornek
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
            this.btnSeç = new System.Windows.Forms.Button();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbÇift = new System.Windows.Forms.RadioButton();
            this.lstSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSeç
            // 
            this.btnSeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeç.Location = new System.Drawing.Point(48, 126);
            this.btnSeç.Name = "btnSeç";
            this.btnSeç.Size = new System.Drawing.Size(75, 29);
            this.btnSeç.TabIndex = 0;
            this.btnSeç.Text = "Seç";
            this.btnSeç.UseVisualStyleBackColor = true;
            this.btnSeç.Click += new System.EventHandler(this.btnSeç_Click);
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTek.Location = new System.Drawing.Point(164, 126);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(56, 24);
            this.rbTek.TabIndex = 1;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek";
            this.rbTek.UseVisualStyleBackColor = true;
            // 
            // rbÇift
            // 
            this.rbÇift.AutoSize = true;
            this.rbÇift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbÇift.Location = new System.Drawing.Point(164, 149);
            this.rbÇift.Name = "rbÇift";
            this.rbÇift.Size = new System.Drawing.Size(55, 24);
            this.rbÇift.TabIndex = 2;
            this.rbÇift.TabStop = true;
            this.rbÇift.Text = "Çift";
            this.rbÇift.UseVisualStyleBackColor = true;
            // 
            // lstSayilar
            // 
            this.lstSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSayilar.FormattingEnabled = true;
            this.lstSayilar.ItemHeight = 20;
            this.lstSayilar.Location = new System.Drawing.Point(242, 126);
            this.lstSayilar.Name = "lstSayilar";
            this.lstSayilar.Size = new System.Drawing.Size(120, 184);
            this.lstSayilar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSayilar);
            this.Controls.Add(this.rbÇift);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.btnSeç);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeç;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbÇift;
        private System.Windows.Forms.ListBox lstSayilar;
    }
}

