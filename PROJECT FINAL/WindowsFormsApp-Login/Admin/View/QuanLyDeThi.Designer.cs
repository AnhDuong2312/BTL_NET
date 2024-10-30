namespace WindowsFormsApp_Login.Admin.View
{
    partial class QuanLyDeThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cB_tende = new RJCodeAdvance.RJControls.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listEx_table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cB_time = new System.Windows.Forms.ComboBox();
            this.cB_socau = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_deso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tim_kiemBtn = new RJCodeAdvance.RJControls.RJButton();
            this.refresh_btn = new RJCodeAdvance.RJControls.RJButton();
            this.BtnXoa = new RJCodeAdvance.RJControls.RJButton();
            this.BtnThem = new RJCodeAdvance.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.listEx_table)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_tende
            // 
            this.cB_tende.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cB_tende.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.cB_tende.BorderSize = 1;
            this.cB_tende.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cB_tende.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cB_tende.ForeColor = System.Drawing.Color.DimGray;
            this.cB_tende.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cB_tende.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cB_tende.ListTextColor = System.Drawing.Color.DimGray;
            this.cB_tende.Location = new System.Drawing.Point(194, 127);
            this.cB_tende.MinimumSize = new System.Drawing.Size(200, 30);
            this.cB_tende.Name = "cB_tende";
            this.cB_tende.Padding = new System.Windows.Forms.Padding(1);
            this.cB_tende.Size = new System.Drawing.Size(260, 30);
            this.cB_tende.TabIndex = 64;
            this.cB_tende.Texts = "Chọn đề thi";
            this.cB_tende.OnSelectedIndexChanged += new System.EventHandler(this.cB_tende_OnSelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(286, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 29);
            this.label7.TabIndex = 61;
            this.label7.Text = "DANH SÁCH ĐỀ THI";
            // 
            // listEx_table
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listEx_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listEx_table.BackgroundColor = System.Drawing.Color.White;
            this.listEx_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEx_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listEx_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listEx_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEx_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.NameExam,
            this.NumberExam,
            this.SoCau,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listEx_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.listEx_table.DoubleBuffered = true;
            this.listEx_table.EnableHeadersVisualStyles = false;
            this.listEx_table.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(39)))));
            this.listEx_table.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listEx_table.Location = new System.Drawing.Point(30, 329);
            this.listEx_table.Margin = new System.Windows.Forms.Padding(2);
            this.listEx_table.Name = "listEx_table";
            this.listEx_table.ReadOnly = true;
            this.listEx_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listEx_table.RowHeadersWidth = 51;
            this.listEx_table.RowTemplate.Height = 24;
            this.listEx_table.Size = new System.Drawing.Size(741, 211);
            this.listEx_table.TabIndex = 60;
            this.listEx_table.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listEx_table_CellMouseDoubleClick);
            this.listEx_table.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listEx_table_MouseClick_1);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.FillWeight = 50F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NameExam
            // 
            this.NameExam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameExam.FillWeight = 200F;
            this.NameExam.HeaderText = "Tên đề";
            this.NameExam.MinimumWidth = 6;
            this.NameExam.Name = "NameExam";
            this.NameExam.ReadOnly = true;
            // 
            // NumberExam
            // 
            this.NumberExam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumberExam.FillWeight = 60F;
            this.NumberExam.HeaderText = "Đề số";
            this.NumberExam.MinimumWidth = 6;
            this.NumberExam.Name = "NumberExam";
            this.NumberExam.ReadOnly = true;
            // 
            // SoCau
            // 
            this.SoCau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoCau.FillWeight = 60F;
            this.SoCau.HeaderText = "Số câu";
            this.SoCau.MinimumWidth = 6;
            this.SoCau.Name = "SoCau";
            this.SoCau.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thời gian";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cB_time
            // 
            this.cB_time.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_time.FormattingEnabled = true;
            this.cB_time.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "45",
            "90"});
            this.cB_time.Location = new System.Drawing.Point(378, 213);
            this.cB_time.Margin = new System.Windows.Forms.Padding(2);
            this.cB_time.Name = "cB_time";
            this.cB_time.Size = new System.Drawing.Size(76, 26);
            this.cB_time.TabIndex = 57;
            this.cB_time.Text = "10";
            // 
            // cB_socau
            // 
            this.cB_socau.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_socau.FormattingEnabled = true;
            this.cB_socau.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cB_socau.Location = new System.Drawing.Point(194, 213);
            this.cB_socau.Margin = new System.Windows.Forms.Padding(2);
            this.cB_socau.Name = "cB_socau";
            this.cB_socau.Size = new System.Drawing.Size(76, 26);
            this.cB_socau.TabIndex = 56;
            this.cB_socau.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Phút";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "Thời gian";
            // 
            // tB_deso
            // 
            this.tB_deso.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_deso.Location = new System.Drawing.Point(194, 174);
            this.tB_deso.Margin = new System.Windows.Forms.Padding(2);
            this.tB_deso.Name = "tB_deso";
            this.tB_deso.ReadOnly = true;
            this.tB_deso.Size = new System.Drawing.Size(260, 23);
            this.tB_deso.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Số câu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Đề số :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên đề :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 49;
            this.label1.Text = "THÔNG TIN ĐỀ THI";
            // 
            // tim_kiemBtn
            // 
            this.tim_kiemBtn.BackColor = System.Drawing.Color.SlateGray;
            this.tim_kiemBtn.BackgroundColor = System.Drawing.Color.SlateGray;
            this.tim_kiemBtn.BorderColor = System.Drawing.Color.DimGray;
            this.tim_kiemBtn.BorderRadius = 10;
            this.tim_kiemBtn.BorderSize = 2;
            this.tim_kiemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tim_kiemBtn.FlatAppearance.BorderSize = 0;
            this.tim_kiemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tim_kiemBtn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim_kiemBtn.ForeColor = System.Drawing.Color.White;
            this.tim_kiemBtn.Image = global::WindowsFormsApp_Login.Properties.Resources.search_alt_regular_241;
            this.tim_kiemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tim_kiemBtn.Location = new System.Drawing.Point(565, 185);
            this.tim_kiemBtn.Name = "tim_kiemBtn";
            this.tim_kiemBtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tim_kiemBtn.Size = new System.Drawing.Size(115, 32);
            this.tim_kiemBtn.TabIndex = 66;
            this.tim_kiemBtn.Text = "Tìm kiếm";
            this.tim_kiemBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tim_kiemBtn.TextColor = System.Drawing.Color.White;
            this.tim_kiemBtn.UseVisualStyleBackColor = false;
            this.tim_kiemBtn.Click += new System.EventHandler(this.tim_kiemBtn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.refresh_btn.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.refresh_btn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.refresh_btn.BorderRadius = 10;
            this.refresh_btn.BorderSize = 2;
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.FlatAppearance.BorderSize = 0;
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Image = global::WindowsFormsApp_Login.Properties.Resources.refresh_regular_24;
            this.refresh_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh_btn.Location = new System.Drawing.Point(565, 230);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.refresh_btn.Size = new System.Drawing.Size(115, 32);
            this.refresh_btn.TabIndex = 65;
            this.refresh_btn.Text = "Cập nhật";
            this.refresh_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh_btn.TextColor = System.Drawing.Color.White;
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.BtnXoa.BackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnXoa.BorderColor = System.Drawing.Color.Brown;
            this.BtnXoa.BorderRadius = 10;
            this.BtnXoa.BorderSize = 2;
            this.BtnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXoa.FlatAppearance.BorderSize = 0;
            this.BtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXoa.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.Color.White;
            this.BtnXoa.Image = global::WindowsFormsApp_Login.Properties.Resources.trash_solid_24;
            this.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXoa.Location = new System.Drawing.Point(565, 140);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnXoa.Size = new System.Drawing.Size(115, 32);
            this.BtnXoa.TabIndex = 63;
            this.BtnXoa.Text = "Xóa đề";
            this.BtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXoa.TextColor = System.Drawing.Color.White;
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.BtnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(185)))), ((int)(((byte)(142)))));
            this.BtnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(128)))), ((int)(((byte)(101)))));
            this.BtnThem.BorderRadius = 10;
            this.BtnThem.BorderSize = 2;
            this.BtnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnThem.FlatAppearance.BorderSize = 0;
            this.BtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnThem.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.Color.White;
            this.BtnThem.Image = global::WindowsFormsApp_Login.Properties.Resources.plus_circle_regular_24;
            this.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThem.Location = new System.Drawing.Point(565, 95);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnThem.Size = new System.Drawing.Size(115, 32);
            this.BtnThem.TabIndex = 62;
            this.BtnThem.Text = "Thêm đề";
            this.BtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnThem.TextColor = System.Drawing.Color.White;
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // QuanLyDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tim_kiemBtn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.cB_tende);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listEx_table);
            this.Controls.Add(this.cB_time);
            this.Controls.Add(this.cB_socau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tB_deso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDeThi";
            this.Size = new System.Drawing.Size(800, 597);
            ((System.ComponentModel.ISupportInitialize)(this.listEx_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJComboBox cB_tende;
        private RJCodeAdvance.RJControls.RJButton BtnXoa;
        private RJCodeAdvance.RJControls.RJButton BtnThem;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid listEx_table;
        private System.Windows.Forms.ComboBox cB_time;
        private System.Windows.Forms.ComboBox cB_socau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_deso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJButton refresh_btn;
        private RJCodeAdvance.RJControls.RJButton tim_kiemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
