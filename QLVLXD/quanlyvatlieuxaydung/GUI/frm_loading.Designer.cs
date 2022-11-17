
namespace GUI
{
    partial class frm_loading
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbphantram = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loading.......";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbphantram
            // 
            this.lbphantram.AutoSize = true;
            this.lbphantram.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphantram.Location = new System.Drawing.Point(167, 173);
            this.lbphantram.Name = "lbphantram";
            this.lbphantram.Size = new System.Drawing.Size(49, 22);
            this.lbphantram.TabIndex = 2;
            this.lbphantram.Text = "label";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 153);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 17);
            this.progressBar1.TabIndex = 3;
            // 
            // frm_loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(404, 266);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbphantram);
            this.Controls.Add(this.label1);
            this.Name = "frm_loading";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_loading";
            this.Load += new System.EventHandler(this.frm_loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbphantram;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}