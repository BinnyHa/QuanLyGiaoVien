namespace QUANLYGIAOVIEN.GUI
{
    partial class GUI_ChiTietGiangDay
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
            this.DtaChitietgiangday = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGiangDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietGiangDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaoVienTieuHocDataSet2 = new QUANLYGIAOVIEN.QuanLyGiaoVienTieuHocDataSet2();
            this.chiTietGiangDayTableAdapter = new QUANLYGIAOVIEN.QuanLyGiaoVienTieuHocDataSet2TableAdapters.ChiTietGiangDayTableAdapter();
            this.btnsearch = new System.Windows.Forms.Label();
            this.btnTimkiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtInp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtaChitietgiangday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietGiangDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaoVienTieuHocDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // DtaChitietgiangday
            // 
            this.DtaChitietgiangday.AllowUserToAddRows = false;
            this.DtaChitietgiangday.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DtaChitietgiangday.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtaChitietgiangday.AutoGenerateColumns = false;
            this.DtaChitietgiangday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtaChitietgiangday.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DtaChitietgiangday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtaChitietgiangday.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtaChitietgiangday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtaChitietgiangday.ColumnHeadersHeight = 25;
            this.DtaChitietgiangday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn,
            this.soTietDataGridViewTextBoxColumn,
            this.maGiangDayDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn});
            this.DtaChitietgiangday.DataSource = this.chiTietGiangDayBindingSource;
            this.DtaChitietgiangday.DoubleBuffered = true;
            this.DtaChitietgiangday.EnableHeadersVisualStyles = false;
            this.DtaChitietgiangday.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DtaChitietgiangday.HeaderForeColor = System.Drawing.Color.White;
            this.DtaChitietgiangday.Location = new System.Drawing.Point(35, 73);
            this.DtaChitietgiangday.Name = "DtaChitietgiangday";
            this.DtaChitietgiangday.ReadOnly = true;
            this.DtaChitietgiangday.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtaChitietgiangday.Size = new System.Drawing.Size(1194, 604);
            this.DtaChitietgiangday.TabIndex = 112;
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
            this.chiTietGiangDayBindingSource.DataSource = this.quanLyGiaoVienTieuHocDataSet2;
            // 
            // quanLyGiaoVienTieuHocDataSet2
            // 
            this.quanLyGiaoVienTieuHocDataSet2.DataSetName = "QuanLyGiaoVienTieuHocDataSet2";
            this.quanLyGiaoVienTieuHocDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietGiangDayTableAdapter
            // 
            this.chiTietGiangDayTableAdapter.ClearBeforeFill = true;
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.Location = new System.Drawing.Point(884, 37);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(49, 13);
            this.btnsearch.TabIndex = 120;
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
            this.btnTimkiem.Location = new System.Drawing.Point(1194, 30);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimkiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimkiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimkiem.selected = false;
            this.btnTimkiem.Size = new System.Drawing.Size(107, 20);
            this.btnTimkiem.TabIndex = 121;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Textcolor = System.Drawing.Color.White;
            this.btnTimkiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtInp
            // 
            this.txtInp.Location = new System.Drawing.Point(970, 30);
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(199, 20);
            this.txtInp.TabIndex = 119;
            // 
            // GUI_ChiTietGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.DtaChitietgiangday);
            this.Name = "GUI_ChiTietGiangDay";
            this.Size = new System.Drawing.Size(1336, 695);
            this.Load += new System.EventHandler(this.GUI_ChiTietGiangDay_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DtaChitietgiangday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietGiangDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaoVienTieuHocDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DtaChitietgiangday;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGiangDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chiTietGiangDayBindingSource;
        private QuanLyGiaoVienTieuHocDataSet2 quanLyGiaoVienTieuHocDataSet2;
        private QuanLyGiaoVienTieuHocDataSet2TableAdapters.ChiTietGiangDayTableAdapter chiTietGiangDayTableAdapter;
        private System.Windows.Forms.Label btnsearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimkiem;
        private System.Windows.Forms.TextBox txtInp;
    }
}
