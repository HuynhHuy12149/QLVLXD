
namespace GUI
{
    partial class frm_chitiethoadon
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
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.dtngayban = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbhoadon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttongtienhd = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsoluongkho = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtthanhtiensp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbsanpham = new System.Windows.Forms.ComboBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgcthd = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btninhoadon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthemhd = new System.Windows.Forms.Button();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtsdtkh = new System.Windows.Forms.TextBox();
            this.txtdiachikh = new System.Windows.Forms.TextBox();
            this.cbmakh = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnundo = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcthd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(274, 57);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(69, 27);
            this.cbmanv.TabIndex = 32;
            this.cbmanv.SelectedIndexChanged += new System.EventHandler(this.cbmanv_SelectedIndexChanged);
            // 
            // dtngayban
            // 
            this.dtngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayban.Location = new System.Drawing.Point(91, 91);
            this.dtngayban.Name = "dtngayban";
            this.dtngayban.Size = new System.Drawing.Size(252, 26);
            this.dtngayban.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(448, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "SDT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(427, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa Chỉ:";
            // 
            // cbhoadon
            // 
            this.cbhoadon.FormattingEnabled = true;
            this.cbhoadon.Location = new System.Drawing.Point(91, 25);
            this.cbhoadon.Name = "cbhoadon";
            this.cbhoadon.Size = new System.Drawing.Size(177, 27);
            this.cbhoadon.TabIndex = 26;
            this.cbhoadon.SelectedIndexChanged += new System.EventHandler(this.cbhoadon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hóa Đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(18, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tên NV:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttongtienhd);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(581, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 48);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng Tiền HĐ";
            // 
            // txttongtienhd
            // 
            this.txttongtienhd.Location = new System.Drawing.Point(6, 20);
            this.txttongtienhd.Name = "txttongtienhd";
            this.txttongtienhd.Size = new System.Drawing.Size(188, 22);
            this.txttongtienhd.TabIndex = 0;
            this.txttongtienhd.TextChanged += new System.EventHandler(this.txttongtienhd_TextChanged);
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(91, 58);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(177, 26);
            this.txttennv.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnundo);
            this.groupBox2.Controls.Add(this.txtsoluongkho);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtthanhtiensp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbsanpham);
            this.groupBox2.Controls.Add(this.txtsoluong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgcthd);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 224);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Sản Phẩm Mua";
            // 
            // txtsoluongkho
            // 
            this.txtsoluongkho.Location = new System.Drawing.Point(220, 59);
            this.txtsoluongkho.Name = "txtsoluongkho";
            this.txtsoluongkho.Size = new System.Drawing.Size(123, 26);
            this.txtsoluongkho.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(411, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Thành Tiền:";
            // 
            // txtthanhtiensp
            // 
            this.txtthanhtiensp.Location = new System.Drawing.Point(505, 60);
            this.txtthanhtiensp.Name = "txtthanhtiensp";
            this.txtthanhtiensp.Size = new System.Drawing.Size(258, 26);
            this.txtthanhtiensp.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(433, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Đơn Giá:";
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(505, 25);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(258, 26);
            this.txtdongia.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(9, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Số Lượng:";
            // 
            // cbsanpham
            // 
            this.cbsanpham.FormattingEnabled = true;
            this.cbsanpham.Location = new System.Drawing.Point(93, 25);
            this.cbsanpham.Name = "cbsanpham";
            this.cbsanpham.Size = new System.Drawing.Size(250, 27);
            this.cbsanpham.TabIndex = 33;
            this.cbsanpham.SelectedIndexChanged += new System.EventHandler(this.cbsanpham_SelectedIndexChanged);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(93, 60);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(121, 26);
            this.txtsoluong.TabIndex = 32;
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sản Phẩm:";
            // 
            // dgcthd
            // 
            this.dgcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcthd.Location = new System.Drawing.Point(91, 99);
            this.dgcthd.Name = "dgcthd";
            this.dgcthd.Size = new System.Drawing.Size(672, 119);
            this.dgcthd.TabIndex = 32;
            this.dgcthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcthd_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(266, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "DANH MỤC MUA HÀNG";
            // 
            // btninhoadon
            // 
            this.btninhoadon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btninhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btninhoadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninhoadon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninhoadon.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btninhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninhoadon.Location = new System.Drawing.Point(467, 397);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(108, 43);
            this.btninhoadon.TabIndex = 61;
            this.btninhoadon.Text = "In Hóa Đơn";
            this.btninhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninhoadon.UseVisualStyleBackColor = false;
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(422, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên KH:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthemhd);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.dtngayban);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtsdtkh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdiachikh);
            this.groupBox1.Controls.Add(this.cbhoadon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbmakh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttennv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 128);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnthemhd
            // 
            this.btnthemhd.Location = new System.Drawing.Point(274, 26);
            this.btnthemhd.Name = "btnthemhd";
            this.btnthemhd.Size = new System.Drawing.Size(69, 26);
            this.btnthemhd.TabIndex = 34;
            this.btnthemhd.Text = "+";
            this.btnthemhd.UseVisualStyleBackColor = true;
            this.btnthemhd.Click += new System.EventHandler(this.btnthemhd_Click);
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(495, 25);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(169, 26);
            this.txttenkh.TabIndex = 33;
            // 
            // txtsdtkh
            // 
            this.txtsdtkh.Location = new System.Drawing.Point(495, 90);
            this.txtsdtkh.Name = "txtsdtkh";
            this.txtsdtkh.Size = new System.Drawing.Size(256, 26);
            this.txtsdtkh.TabIndex = 29;
            // 
            // txtdiachikh
            // 
            this.txtdiachikh.Location = new System.Drawing.Point(495, 58);
            this.txtdiachikh.Name = "txtdiachikh";
            this.txtdiachikh.Size = new System.Drawing.Size(256, 26);
            this.txtdiachikh.TabIndex = 27;
            // 
            // cbmakh
            // 
            this.cbmakh.FormattingEnabled = true;
            this.cbmakh.Location = new System.Drawing.Point(670, 24);
            this.cbmakh.Name = "cbmakh";
            this.cbmakh.Size = new System.Drawing.Size(81, 27);
            this.cbmakh.TabIndex = 24;
            this.cbmakh.SelectedIndexChanged += new System.EventHandler(this.cbmakh_SelectedIndexChanged);
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
            this.btnthem.Location = new System.Drawing.Point(12, 397);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(85, 43);
            this.btnthem.TabIndex = 54;
            this.btnthem.Text = "Thêm ";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
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
            this.btnsua.Location = new System.Drawing.Point(197, 397);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(83, 43);
            this.btnsua.TabIndex = 58;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
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
            this.btnluu.Location = new System.Drawing.Point(375, 397);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(86, 43);
            this.btnluu.TabIndex = 60;
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
            this.btnhuy.Location = new System.Drawing.Point(286, 397);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(83, 43);
            this.btnhuy.TabIndex = 59;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
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
            this.btnxoa.Location = new System.Drawing.Point(105, 397);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 43);
            this.btnxoa.TabIndex = 57;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnundo
            // 
            this.btnundo.Location = new System.Drawing.Point(10, 99);
            this.btnundo.Name = "btnundo";
            this.btnundo.Size = new System.Drawing.Size(75, 37);
            this.btnundo.TabIndex = 39;
            this.btnundo.Text = "UNDO";
            this.btnundo.UseVisualStyleBackColor = true;
            
            // 
            // frm_chitiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnxoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_chitiethoadon";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_chitiethoadon";
            this.Load += new System.EventHandler(this.frm_chitiethoadon_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcthd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.DateTimePicker dtngayban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbhoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttongtienhd;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsoluongkho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtthanhtiensp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbsanpham;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgcthd;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninhoadon;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthemhd;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtsdtkh;
        private System.Windows.Forms.TextBox txtdiachikh;
        private System.Windows.Forms.ComboBox cbmakh;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnundo;
    }
}