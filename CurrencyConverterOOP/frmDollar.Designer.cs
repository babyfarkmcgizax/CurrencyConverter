namespace CurrencyConverterOOP
{
    partial class frmDollar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDollar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDollarFrom = new System.Windows.Forms.TextBox();
            this.lstDollarFrom = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeDollarBtn = new System.Windows.Forms.Button();
            this.convDollarBtn = new System.Windows.Forms.Button();
            this.txtDollarTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Dollar amount:";
            // 
            // txtDollarFrom
            // 
            this.txtDollarFrom.Location = new System.Drawing.Point(26, 54);
            this.txtDollarFrom.Name = "txtDollarFrom";
            this.txtDollarFrom.Size = new System.Drawing.Size(100, 20);
            this.txtDollarFrom.TabIndex = 1;
            // 
            // lstDollarFrom
            // 
            this.lstDollarFrom.FormattingEnabled = true;
            this.lstDollarFrom.Items.AddRange(new object[] {
            "Euro",
            "Pound Sterling",
            "Yen"});
            this.lstDollarFrom.Location = new System.Drawing.Point(173, 54);
            this.lstDollarFrom.Name = "lstDollarFrom";
            this.lstDollarFrom.Size = new System.Drawing.Size(120, 95);
            this.lstDollarFrom.TabIndex = 2;
            this.lstDollarFrom.SelectedIndexChanged += new System.EventHandler(this.lstDollarFrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Currency";
            // 
            // closeDollarBtn
            // 
            this.closeDollarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeDollarBtn.Location = new System.Drawing.Point(233, 162);
            this.closeDollarBtn.Name = "closeDollarBtn";
            this.closeDollarBtn.Size = new System.Drawing.Size(75, 23);
            this.closeDollarBtn.TabIndex = 4;
            this.closeDollarBtn.Text = "Close";
            this.closeDollarBtn.UseVisualStyleBackColor = false;
            this.closeDollarBtn.Click += new System.EventHandler(this.closeDollarBtn_Click);
            // 
            // convDollarBtn
            // 
            this.convDollarBtn.BackColor = System.Drawing.SystemColors.Info;
            this.convDollarBtn.Location = new System.Drawing.Point(39, 90);
            this.convDollarBtn.Name = "convDollarBtn";
            this.convDollarBtn.Size = new System.Drawing.Size(75, 23);
            this.convDollarBtn.TabIndex = 5;
            this.convDollarBtn.Text = "Convert";
            this.convDollarBtn.UseVisualStyleBackColor = false;
            this.convDollarBtn.Click += new System.EventHandler(this.convDollarBtn_Click);
            // 
            // txtDollarTo
            // 
            this.txtDollarTo.Location = new System.Drawing.Point(26, 129);
            this.txtDollarTo.Name = "txtDollarTo";
            this.txtDollarTo.Size = new System.Drawing.Size(100, 20);
            this.txtDollarTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(135, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wingdings 3", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(135, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "f";
            // 
            // frmDollar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 197);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDollarTo);
            this.Controls.Add(this.convDollarBtn);
            this.Controls.Add(this.closeDollarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDollarFrom);
            this.Controls.Add(this.txtDollarFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDollar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert from Dollars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDollarFrom;
        private System.Windows.Forms.ListBox lstDollarFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeDollarBtn;
        private System.Windows.Forms.Button convDollarBtn;
        private System.Windows.Forms.TextBox txtDollarTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}