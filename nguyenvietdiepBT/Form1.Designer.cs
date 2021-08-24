
namespace nguyenvietdiepBT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtDaySo = new System.Windows.Forms.TextBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTongchan = new System.Windows.Forms.TextBox();
            this.txtTongle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(522, 35);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(145, 38);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dãy vừa nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(33, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tổng các phần tử trong dãy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng chẵn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(437, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng lẻ";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(113, 47);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(368, 27);
            this.txtNhap.TabIndex = 11;
            // 
            // txtDaySo
            // 
            this.txtDaySo.Enabled = false;
            this.txtDaySo.Location = new System.Drawing.Point(139, 119);
            this.txtDaySo.Name = "txtDaySo";
            this.txtDaySo.Size = new System.Drawing.Size(371, 27);
            this.txtDaySo.TabIndex = 12;
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Location = new System.Drawing.Point(231, 192);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(122, 27);
            this.txtTong.TabIndex = 13;
            // 
            // txtTongchan
            // 
            this.txtTongchan.Enabled = false;
            this.txtTongchan.Location = new System.Drawing.Point(173, 268);
            this.txtTongchan.Name = "txtTongchan";
            this.txtTongchan.Size = new System.Drawing.Size(68, 27);
            this.txtTongchan.TabIndex = 14;
            this.txtTongchan.TextChanged += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtTongle
            // 
            this.txtTongle.Enabled = false;
            this.txtTongle.Location = new System.Drawing.Point(502, 268);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(72, 27);
            this.txtTongle.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtTongchan);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.txtDaySo);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtDaySo;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTongchan;
        private System.Windows.Forms.TextBox txtTongle;
    }
}

