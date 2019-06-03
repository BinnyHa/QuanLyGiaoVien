namespace QUANLYGIAOVIEN.Layout
{
    partial class GUI_MonHoc
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
            this.btnsearch = new System.Windows.Forms.Label();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInp = new System.Windows.Forms.TextBox();
            this.DtaTrinhDoHocVan = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGiangDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietGiangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaoVienTieuHocDataSet1 = new QUANLYGIAOVIEN.QuanLyGiaoVienTieuHocDataSet1();
            this.chiTietGiangDayTableAdapter = new QUANLYGIAOVIEN.QuanLyGiaoVienTieuHocDataSet1TableAdapters.ChiTietGiangDayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtaTrinhDoHocVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietGiangDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaoVienTieuHocDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Location = new System.Drawing.Point(854, 19);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 13);
            this.btnsearch.TabIndex = 113;
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
            this.btnTimkiem.Location = new System.Drawing.Point(1143, 16);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimkiem.TabIndex = 117;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(982, 12);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(100, 20);
            this.txtInp.TabIndex = 112;
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
            this.maMonDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn,
            this.soTietDataGridViewTextBoxColumn,
            this.maGiangDayDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn});
            this.DtaTrinhDoHocVan.DataSource = this.chiTietGiangDayBindingSource;
            this.DtaTrinhDoHocVan.DoubleBuffered = true;
            this.DtaTrinhDoHocVan.EnableHeadersVisualStyles = false;
            this.DtaTrinhDoHocVan.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaTrinhDoHocVan.HeaderForeColor = System.Drawing.Color.White;
            this.DtaTrinhDoHocVan.Location = new System.Drawing.Point(27, 42);
            this.DtaTrinhDoHocVan.Name = "DtaTrinhDoHocVan";
            this.DtaTrinhDoHocVan.ReadOnly = true;
            this.DtaTrinhDoHocVan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaTrinhDoHocVan.Size = new System.Drawing.Size(907, 604);
            this.DtaTrinhDoHocVan.TabIndex = 111;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soTietDataGridViewTextBoxColumn
            // 
            this.soTietDataGridViewTextBoxColumn.DataPropertyName = "SoTiet";
            this.soTietDataGridViewTextBoxColumn.HeaderText = "SoTiet";
            this.soTietDataGridViewTextBoxColumn.Name = "soTietDataGridViewTextBoxColumn";
            this.soTietDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maGiangDayDataGridViewTextBoxColumn
            // 
            this.maGiangDayDataGridViewTextBoxColumn.DataPropertyName = "MaGiangDay";
            this.maGiangDayDataGridViewTextBoxColumn.HeaderText = "MaGiangDay";
            this.maGiangDayDataGridViewTextBoxColumn.Name = "maGiangDayDataGridViewTextBoxColumn";
            this.maGiangDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Nam";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            this.namDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chiTietGiangDayBindingSource
            // 
            this.chiTietGiangDayBindingSource.DataMember = "ChiTietGiangDay";
            this.chiTietGiangDayBindingSource.DataSource = this.quanLyGiaoVienTieuHocDataSet1;
            // 
            // quanLyGiaoVienTieuHocDataSet1
            // 
            this.quanLyGiaoVienTieuHocDataSet1.DataSetName = "QuanLyGiaoVienTieuHocDataSet1";
            this.quanLyGiaoVienTieuHocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietGiangDayTableAdapter
            // 
            this.chiTietGiangDayTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.DtaTrinhDoHocVan);
            this.Name = "GUI_MonHoc";
            this.Size = new System.Drawing.Size(1336, 695);
            ((System.ComponentModel.ISupportInitialize)(this.DtaTrinhDoHocVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietGiangDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaoVienTieuHocDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtInp;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaTrinhDoHocVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietGiangDayBindingSource;
        private QuanLyGiaoVienTieuHocDataSet1 quanLyGiaoVienTieuHocDataSet1;
        private QuanLyGiaoVienTieuHocDataSet1TableAdapters.ChiTietGiangDayTableAdapter chiTietGiangDayTableAdapter;
    }
}
