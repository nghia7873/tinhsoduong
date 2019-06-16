namespace Baitapsoduong
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
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.btn_Cong = new System.Windows.Forms.Button();
            this.btn_Tru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÉP TÍNH SỐ DƯƠNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(155, 58);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOne.TabIndex = 3;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(155, 115);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNumberTwo.TabIndex = 4;
            
            // 
            // btn_Cong
            // 
            this.btn_Cong.Location = new System.Drawing.Point(28, 173);
            this.btn_Cong.Name = "btn_Cong";
            this.btn_Cong.Size = new System.Drawing.Size(75, 23);
            this.btn_Cong.TabIndex = 5;
            this.btn_Cong.Text = "Cộng";
            this.btn_Cong.UseVisualStyleBackColor = true;
            this.btn_Cong.Click += new System.EventHandler(this.btn_Cong_Click);
            // 
            // btn_Tru
            // 
            this.btn_Tru.Location = new System.Drawing.Point(145, 172);
            this.btn_Tru.Name = "btn_Tru";
            this.btn_Tru.Size = new System.Drawing.Size(75, 23);
            this.btn_Tru.TabIndex = 6;
            this.btn_Tru.Text = "Trừ";
            this.btn_Tru.UseVisualStyleBackColor = true;
            this.btn_Tru.Click += new System.EventHandler(this.btn_Tru_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(264, 172);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(386, 172);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 8;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(152, 156);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(357, 233);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 274);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btn_Tru);
            this.Controls.Add(this.btn_Cong);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Button btn_Cong;
        private System.Windows.Forms.Button btn_Tru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button btnThoat;
    }
}

