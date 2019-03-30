namespace CurrencyConverterOOP
{
    partial class frmEuro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEuro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEuroFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEuroTo = new System.Windows.Forms.TextBox();
            this.lstEuroFrom = new System.Windows.Forms.ListBox();
            this.closeEuroBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.convEuroBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.euroStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Euro amount:";
            // 
            // txtEuroFrom
            // 
            this.txtEuroFrom.Location = new System.Drawing.Point(16, 52);
            this.txtEuroFrom.Name = "txtEuroFrom";
            this.txtEuroFrom.Size = new System.Drawing.Size(100, 20);
            this.txtEuroFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(122, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "g";
            this.label2.UseMnemonic = false;
            // 
            // txtEuroTo
            // 
            this.txtEuroTo.Location = new System.Drawing.Point(16, 115);
            this.txtEuroTo.Name = "txtEuroTo";
            this.txtEuroTo.Size = new System.Drawing.Size(100, 20);
            this.txtEuroTo.TabIndex = 3;
            // 
            // lstEuroFrom
            // 
            this.lstEuroFrom.FormattingEnabled = true;
            this.lstEuroFrom.Items.AddRange(new object[] {
            "Dollar",
            "Pound Sterling",
            "Yen"});
            this.lstEuroFrom.Location = new System.Drawing.Point(160, 46);
            this.lstEuroFrom.Name = "lstEuroFrom";
            this.lstEuroFrom.Size = new System.Drawing.Size(120, 95);
            this.lstEuroFrom.TabIndex = 4;
            this.lstEuroFrom.SelectedIndexChanged += new System.EventHandler(this.lstEuroFrom_SelectedIndexChanged);
            // 
            // closeEuroBtn
            // 
            this.closeEuroBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeEuroBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeEuroBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeEuroBtn.Location = new System.Drawing.Point(217, 148);
            this.closeEuroBtn.Name = "closeEuroBtn";
            this.closeEuroBtn.Size = new System.Drawing.Size(75, 23);
            this.closeEuroBtn.TabIndex = 5;
            this.closeEuroBtn.Text = "Close";
            this.closeEuroBtn.UseVisualStyleBackColor = false;
            this.closeEuroBtn.Click += new System.EventHandler(this.closeEuroBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(123, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "f";
            // 
            // convEuroBtn
            // 
            this.convEuroBtn.BackColor = System.Drawing.SystemColors.Info;
            this.convEuroBtn.Location = new System.Drawing.Point(27, 82);
            this.convEuroBtn.Name = "convEuroBtn";
            this.convEuroBtn.Size = new System.Drawing.Size(75, 23);
            this.convEuroBtn.TabIndex = 7;
            this.convEuroBtn.Text = "Convert";
            this.convEuroBtn.UseVisualStyleBackColor = false;
            this.convEuroBtn.Click += new System.EventHandler(this.convEuroBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(157, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Currency:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euroStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 185);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // euroStatusLabel1
            // 
            this.euroStatusLabel1.Name = "euroStatusLabel1";
            this.euroStatusLabel1.Size = new System.Drawing.Size(252, 17);
            this.euroStatusLabel1.Text = "Select currency, click for current exchange rate";
            this.euroStatusLabel1.Click += new System.EventHandler(this.euroStatusLabel1_Click);
            // 
            // frmEuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 207);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.convEuroBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeEuroBtn);
            this.Controls.Add(this.lstEuroFrom);
            this.Controls.Add(this.txtEuroTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEuroFrom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEuro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert from Euro";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEuroFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEuroTo;
        private System.Windows.Forms.ListBox lstEuroFrom;
        private System.Windows.Forms.Button closeEuroBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convEuroBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel euroStatusLabel1;
    }
}