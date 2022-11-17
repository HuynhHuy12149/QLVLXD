
namespace GUI
{
    partial class frm_hoadon
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgHoadon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthemnhanvien = new System.Windows.Forms.Button();
            this.btnthemkhachhang = new System.Windows.Forms.Button();
            this.dtngayban = new System.Windows.Forms.DateTimePicker();
            this.cbkhachhang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(529, 399);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(260, 41);
            this.txttimkiem.TabIndex = 71;
            // 
            // dgHoadon
            // 
            this.dgHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoadon.Location = new System.Drawing.Point(381, 43);
            this.dgHoadon.Name = "dgHoadon";
            this.dgHoadon.Size = new System.Drawing.Size(408, 350);
            this.dgHoadon.TabIndex = 62;
            this.dgHoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoadon_CellClick);
            this.dgHoadon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoadon_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(299, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // btnthemnhanvien
            // 
            this.btnthemnhanvien.Location = new System.Drawing.Point(297, 66);
            this.btnthemnhanvien.Name = "btnthemnhanvien";
            this.btnthemnhanvien.Size = new System.Drawing.Size(50, 27);
            this.btnthemnhanvien.TabIndex = 28;
            this.btnthemnhanvien.Text = "+";
            this.btnthemnhanvien.UseVisualStyleBackColor = true;
            // 
            // btnthemkhachhang
            // 
            this.btnthemkhachhang.Location = new System.Drawing.Point(297, 103);
            this.btnthemkhachhang.Name = "btnthemkhachhang";
            this.btnthemkhachhang.Size = new System.Drawing.Size(50, 27);
            this.btnthemkhachhang.TabIndex = 27;
            this.btnthemkhachhang.Text = "+";
            this.btnthemkhachhang.UseVisualStyleBackColor = true;
            // 
            // dtngayban
            // 
            this.dtngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayban.Location = new System.Drawing.Point(113, 142);
            this.dtngayban.Name = "dtngayban";
            this.dtngayban.Size = new System.Drawing.Size(234, 26);
            this.dtngayban.TabIndex = 26;
            // 
            // cbkhachhang
            // 
            this.cbkhachhang.FormattingEnabled = true;
            this.cbkhachhang.Location = new System.Drawing.Point(113, 103);
            this.cbkhachhang.Name = "cbkhachhang";
            this.cbkhachhang.Size = new System.Drawing.Size(177, 27);
            this.cbkhachhang.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Khách Hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(26, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ngày Bán:";
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(113, 66);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(177, 27);
            this.cbnhanvien.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(22, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhân Viên:";
            // 
            // txtmaHD
            // 
            this.txtmaHD.Location = new System.Drawing.Point(113, 25);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(234, 26);
            this.txtmaHD.TabIndex = 2;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(112, 185);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(235, 26);
            this.txttongtien.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã HĐ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(14, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thành Tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthemnhanvien);
            this.groupBox1.Controls.Add(this.btnthemkhachhang);
            this.groupBox1.Controls.Add(this.dtngayban);
            this.groupBox1.Controls.Add(this.cbkhachhang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbnhanvien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmaHD);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 358);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnluu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnluu.Image = global::GUI.Properties.Resources.fileinto;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnluu.Location = new System.Drawing.Point(350, 399);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 43);
            this.btnluu.TabIndex = 69;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnhuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnhuy.Image = global::GUI.Properties.Resources.exit32;
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(271, 399);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 43);
            this.btnhuy.TabIndex = 68;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsua.Image = global::GUI.Properties.Resources.edit;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(190, 399);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 43);
            this.btnsua.TabIndex = 67;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnthem.Image = global::GUI.Properties.Resources.adduser;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnthem.Location = new System.Drawing.Point(13, 399);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 43);
            this.btnthem.TabIndex = 63;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntimkiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btntimkiem.Image = global::GUI.Properties.Resources.find__1_;
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(431, 399);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(92, 43);
            this.btntimkiem.TabIndex = 70;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnxoa.Image = global::GUI.Properties.Resources.delete32;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(104, 399);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 43);
            this.btnxoa.TabIndex = 66;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.dgHoadon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_hoadon";
            this.Load += new System.EventHandler(this.frm_hoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView dgHoadon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthemnhanvien;
        private System.Windows.Forms.Button btnthemkhachhang;
        private System.Windows.Forms.DateTimePicker dtngayban;
        private System.Windows.Forms.ComboBox cbkhachhang;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}