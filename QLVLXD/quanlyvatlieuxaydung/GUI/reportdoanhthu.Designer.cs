
namespace GUI
{
    partial class reportdoanhthu
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
            this.rpdoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpdoanhthu
            // 
            this.rpdoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpdoanhthu.Location = new System.Drawing.Point(0, 0);
            this.rpdoanhthu.Name = "rpdoanhthu";
            this.rpdoanhthu.ServerReport.BearerToken = null;
            this.rpdoanhthu.Size = new System.Drawing.Size(800, 450);
            this.rpdoanhthu.TabIndex = 0;
            // 
            // reportdoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpdoanhthu);
            this.Name = "reportdoanhthu";
            this.Text = "reportdoanhthu";
            this.Load += new System.EventHandler(this.reportdoanhthu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpdoanhthu;
    }
}