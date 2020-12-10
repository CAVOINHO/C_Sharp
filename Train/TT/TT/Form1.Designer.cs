namespace TT
{
    partial class Form1
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtTongTienPT = new System.Windows.Forms.TextBox();
            this.txtTongTienVAT = new System.Windows.Forms.TextBox();
            this.txtTongTienSD = new System.Windows.Forms.TextBox();
            this.txtVuotDinhMuc = new System.Windows.Forms.TextBox();
            this.txtTrongDinhMuc = new System.Windows.Forms.TextBox();
            this.txtTongSoMetKhoiSD = new System.Windows.Forms.TextBox();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.txtSoNhanKhau = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(515, 192);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(300, 200);
            this.txtKQ.TabIndex = 56;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Yellow;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(396, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 55;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Cyan;
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIn.Location = new System.Drawing.Point(181, 431);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 34);
            this.btnIn.TabIndex = 54;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Location = new System.Drawing.Point(288, 431);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 53;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTinh.Location = new System.Drawing.Point(76, 431);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 34);
            this.btnTinh.TabIndex = 52;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtTongTienPT
            // 
            this.txtTongTienPT.Location = new System.Drawing.Point(227, 372);
            this.txtTongTienPT.Name = "txtTongTienPT";
            this.txtTongTienPT.Size = new System.Drawing.Size(245, 20);
            this.txtTongTienPT.TabIndex = 51;
            // 
            // txtTongTienVAT
            // 
            this.txtTongTienVAT.Location = new System.Drawing.Point(227, 339);
            this.txtTongTienVAT.Name = "txtTongTienVAT";
            this.txtTongTienVAT.Size = new System.Drawing.Size(245, 20);
            this.txtTongTienVAT.TabIndex = 50;
            // 
            // txtTongTienSD
            // 
            this.txtTongTienSD.Location = new System.Drawing.Point(227, 303);
            this.txtTongTienSD.Name = "txtTongTienSD";
            this.txtTongTienSD.Size = new System.Drawing.Size(245, 20);
            this.txtTongTienSD.TabIndex = 49;
            // 
            // txtVuotDinhMuc
            // 
            this.txtVuotDinhMuc.Location = new System.Drawing.Point(227, 258);
            this.txtVuotDinhMuc.Name = "txtVuotDinhMuc";
            this.txtVuotDinhMuc.Size = new System.Drawing.Size(101, 20);
            this.txtVuotDinhMuc.TabIndex = 48;
            // 
            // txtTrongDinhMuc
            // 
            this.txtTrongDinhMuc.Location = new System.Drawing.Point(227, 226);
            this.txtTrongDinhMuc.Name = "txtTrongDinhMuc";
            this.txtTrongDinhMuc.Size = new System.Drawing.Size(101, 20);
            this.txtTrongDinhMuc.TabIndex = 47;
            // 
            // txtTongSoMetKhoiSD
            // 
            this.txtTongSoMetKhoiSD.Location = new System.Drawing.Point(227, 191);
            this.txtTongSoMetKhoiSD.Name = "txtTongSoMetKhoiSD";
            this.txtTongSoMetKhoiSD.Size = new System.Drawing.Size(101, 20);
            this.txtTongSoMetKhoiSD.TabIndex = 46;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Location = new System.Drawing.Point(371, 138);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(101, 20);
            this.txtChiSoMoi.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(290, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 15);
            this.label13.TabIndex = 44;
            this.label13.Text = "Chỉ số mới";
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Location = new System.Drawing.Point(123, 135);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Size = new System.Drawing.Size(101, 20);
            this.txtChiSoCu.TabIndex = 43;
            // 
            // txtSoNhanKhau
            // 
            this.txtSoNhanKhau.Location = new System.Drawing.Point(123, 100);
            this.txtSoNhanKhau.Name = "txtSoNhanKhau";
            this.txtSoNhanKhau.Size = new System.Drawing.Size(101, 20);
            this.txtSoNhanKhau.TabIndex = 42;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(123, 64);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(349, 20);
            this.txtHoTenKH.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(512, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 15);
            this.label12.TabIndex = 40;
            this.label12.Text = "Vượt định mức: 8000đ/1 mét khối";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(512, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 15);
            this.label11.TabIndex = 39;
            this.label11.Text = "Trong định mức: 4000đ/1 mét khối";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tổng tiền phải trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "VAT 10%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tổng tiền sử dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Số mét khối vượt quá định mức";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Số mét khối trong định mức";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tổng số mét khối sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chỉ số cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số nhân khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tính Tiền Nước Hàng Tháng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 484);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtTongTienPT);
            this.Controls.Add(this.txtTongTienVAT);
            this.Controls.Add(this.txtTongTienSD);
            this.Controls.Add(this.txtVuotDinhMuc);
            this.Controls.Add(this.txtTrongDinhMuc);
            this.Controls.Add(this.txtTongSoMetKhoiSD);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.txtSoNhanKhau);
            this.Controls.Add(this.txtHoTenKH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtTongTienPT;
        private System.Windows.Forms.TextBox txtTongTienVAT;
        private System.Windows.Forms.TextBox txtTongTienSD;
        private System.Windows.Forms.TextBox txtVuotDinhMuc;
        private System.Windows.Forms.TextBox txtTrongDinhMuc;
        private System.Windows.Forms.TextBox txtTongSoMetKhoiSD;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.TextBox txtSoNhanKhau;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

