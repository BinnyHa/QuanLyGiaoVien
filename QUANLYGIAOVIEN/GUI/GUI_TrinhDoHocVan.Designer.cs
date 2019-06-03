namespace QUANLYGIAOVIEN
{
    partial class GUI_TrinhDoHocVan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTrinhDoKhac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrinhDoChinh = new System.Windows.Forms.TextBox();
            this.txtTrinhDoTH = new System.Windows.Forms.TextBox();
            this.txtTrinhDoCm = new System.Windows.Forms.TextBox();
            this.txtTrinhDoNN = new System.Windows.Forms.TextBox();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsearch = new System.Windows.Forms.Label();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtaTrinhDoHocVan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maTDHVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdoCMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdoNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdoTinHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdochinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdokhacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDoHocVanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dta_TrinhDoHocVan = new QUANLYGIAOVIEN.Dta_TrinhDoHocVan();
            this.trinhDoHocVanTableAdapter = new QUANLYGIAOVIEN.Dta_TrinhDoHocVanTableAdapters.TrinhDoHocVanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtaTrinhDoHocVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoHocVanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_TrinhDoHocVan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTrinhDoKhac
            // 
            this.txtTrinhDoKhac.Location = new System.Drawing.Point(1040, 488);
            this.txtTrinhDoKhac.Name = "txtTrinhDoKhac";
            this.txtTrinhDoKhac.Size = new System.Drawing.Size(103, 20);
            this.txtTrinhDoKhac.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1052, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "Trình độ khác";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1052, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 116;
            this.label6.Text = "Trình độ CM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1052, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 115;
            this.label5.Text = "Trình độ chính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1052, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 112;
            this.label8.Text = "Trình độ NN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1052, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Trình độ tin học";
            // 
            // txtTrinhDoChinh
            // 
            this.txtTrinhDoChinh.Location = new System.Drawing.Point(1040, 399);
            this.txtTrinhDoChinh.Name = "txtTrinhDoChinh";
            this.txtTrinhDoChinh.Size = new System.Drawing.Size(103, 20);
            this.txtTrinhDoChinh.TabIndex = 4;
            // 
            // txtTrinhDoTH
            // 
            this.txtTrinhDoTH.Location = new System.Drawing.Point(1040, 312);
            this.txtTrinhDoTH.Name = "txtTrinhDoTH";
            this.txtTrinhDoTH.Size = new System.Drawing.Size(103, 20);
            this.txtTrinhDoTH.TabIndex = 3;
            // 
            // txtTrinhDoCm
            // 
            this.txtTrinhDoCm.Location = new System.Drawing.Point(1040, 120);
            this.txtTrinhDoCm.Name = "txtTrinhDoCm";
            this.txtTrinhDoCm.Size = new System.Drawing.Size(103, 20);
            this.txtTrinhDoCm.TabIndex = 1;
            // 
            // txtTrinhDoNN
            // 
            this.txtTrinhDoNN.Location = new System.Drawing.Point(1040, 214);
            this.txtTrinhDoNN.Name = "txtTrinhDoNN";
            this.txtTrinhDoNN.Size = new System.Drawing.Size(103, 20);
            this.txtTrinhDoNN.TabIndex = 2;
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
            this.btnSua.Location = new System.Drawing.Point(1199, 270);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(107, 39);
            this.btnSua.TabIndex = 107;
            this.btnSua.Text = "             Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(1199, 446);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(107, 39);
            this.btnXoa.TabIndex = 108;
            this.btnXoa.Text = "             Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Location = new System.Drawing.Point(814, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 13);
            this.btnsearch.TabIndex = 105;
            this.btnsearch.Text = "Tìm kiếm";
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
            this.btnTimkiem.Location = new System.Drawing.Point(1040, 16);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimkiem.TabIndex = 109;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(885, 16);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(100, 20);
            this.txtInp.TabIndex = 104;
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
            this.btnThem.Location = new System.Drawing.Point(1199, 130);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(107, 39);
            this.btnThem.TabIndex = 106;
            this.btnThem.Text = "             Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DtaTrinhDoHocVan
            // 
            this.DtaTrinhDoHocVan.AllowUserToAddRows = false;
            this.DtaTrinhDoHocVan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaTrinhDoHocVan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaTrinhDoHocVan.AutoGenerateColumns = false;
            this.DtaTrinhDoHocVan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaTrinhDoHocVan.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaTrinhDoHocVan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaTrinhDoHocVan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaTrinhDoHocVan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaTrinhDoHocVan.ColumnHeadersHeight = 25;
            this.DtaTrinhDoHocVan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTDHVDataGridViewTextBoxColumn,
            this.trinhdoCMDataGridViewTextBoxColumn,
            this.trinhdoNNDataGridViewTextBoxColumn,
            this.trinhdoTinHocDataGridViewTextBoxColumn,
            this.trinhdochinhDataGridViewTextBoxColumn,
            this.trinhdokhacDataGridViewTextBoxColumn});
            this.DtaTrinhDoHocVan.DataSource = this.trinhDoHocVanBindingSource;
            this.DtaTrinhDoHocVan.DoubleBuffered = true;
            this.DtaTrinhDoHocVan.EnableHeadersVisualStyles = false;
            this.DtaTrinhDoHocVan.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaTrinhDoHocVan.HeaderForeColor = System.Drawing.Color.White;
            this.DtaTrinhDoHocVan.Location = new System.Drawing.Point(12, 45);
            this.DtaTrinhDoHocVan.Name = "DtaTrinhDoHocVan";
            this.DtaTrinhDoHocVan.ReadOnly = true;
            this.DtaTrinhDoHocVan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaTrinhDoHocVan.Size = new System.Drawing.Size(973, 604);
            this.DtaTrinhDoHocVan.TabIndex = 103;
            this.DtaTrinhDoHocVan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtaTrinhDoHocVan_CellClick);
            // 
            // maTDHVDataGridViewTextBoxColumn
            // 
            this.maTDHVDataGridViewTextBoxColumn.DataPropertyName = "MaTDHV";
            this.maTDHVDataGridViewTextBoxColumn.HeaderText = "Mã TDHV";
            this.maTDHVDataGridViewTextBoxColumn.Name = "maTDHVDataGridViewTextBoxColumn";
            this.maTDHVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhdoCMDataGridViewTextBoxColumn
            // 
            this.trinhdoCMDataGridViewTextBoxColumn.DataPropertyName = "Trinhdo_CM";
            this.trinhdoCMDataGridViewTextBoxColumn.HeaderText = "Trình độ chuyên môn";
            this.trinhdoCMDataGridViewTextBoxColumn.Name = "trinhdoCMDataGridViewTextBoxColumn";
            this.trinhdoCMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhdoNNDataGridViewTextBoxColumn
            // 
            this.trinhdoNNDataGridViewTextBoxColumn.DataPropertyName = "Trinhdo_NN";
            this.trinhdoNNDataGridViewTextBoxColumn.HeaderText = "Trình độ ngoại ngữ";
            this.trinhdoNNDataGridViewTextBoxColumn.Name = "trinhdoNNDataGridViewTextBoxColumn";
            this.trinhdoNNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhdoTinHocDataGridViewTextBoxColumn
            // 
            this.trinhdoTinHocDataGridViewTextBoxColumn.DataPropertyName = "Trinhdo_TinHoc";
            this.trinhdoTinHocDataGridViewTextBoxColumn.HeaderText = "Trình độ tin học";
            this.trinhdoTinHocDataGridViewTextBoxColumn.Name = "trinhdoTinHocDataGridViewTextBoxColumn";
            this.trinhdoTinHocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhdochinhDataGridViewTextBoxColumn
            // 
            this.trinhdochinhDataGridViewTextBoxColumn.DataPropertyName = "Trinhdo_chinh";
            this.trinhdochinhDataGridViewTextBoxColumn.HeaderText = "Trình độ chính";
            this.trinhdochinhDataGridViewTextBoxColumn.Name = "trinhdochinhDataGridViewTextBoxColumn";
            this.trinhdochinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhdokhacDataGridViewTextBoxColumn
            // 
            this.trinhdokhacDataGridViewTextBoxColumn.DataPropertyName = "Trinhdo_khac";
            this.trinhdokhacDataGridViewTextBoxColumn.HeaderText = "Trình độ khác";
            this.trinhdokhacDataGridViewTextBoxColumn.Name = "trinhdokhacDataGridViewTextBoxColumn";
            this.trinhdokhacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trinhDoHocVanBindingSource
            // 
            this.trinhDoHocVanBindingSource.DataMember = "TrinhDoHocVan";
            this.trinhDoHocVanBindingSource.DataSource = this.dta_TrinhDoHocVan;
            // 
            // dta_TrinhDoHocVan
            // 
            this.dta_TrinhDoHocVan.DataSetName = "Dta_TrinhDoHocVan";
            this.dta_TrinhDoHocVan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trinhDoHocVanTableAdapter
            // 
            this.trinhDoHocVanTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_TrinhDoHocVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.txtTrinhDoKhac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTrinhDoChinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTrinhDoTH);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtTrinhDoNN);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTrinhDoCm);
            this.Controls.Add(this.DtaTrinhDoHocVan);
            this.Name = "GUI_TrinhDoHocVan";
            this.Size = new System.Drawing.Size(1336, 695);
            this.Load += new System.EventHandler(this.GUI_TrinhDoHocVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtaTrinhDoHocVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoHocVanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dta_TrinhDoHocVan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrinhDoKhac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTrinhDoChinh;
        private System.Windows.Forms.TextBox txtTrinhDoTH;
        private System.Windows.Forms.TextBox txtTrinhDoCm;
        private System.Windows.Forms.TextBox txtTrinhDoNN;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private System.Windows.Forms.Label btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaTrinhDoHocVan;
        private Dta_TrinhDoHocVan dta_TrinhDoHocVan;
        private System.Windows.Forms.BindingSource trinhDoHocVanBindingSource;
        private Dta_TrinhDoHocVanTableAdapters.TrinhDoHocVanTableAdapter trinhDoHocVanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTDHVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdoCMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdoNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdoTinHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdochinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdokhacDataGridViewTextBoxColumn;
    }
}