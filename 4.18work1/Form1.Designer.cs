
namespace _4._18work1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.txtDisp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(227, 175);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(112, 34);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(388, 175);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(112, 34);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "ASUS",
            "Apple"});
            this.cmbItems.Location = new System.Drawing.Point(103, 103);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(584, 33);
            this.cmbItems.TabIndex = 2;
            this.cmbItems.Text = "Select the OS system that you want to turn on or turn off the power:";
            // 
            // txtDisp
            // 
            this.txtDisp.Enabled = false;
            this.txtDisp.Location = new System.Drawing.Point(116, 262);
            this.txtDisp.Multiline = true;
            this.txtDisp.Name = "txtDisp";
            this.txtDisp.Size = new System.Drawing.Size(545, 67);
            this.txtDisp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisp);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.TextBox txtDisp;
    }
}

