namespace QUANLYGIAOVIEN
{
    partial class GUI_GiaoVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtaGiaoVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sĐTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danTocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonGiaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBHYTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTDHVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaoVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dta_giaovien = new QUANLYGIAOVIEN.Dta_giaovien();
            this.PanelThem = new System.Windows.Forms.Panel();
            this.cmbMaTDHV = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMaCongTac = new System.Windows.Forms.ComboBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaLuong = new System.Windows.Forms.ComboBox();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimepk1 = new System.Windows.Forms.DateTimePicker();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsearch = new System.Windows.Forms.Label();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.giaoVienTableAdapter = new QUANLYGIAOVIEN.Dta_giaovienTableAdapters.GiaoVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtaGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_giaovien)).BeginInit();
            this.PanelThem.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtaGiaoVien
            // 
            this.DtaGiaoVien.AllowUserToAddRows = false;
            this.DtaGiaoVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaGiaoVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaGiaoVien.AutoGenerateColumns = false;
            this.DtaGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaGiaoVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaGiaoVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.tenGVDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.sĐTDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.danTocDataGridViewTextBoxColumn,
            this.tonGiaoDataGridViewTextBoxColumn,
            this.soBHYTDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.maLuongDataGridViewTextBoxColumn,
            this.maCTDataGridViewTextBoxColumn,
            this.maTDHVDataGridViewTextBoxColumn});
            this.DtaGiaoVien.DataSource = this.giaoVienBindingSource;
            this.DtaGiaoVien.DoubleBuffered = true;
            this.DtaGiaoVien.EnableHeadersVisualStyles = false;
            this.DtaGiaoVien.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaGiaoVien.HeaderForeColor = System.Drawing.Color.White;
            this.DtaGiaoVien.Location = new System.Drawing.Point(15, 33);
            this.DtaGiaoVien.Name = "DtaGiaoVien";
            this.DtaGiaoVien.ReadOnly = true;
            this.DtaGiaoVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaGiaoVien.Size = new System.Drawing.Size(843, 631);
            this.DtaGiaoVien.TabIndex = 0;
            this.DtaGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaGiaoVien_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaGV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã GV";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tenGVDataGridViewTextBoxColumn
            // 
            this.tenGVDataGridViewTextBoxColumn.DataPropertyName = "TenGV";
            this.tenGVDataGridViewTextBoxColumn.HeaderText = "Tên GV";
            this.tenGVDataGridViewTextBoxColumn.Name = "tenGVDataGridViewTextBoxColumn";
            this.tenGVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "Ngay_Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày Sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sĐTDataGridViewTextBoxColumn
            // 
            this.sĐTDataGridViewTextBoxColumn.DataPropertyName = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sĐTDataGridViewTextBoxColumn.Name = "sĐTDataGridViewTextBoxColumn";
            this.sĐTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Que_quan";
            this.quequanDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            this.quequanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danTocDataGridViewTextBoxColumn
            // 
            this.danTocDataGridViewTextBoxColumn.DataPropertyName = "DanToc";
            this.danTocDataGridViewTextBoxColumn.HeaderText = "Dân tộc";
            this.danTocDataGridViewTextBoxColumn.Name = "danTocDataGridViewTextBoxColumn";
            this.danTocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tonGiaoDataGridViewTextBoxColumn
            // 
            this.tonGiaoDataGridViewTextBoxColumn.DataPropertyName = "TonGiao";
            this.tonGiaoDataGridViewTextBoxColumn.HeaderText = "Tôn giáo";
            this.tonGiaoDataGridViewTextBoxColumn.Name = "tonGiaoDataGridViewTextBoxColumn";
            this.tonGiaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soBHYTDataGridViewTextBoxColumn
            // 
            this.soBHYTDataGridViewTextBoxColumn.DataPropertyName = "So_BHYT";
            this.soBHYTDataGridViewTextBoxColumn.HeaderText = "Số BHYT";
            this.soBHYTDataGridViewTextBoxColumn.Name = "soBHYTDataGridViewTextBoxColumn";
            this.soBHYTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaChuyenNganh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã Chuyên Ngành";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // maLuongDataGridViewTextBoxColumn
            // 
            this.maLuongDataGridViewTextBoxColumn.DataPropertyName = "MaLuong";
            this.maLuongDataGridViewTextBoxColumn.HeaderText = "Mã Lương";
            this.maLuongDataGridViewTextBoxColumn.Name = "maLuongDataGridViewTextBoxColumn";
            this.maLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maCTDataGridViewTextBoxColumn
            // 
            this.maCTDataGridViewTextBoxColumn.DataPropertyName = "MaCT";
            this.maCTDataGridViewTextBoxColumn.HeaderText = "Mã Công tác";
            this.maCTDataGridViewTextBoxColumn.Name = "maCTDataGridViewTextBoxColumn";
            this.maCTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maTDHVDataGridViewTextBoxColumn
            // 
            this.maTDHVDataGridViewTextBoxColumn.DataPropertyName = "MaTDHV";
            this.maTDHVDataGridViewTextBoxColumn.HeaderText = "Mã Trình độ học vấn";
            this.maTDHVDataGridViewTextBoxColumn.Name = "maTDHVDataGridViewTextBoxColumn";
            this.maTDHVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaoVienBindingSource
            // 
            this.giaoVienBindingSource.DataMember = "GiaoVien";
            this.giaoVienBindingSource.DataSource = this.dta_giaovien;
            // 
            // dta_giaovien
            // 
            this.dta_giaovien.DataSetName = "Dta_giaovien";
            this.dta_giaovien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelThem
            // 
            this.PanelThem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelThem.Controls.Add(this.cmbMaTDHV);
            this.PanelThem.Controls.Add(this.label13);
            this.PanelThem.Controls.Add(this.label9);
            this.PanelThem.Controls.Add(this.label14);
            this.PanelThem.Controls.Add(this.label12);
            this.PanelThem.Controls.Add(this.cmbMaCongTac);
            this.PanelThem.Controls.Add(this.txtDanToc);
            this.PanelThem.Controls.Add(this.label6);
            this.PanelThem.Controls.Add(this.label10);
            this.PanelThem.Controls.Add(this.label5);
            this.PanelThem.Controls.Add(this.label4);
            this.PanelThem.Controls.Add(this.cmbMaLuong);
            this.PanelThem.Controls.Add(this.txtTonGiao);
            this.PanelThem.Controls.Add(this.label3);
            this.PanelThem.Controls.Add(this.label8);
            this.PanelThem.Controls.Add(this.txtQueQuan);
            this.PanelThem.Controls.Add(this.txtBHYT);
            this.PanelThem.Controls.Add(this.label11);
            this.PanelThem.Controls.Add(this.label7);
            this.PanelThem.Controls.Add(this.cmbChuyenNganh);
            this.PanelThem.Controls.Add(this.label2);
            this.PanelThem.Controls.Add(this.label1);
            this.PanelThem.Controls.Add(this.dateTimepk1);
            this.PanelThem.Controls.Add(this.cmbGioiTinh);
            this.PanelThem.Controls.Add(this.txtCMND);
            this.PanelThem.Controls.Add(this.txtEmail);
            this.PanelThem.Controls.Add(this.txtSDT);
            this.PanelThem.Controls.Add(this.txtHoTen);
            this.PanelThem.Location = new System.Drawing.Point(875, 76);
            this.PanelThem.Name = "PanelThem";
            this.PanelThem.Size = new System.Drawing.Size(320, 588);
            this.PanelThem.TabIndex = 1;
            // 
            // cmbMaTDHV
            // 
            this.cmbMaTDHV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaTDHV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaTDHV.FormattingEnabled = true;
            this.cmbMaTDHV.Location = new System.Drawing.Point(173, 542);
            this.cmbMaTDHV.Name = "cmbMaTDHV";
            this.cmbMaTDHV.Size = new System.Drawing.Size(103, 21);
            this.cmbMaTDHV.TabIndex = 129;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 497);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 132;
            this.label13.Text = "Mã trình độ học vấn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "Dân tộc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 134;
            this.label14.Text = "Tôn giáo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 131;
            this.label12.Text = "Mã công tác";
            // 
            // cmbMaCongTac
            // 
            this.cmbMaCongTac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaCongTac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaCongTac.FormattingEnabled = true;
            this.cmbMaCongTac.Location = new System.Drawing.Point(176, 438);
            this.cmbMaCongTac.Name = "cmbMaCongTac";
            this.cmbMaCongTac.Size = new System.Drawing.Size(103, 21);
            this.cmbMaCongTac.TabIndex = 128;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(173, 40);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(103, 20);
            this.txtDanToc.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Tên giáo viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 130;
            this.label10.Text = "Mã lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 114;
            this.label4.Text = "Email";
            // 
            // cmbMaLuong
            // 
            this.cmbMaLuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaLuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaLuong.FormattingEnabled = true;
            this.cmbMaLuong.Location = new System.Drawing.Point(173, 348);
            this.cmbMaLuong.Name = "cmbMaLuong";
            this.cmbMaLuong.Size = new System.Drawing.Size(103, 21);
            this.cmbMaLuong.TabIndex = 127;
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Location = new System.Drawing.Point(173, 116);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(103, 20);
            this.txtTonGiao.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 120;
            this.label8.Text = "Quê quán";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(15, 542);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(103, 20);
            this.txtQueQuan.TabIndex = 119;
            // 
            // txtBHYT
            // 
            this.txtBHYT.Location = new System.Drawing.Point(173, 199);
            this.txtBHYT.Name = "txtBHYT";
            this.txtBHYT.Size = new System.Drawing.Size(103, 20);
            this.txtBHYT.TabIndex = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 124;
            this.label11.Text = "Số bảo hiểm y tế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Chuyên ngành";
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbChuyenNganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(176, 264);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(103, 21);
            this.cmbChuyenNganh.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Giới tính";
            // 
            // dateTimepk1
            // 
            this.dateTimepk1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimepk1.Location = new System.Drawing.Point(15, 115);
            this.dateTimepk1.Name = "dateTimepk1";
            this.dateTimepk1.Size = new System.Drawing.Size(103, 20);
            this.dateTimepk1.TabIndex = 110;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(15, 199);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(103, 21);
            this.cmbGioiTinh.TabIndex = 109;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(15, 349);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(103, 20);
            this.txtCMND.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 438);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(103, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(15, 266);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(103, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(15, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(103, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "             Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 90D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(1202, 139);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(107, 39);
            this.btnThem.TabIndex = 85;
            this.btnThem.Text = "             Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.BorderRadius = 0;
            this.btnTimkiem.ButtonText = "       Tìm kiếm";
            this.btnTimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimkiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimkiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimkiem.Iconimage = null;
            this.btnTimkiem.Iconimage_right = null;
            this.btnTimkiem.Iconimage_right_Selected = null;
            this.btnTimkiem.Iconimage_Selected = null;
            this.btnTimkiem.IconMarginLeft = 0;
            this.btnTimkiem.IconMarginRight = 0;
            this.btnTimkiem.IconRightVisible = true;
            this.btnTimkiem.IconRightZoom = 0D;
            this.btnTimkiem.IconVisible = true;
            this.btnTimkiem.IconZoom = 90D;
            this.btnTimkiem.IsTab = false;
            this.btnTimkiem.Location = new System.Drawing.Point(1191, 13);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimkiem.TabIndex = 88;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(985, 16);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(154, 20);
            this.txtInp.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "             Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = null;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 90D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(1202, 256);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(107, 39);
            this.btnSua.TabIndex = 86;
            this.btnSua.Text = "             Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Location = new System.Drawing.Point(896, 16);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 13);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Tìm kiếm";
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.ButtonText = "             Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoa.Iconimage = null;
            this.btnXoa.Iconimage_right = null;
            this.btnXoa.Iconimage_right_Selected = null;
            this.btnXoa.Iconimage_Selected = null;
            this.btnXoa.IconMarginLeft = 0;
            this.btnXoa.IconMarginRight = 0;
            this.btnXoa.IconRightVisible = true;
            this.btnXoa.IconRightZoom = 0D;
            this.btnXoa.IconVisible = true;
            this.btnXoa.IconZoom = 90D;
            this.btnXoa.IsTab = false;
            this.btnXoa.Location = new System.Drawing.Point(1202, 363);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(107, 39);
            this.btnXoa.TabIndex = 87;
            this.btnXoa.Text = "             Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // giaoVienTableAdapter
            // 
            this.giaoVienTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_GiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.PanelThem);
            this.Controls.Add(this.DtaGiaoVien);
            this.Name = "GUI_GiaoVien";
            this.Size = new System.Drawing.Size(1336, 695);
            this.Load += new System.EventHandler(this.GiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_giaovien)).EndInit();
            this.PanelThem.ResumeLayout(false);
            this.PanelThem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaGiaoVien;
        private System.Windows.Forms.Panel PanelThem;
        private System.Windows.Forms.TextBox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dateTimepk1;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dchiGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdTGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChuyenNganhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.BindingSource giaoVienBindingSource;
        private Dta_giaovien dta_giaovien;
        private Dta_giaovienTableAdapters.GiaoVienTableAdapter giaoVienTableAdapter;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sĐTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danTocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonGiaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBHYTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTDHVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMaTDHV;
        private System.Windows.Forms.ComboBox cmbMaCongTac;
        private System.Windows.Forms.ComboBox cmbMaLuong;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTonGiao;
    }
}
