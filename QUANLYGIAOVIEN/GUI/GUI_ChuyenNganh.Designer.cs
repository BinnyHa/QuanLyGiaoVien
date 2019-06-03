namespace QUANLYGIAOVIEN
{
    partial class GUI_ChuyenNganh
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Label();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtaChuyenNganh = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNChinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNKhacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenNghanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dta_ChuyenNganh = new QUANLYGIAOVIEN.Dta_ChuyenNganh();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.chuyenNghanhTableAdapter = new QUANLYGIAOVIEN.Dta_ChuyenNganhTableAdapters.ChuyenNghanhTableAdapter();
            this.cmbTenCN = new System.Windows.Forms.TextBox();
            this.cmbCNchinh = new System.Windows.Forms.TextBox();
            this.cmbCNkhac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtaChuyenNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenNghanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_ChuyenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(944, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Tên Chuyên Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(945, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Chuyên ngành chính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(949, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Chuyên ngành khác";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Location = new System.Drawing.Point(748, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 13);
            this.btnsearch.TabIndex = 117;
            this.btnsearch.Text = "Tìm kiếm";
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
            this.btnSua.Location = new System.Drawing.Point(1167, 275);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(107, 39);
            this.btnSua.TabIndex = 119;
            this.btnSua.Text = "             Sửa";
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
            this.btnTimkiem.Location = new System.Drawing.Point(1043, 13);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimkiem.TabIndex = 121;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(842, 11);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(151, 20);
            this.txtInp.TabIndex = 115;
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
            this.btnThem.Location = new System.Drawing.Point(1167, 154);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(107, 39);
            this.btnThem.TabIndex = 118;
            this.btnThem.Text = "           Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DtaChuyenNganh
            // 
            this.DtaChuyenNganh.AllowUserToAddRows = false;
            this.DtaChuyenNganh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaChuyenNganh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaChuyenNganh.AutoGenerateColumns = false;
            this.DtaChuyenNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaChuyenNganh.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaChuyenNganh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaChuyenNganh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaChuyenNganh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaChuyenNganh.ColumnHeadersHeight = 25;
            this.DtaChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCNDataGridViewTextBoxColumn,
            this.tenCNDataGridViewTextBoxColumn,
            this.cNChinhDataGridViewTextBoxColumn,
            this.cNKhacDataGridViewTextBoxColumn});
            this.DtaChuyenNganh.DataSource = this.chuyenNghanhBindingSource;
            this.DtaChuyenNganh.DoubleBuffered = true;
            this.DtaChuyenNganh.EnableHeadersVisualStyles = false;
            this.DtaChuyenNganh.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaChuyenNganh.HeaderForeColor = System.Drawing.Color.White;
            this.DtaChuyenNganh.Location = new System.Drawing.Point(13, 55);
            this.DtaChuyenNganh.Name = "DtaChuyenNganh";
            this.DtaChuyenNganh.ReadOnly = true;
            this.DtaChuyenNganh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaChuyenNganh.Size = new System.Drawing.Size(917, 618);
            this.DtaChuyenNganh.TabIndex = 116;
            this.DtaChuyenNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaChuyenNganh_CellClick);
            // 
            // maCNDataGridViewTextBoxColumn
            // 
            this.maCNDataGridViewTextBoxColumn.DataPropertyName = "MaCN";
            this.maCNDataGridViewTextBoxColumn.HeaderText = "Mã Chuyên ngành";
            this.maCNDataGridViewTextBoxColumn.Name = "maCNDataGridViewTextBoxColumn";
            this.maCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenCNDataGridViewTextBoxColumn
            // 
            this.tenCNDataGridViewTextBoxColumn.DataPropertyName = "TenCN";
            this.tenCNDataGridViewTextBoxColumn.HeaderText = "Tên Chuyên ngành";
            this.tenCNDataGridViewTextBoxColumn.Name = "tenCNDataGridViewTextBoxColumn";
            this.tenCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNChinhDataGridViewTextBoxColumn
            // 
            this.cNChinhDataGridViewTextBoxColumn.DataPropertyName = "CN_Chinh";
            this.cNChinhDataGridViewTextBoxColumn.HeaderText = "Chuyên ngành chính";
            this.cNChinhDataGridViewTextBoxColumn.Name = "cNChinhDataGridViewTextBoxColumn";
            this.cNChinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNKhacDataGridViewTextBoxColumn
            // 
            this.cNKhacDataGridViewTextBoxColumn.DataPropertyName = "CN_Khac";
            this.cNKhacDataGridViewTextBoxColumn.HeaderText = "Chuyên ngành khác";
            this.cNKhacDataGridViewTextBoxColumn.Name = "cNKhacDataGridViewTextBoxColumn";
            this.cNKhacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chuyenNghanhBindingSource
            // 
            this.chuyenNghanhBindingSource.DataMember = "ChuyenNghanh";
            this.chuyenNghanhBindingSource.DataSource = this.dta_ChuyenNganh;
            // 
            // dta_ChuyenNganh
            // 
            this.dta_ChuyenNganh.DataSetName = "Dta_ChuyenNganh";
            this.dta_ChuyenNganh.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnXoa.Location = new System.Drawing.Point(1167, 399);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(107, 39);
            this.btnXoa.TabIndex = 120;
            this.btnXoa.Text = "             Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // chuyenNghanhTableAdapter
            // 
            this.chuyenNghanhTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTenCN
            // 
            this.cmbTenCN.Location = new System.Drawing.Point(948, 125);
            this.cmbTenCN.Name = "cmbTenCN";
            this.cmbTenCN.Size = new System.Drawing.Size(151, 20);
            this.cmbTenCN.TabIndex = 136;
            // 
            // cmbCNchinh
            // 
            this.cmbCNchinh.Location = new System.Drawing.Point(948, 339);
            this.cmbCNchinh.Name = "cmbCNchinh";
            this.cmbCNchinh.Size = new System.Drawing.Size(151, 20);
            this.cmbCNchinh.TabIndex = 137;
            // 
            // cmbCNkhac
            // 
            this.cmbCNkhac.Location = new System.Drawing.Point(948, 553);
            this.cmbCNkhac.Name = "cmbCNkhac";
            this.cmbCNkhac.Size = new System.Drawing.Size(151, 20);
            this.cmbCNkhac.TabIndex = 138;
            // 
            // GUI_ChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.cmbCNkhac);
            this.Controls.Add(this.cmbCNchinh);
            this.Controls.Add(this.cmbTenCN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DtaChuyenNganh);
            this.Controls.Add(this.btnXoa);
            this.Name = "GUI_ChuyenNganh";
            this.Size = new System.Drawing.Size(1336, 695);
            this.Load += new System.EventHandler(this.GUI_ChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaChuyenNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenNghanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_ChuyenNganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaChuyenNganh;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Dta_ChuyenNganh dta_ChuyenNganh;
        private System.Windows.Forms.BindingSource chuyenNghanhBindingSource;
        private Dta_ChuyenNganhTableAdapters.ChuyenNghanhTableAdapter chuyenNghanhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNChinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNKhacDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox cmbTenCN;
        private System.Windows.Forms.TextBox cmbCNchinh;
        private System.Windows.Forms.TextBox cmbCNkhac;
    }
}
