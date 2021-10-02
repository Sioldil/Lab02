
namespace Lab02_T7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.BtnChia = new System.Windows.Forms.Button();
            this.BtnNhan = new System.Windows.Forms.Button();
            this.TxtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Máy tính đơn giản";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(105, 28);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(141, 20);
            this.TxtA.TabIndex = 4;
            this.TxtA.TextChanged += new System.EventHandler(this.TxtA_TextChanged);
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(105, 72);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(141, 20);
            this.TxtB.TabIndex = 5;
            this.TxtB.TextChanged += new System.EventHandler(this.TxtB_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Location = new System.Drawing.Point(223, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(202, 220);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 7;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(283, 220);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 23);
            this.btnTru.TabIndex = 8;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // BtnChia
            // 
            this.BtnChia.Location = new System.Drawing.Point(447, 220);
            this.BtnChia.Name = "BtnChia";
            this.BtnChia.Size = new System.Drawing.Size(75, 23);
            this.BtnChia.TabIndex = 10;
            this.BtnChia.Text = "Chia";
            this.BtnChia.UseVisualStyleBackColor = true;
            this.BtnChia.Click += new System.EventHandler(this.BtnChia_Click);
            // 
            // BtnNhan
            // 
            this.BtnNhan.Location = new System.Drawing.Point(366, 220);
            this.BtnNhan.Name = "BtnNhan";
            this.BtnNhan.Size = new System.Drawing.Size(75, 23);
            this.BtnNhan.TabIndex = 9;
            this.BtnNhan.Text = "Nhân";
            this.BtnNhan.UseVisualStyleBackColor = true;
            this.BtnNhan.Click += new System.EventHandler(this.BtnNhan_Click);
            // 
            // TxtKetqua
            // 
            this.TxtKetqua.Enabled = false;
            this.TxtKetqua.Location = new System.Drawing.Point(328, 268);
            this.TxtKetqua.Name = "TxtKetqua";
            this.TxtKetqua.Size = new System.Drawing.Size(141, 20);
            this.TxtKetqua.TabIndex = 11;
            this.TxtKetqua.TextChanged += new System.EventHandler(this.TxtKetqua_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 381);
            this.Controls.Add(this.TxtKetqua);
            this.Controls.Add(this.BtnChia);
            this.Controls.Add(this.BtnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button BtnChia;
        private System.Windows.Forms.Button BtnNhan;
        private System.Windows.Forms.TextBox TxtKetqua;
    }
}

