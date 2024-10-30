namespace WindowsFormsApp_Login.Admin.View
{
    partial class AddOption
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
            this.backbtn = new System.Windows.Forms.Button();
            this.btn_import = new RJCodeAdvance.RJControls.RJButton();
            this.btn_thucong = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbtn.Image = global::WindowsFormsApp_Login.Properties.Resources.left_arrow_circle_solid_24;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 44);
            this.backbtn.TabIndex = 42;
            this.backbtn.Text = "Quay lại";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btn_import
            // 
            this.btn_import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_import.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_import.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_import.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_import.BorderRadius = 0;
            this.btn_import.BorderSize = 0;
            this.btn_import.FlatAppearance.BorderSize = 0;
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.ForeColor = System.Drawing.Color.White;
            this.btn_import.Location = new System.Drawing.Point(152, 182);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(150, 38);
            this.btn_import.TabIndex = 44;
            this.btn_import.Text = "IMPORT FILE";
            this.btn_import.TextColor = System.Drawing.Color.White;
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_thucong
            // 
            this.btn_thucong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_thucong.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_thucong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_thucong.BorderRadius = 0;
            this.btn_thucong.BorderSize = 0;
            this.btn_thucong.FlatAppearance.BorderSize = 0;
            this.btn_thucong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thucong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thucong.ForeColor = System.Drawing.Color.White;
            this.btn_thucong.Location = new System.Drawing.Point(152, 101);
            this.btn_thucong.Name = "btn_thucong";
            this.btn_thucong.Size = new System.Drawing.Size(150, 40);
            this.btn_thucong.TabIndex = 43;
            this.btn_thucong.Text = "THỦ CÔNG";
            this.btn_thucong.TextColor = System.Drawing.Color.White;
            this.btn_thucong.UseVisualStyleBackColor = false;
            this.btn_thucong.Click += new System.EventHandler(this.btn_thucong_Click);
            // 
            // AddOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_thucong);
            this.Controls.Add(this.backbtn);
            this.Name = "AddOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private RJCodeAdvance.RJControls.RJButton btn_import;
        private RJCodeAdvance.RJControls.RJButton btn_thucong;
    }
}