namespace QUANLYGIAOVIEN
{
    partial class GUI_DanhGia
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
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsearch = new System.Windows.Forms.Label();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtaDanhGia = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maDGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhHieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khenThuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiLuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dta_DanhGia = new QUANLYGIAOVIEN.Dta_DanhGia();
            this.cmbKiLuat = new System.Windows.Forms.ComboBox();
            this.cmbKhenthuong = new System.Windows.Forms.ComboBox();
            this.dateNam = new System.Windows.Forms.DateTimePicker();
            this.cmbMaGV = new System.Windows.Forms.ComboBox();
            this.txtDanhHieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.danhGiaTableAdapter = new QUANLYGIAOVIEN.Dta_DanhGiaTableAdapters.DanhGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtaDanhGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_DanhGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.ButtonText = "           Xóa";
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
            this.btnXoa.Location = new System.Drawing.Point(1200, 457);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(107, 39);
            this.btnXoa.TabIndex = 104;
            this.btnXoa.Text = "           Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Location = new System.Drawing.Point(697, 18);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 13);
            this.btnsearch.TabIndex = 100;
            this.btnsearch.Text = "Tìm kiếm";
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "            Sửa";
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
            this.btnSua.Location = new System.Drawing.Point(1200, 241);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(107, 39);
            this.btnSua.TabIndex = 103;
            this.btnSua.Text = "            Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnTimkiem.Location = new System.Drawing.Point(1041, 14);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimkiem.TabIndex = 105;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(780, 14);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(203, 20);
            this.txtInp.TabIndex = 98;
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "           Thêm";
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
            this.btnThem.Location = new System.Drawing.Point(1200, 70);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(107, 39);
            this.btnThem.TabIndex = 102;
            this.btnThem.Text = "           Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DtaDanhGia
            // 
            this.DtaDanhGia.AllowUserToAddRows = false;
            this.DtaDanhGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaDanhGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaDanhGia.AutoGenerateColumns = false;
            this.DtaDanhGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaDanhGia.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaDanhGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaDanhGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaDanhGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtaDanhGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDGDataGridViewTextBoxColumn,
            this.danhHieuDataGridViewTextBoxColumn,
            this.khenThuongDataGridViewTextBoxColumn,
            this.kiLuatDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn});
            this.DtaDanhGia.DataSource = this.danhGiaBindingSource;
            this.DtaDanhGia.DoubleBuffered = true;
            this.DtaDanhGia.EnableHeadersVisualStyles = false;
            this.DtaDanhGia.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaDanhGia.HeaderForeColor = System.Drawing.Color.White;
            this.DtaDanhGia.Location = new System.Drawing.Point(21, 49);
            this.DtaDanhGia.Name = "DtaDanhGia";
            this.DtaDanhGia.ReadOnly = true;
            this.DtaDanhGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaDanhGia.Size = new System.Drawing.Size(961, 601);
            this.DtaDanhGia.TabIndex = 99;
            this.DtaDanhGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaDanhGia_CellClick);
            // 
            // maDGDataGridViewTextBoxColumn
            // 
            this.maDGDataGridViewTextBoxColumn.DataPropertyName = "MaDG";
            this.maDGDataGridViewTextBoxColumn.HeaderText = "Mã Đánh giá";
            this.maDGDataGridViewTextBoxColumn.Name = "maDGDataGridViewTextBoxColumn";
            this.maDGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danhHieuDataGridViewTextBoxColumn
            // 
            this.danhHieuDataGridViewTextBoxColumn.DataPropertyName = "DanhHieu";
            this.danhHieuDataGridViewTextBoxColumn.HeaderText = "Danh hiệu";
            this.danhHieuDataGridViewTextBoxColumn.Name = "danhHieuDataGridViewTextBoxColumn";
            this.danhHieuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // khenThuongDataGridViewTextBoxColumn
            // 
            this.khenThuongDataGridViewTextBoxColumn.DataPropertyName = "KhenThuong";
            this.khenThuongDataGridViewTextBoxColumn.HeaderText = "Khen thưởng";
            this.khenThuongDataGridViewTextBoxColumn.Name = "khenThuongDataGridViewTextBoxColumn";
            this.khenThuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kiLuatDataGridViewTextBoxColumn
            // 
            this.kiLuatDataGridViewTextBoxColumn.DataPropertyName = "KiLuat";
            this.kiLuatDataGridViewTextBoxColumn.HeaderText = "Kỉ luật";
            this.kiLuatDataGridViewTextBoxColumn.Name = "kiLuatDataGridViewTextBoxColumn";
            this.kiLuatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "Mã GV";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // danhGiaBindingSource
            // 
            this.danhGiaBindingSource.DataMember = "DanhGia";
            this.danhGiaBindingSource.DataSource = this.dta_DanhGia;
            // 
            // dta_DanhGia
            // 
            this.dta_DanhGia.DataSetName = "Dta_DanhGia";
            this.dta_DanhGia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbKiLuat
            // 
            this.cmbKiLuat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKiLuat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKiLuat.FormattingEnabled = true;
            this.cmbKiLuat.Items.AddRange(new object[] {
            "Không",
            "Có"});
            this.cmbKiLuat.Location = new System.Drawing.Point(1036, 310);
            this.cmbKiLuat.Name = "cmbKiLuat";
            this.cmbKiLuat.Size = new System.Drawing.Size(112, 21);
            this.cmbKiLuat.TabIndex = 133;
            // 
            // cmbKhenthuong
            // 
            this.cmbKhenthuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKhenthuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKhenthuong.FormattingEnabled = true;
            this.cmbKhenthuong.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cmbKhenthuong.Location = new System.Drawing.Point(1036, 218);
            this.cmbKhenthuong.Name = "cmbKhenthuong";
            this.cmbKhenthuong.Size = new System.Drawing.Size(112, 21);
            this.cmbKhenthuong.TabIndex = 132;
            // 
            // dateNam
            // 
            this.dateNam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNam.Location = new System.Drawing.Point(1045, 517);
            this.dateNam.Name = "dateNam";
            this.dateNam.Size = new System.Drawing.Size(103, 20);
            this.dateNam.TabIndex = 131;
            // 
            // cmbMaGV
            // 
            this.cmbMaGV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaGV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaGV.FormattingEnabled = true;
            this.cmbMaGV.Location = new System.Drawing.Point(1041, 402);
            this.cmbMaGV.Name = "cmbMaGV";
            this.cmbMaGV.Size = new System.Drawing.Size(112, 21);
            this.cmbMaGV.TabIndex = 128;
            // 
            // txtDanhHieu
            // 
            this.txtDanhHieu.Location = new System.Drawing.Point(1036, 133);
            this.txtDanhHieu.Name = "txtDanhHieu";
            this.txtDanhHieu.Size = new System.Drawing.Size(112, 20);
            this.txtDanhHieu.TabIndex = 117;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1076, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Danh hiệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1064, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1064, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Khen thưởng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1064, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Mã giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Kỉ luật";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // danhGiaTableAdapter
            // 
            this.danhGiaTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_DanhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateNam);
            this.Controls.Add(this.cmbKiLuat);
            this.Controls.Add(this.cmbMaGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKhenthuong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtDanhHieu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DtaDanhGia);
            this.Name = "GUI_DanhGia";
            this.Size = new System.Drawing.Size(1336, 695);
            this.Load += new System.EventHandler(this.GUI_DanhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaDanhGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_DanhGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private System.Windows.Forms.Label btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaDanhGia;
        private System.Windows.Forms.ComboBox cmbKiLuat;
        private System.Windows.Forms.ComboBox cmbKhenthuong;
        private System.Windows.Forms.DateTimePicker dateNam;
        private System.Windows.Forms.ComboBox cmbMaGV;
        private System.Windows.Forms.TextBox txtDanhHieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource danhGiaBindingSource;
        private Dta_DanhGia dta_DanhGia;
        private Dta_DanhGiaTableAdapters.DanhGiaTableAdapter danhGiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khenThuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiLuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
    }
}
