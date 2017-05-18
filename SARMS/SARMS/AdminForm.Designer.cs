namespace SARMS
{
    partial class AdminForm
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
            this.lststudents = new System.Windows.Forms.ListBox();
            this.lstunits = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lststudents
            // 
            this.lststudents.FormattingEnabled = true;
            this.lststudents.Location = new System.Drawing.Point(13, 13);
            this.lststudents.Name = "lststudents";
            this.lststudents.Size = new System.Drawing.Size(120, 95);
            this.lststudents.TabIndex = 0;
            this.lststudents.SelectedIndexChanged += new System.EventHandler(this.lststudents_SelectedIndexChanged);
            // 
            // lstunits
            // 
            this.lstunits.FormattingEnabled = true;
            this.lstunits.Location = new System.Drawing.Point(140, 13);
            this.lstunits.Name = "lstunits";
            this.lstunits.Size = new System.Drawing.Size(120, 95);
            this.lstunits.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enrol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstunits);
            this.Controls.Add(this.lststudents);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lststudents;
        private System.Windows.Forms.ListBox lstunits;
        private System.Windows.Forms.Button button1;
    }
}