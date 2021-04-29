
namespace DatabPBO
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNIK = new System.Windows.Forms.TextBox();
            this.tbJK = new System.Windows.Forms.TextBox();
            this.tbJT = new System.Windows.Forms.TextBox();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pendaftaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jenis Kelamin :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Tes :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(145, 111);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(222, 26);
            this.tbNama.TabIndex = 5;
            // 
            // tbNIK
            // 
            this.tbNIK.Location = new System.Drawing.Point(145, 180);
            this.tbNIK.Name = "tbNIK";
            this.tbNIK.Size = new System.Drawing.Size(222, 26);
            this.tbNIK.TabIndex = 6;
            // 
            // tbJK
            // 
            this.tbJK.Location = new System.Drawing.Point(145, 256);
            this.tbJK.Name = "tbJK";
            this.tbJK.Size = new System.Drawing.Size(222, 26);
            this.tbJK.TabIndex = 7;
            // 
            // tbJT
            // 
            this.tbJT.Location = new System.Drawing.Point(144, 328);
            this.tbJT.Name = "tbJT";
            this.tbJT.Size = new System.Drawing.Size(222, 26);
            this.tbJT.TabIndex = 8;
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(292, 386);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(75, 40);
            this.btnDaftar.TabIndex = 9;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.tbJT);
            this.Controls.Add(this.tbJK);
            this.Controls.Add(this.tbNIK);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNIK;
        private System.Windows.Forms.TextBox tbJK;
        private System.Windows.Forms.TextBox tbJT;
        private System.Windows.Forms.Button btnDaftar;
    }
}