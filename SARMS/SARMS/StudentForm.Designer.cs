namespace SARMS
{
    partial class StudentForm
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
            this.txtlogin = new System.Windows.Forms.Label();
            this.lstunits = new System.Windows.Forms.ListBox();
            this.txtAttendance = new System.Windows.Forms.Label();
            this.txtAssignments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlogin.Location = new System.Drawing.Point(170, 4);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(110, 23);
            this.txtlogin.TabIndex = 0;
            this.txtlogin.Text = "label1";
            this.txtlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstunits
            // 
            this.lstunits.FormattingEnabled = true;
            this.lstunits.Location = new System.Drawing.Point(12, 12);
            this.lstunits.Name = "lstunits";
            this.lstunits.Size = new System.Drawing.Size(87, 95);
            this.lstunits.TabIndex = 1;
            this.lstunits.SelectedIndexChanged += new System.EventHandler(this.lstunits_SelectedIndexChanged);
            // 
            // txtAttendance
            // 
            this.txtAttendance.AutoSize = true;
            this.txtAttendance.Location = new System.Drawing.Point(118, 13);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(35, 13);
            this.txtAttendance.TabIndex = 2;
            this.txtAttendance.Text = "label1";
            // 
            // txtAssignments
            // 
            this.txtAssignments.AutoSize = true;
            this.txtAssignments.Location = new System.Drawing.Point(121, 47);
            this.txtAssignments.Name = "txtAssignments";
            this.txtAssignments.Size = new System.Drawing.Size(35, 13);
            this.txtAssignments.TabIndex = 3;
            this.txtAssignments.Text = "label1";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAssignments);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.lstunits);
            this.Controls.Add(this.txtlogin);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtlogin;
        private System.Windows.Forms.ListBox lstunits;
        private System.Windows.Forms.Label txtAttendance;
        private System.Windows.Forms.Label txtAssignments;
    }
}