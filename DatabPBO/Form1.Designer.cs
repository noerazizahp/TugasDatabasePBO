
namespace DatabPBO
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
            this.btnIsi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblJEK = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblJET = new System.Windows.Forms.Label();
            this.tbNP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Antrian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIsi
            // 
            this.btnIsi.Location = new System.Drawing.Point(131, 382);
            this.btnIsi.Name = "btnIsi";
            this.btnIsi.Size = new System.Drawing.Size(98, 42);
            this.btnIsi.TabIndex = 3;
            this.btnIsi.Text = "Isi Data";
            this.btnIsi.UseVisualStyleBackColor = true;
            this.btnIsi.Click += new System.EventHandler(this.btnIsi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cetak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(74, 233);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "//";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(308, 233);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 19);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "-";
            // 
            // lblJEK
            // 
            this.lblJEK.AutoSize = true;
            this.lblJEK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJEK.Location = new System.Drawing.Point(74, 289);
            this.lblJEK.Name = "lblJEK";
            this.lblJEK.Size = new System.Drawing.Size(15, 20);
            this.lblJEK.TabIndex = 8;
            this.lblJEK.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "//";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblJET
            // 
            this.lblJET.AutoSize = true;
            this.lblJET.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJET.Location = new System.Drawing.Point(308, 289);
            this.lblJET.Name = "lblJET";
            this.lblJET.Size = new System.Drawing.Size(15, 20);
            this.lblJET.TabIndex = 10;
            this.lblJET.Text = "-";
            // 
            // tbNP
            // 
            this.tbNP.Location = new System.Drawing.Point(108, 99);
            this.tbNP.Name = "tbNP";
            this.tbNP.Size = new System.Drawing.Size(214, 26);
            this.tbNP.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.tbNP);
            this.Controls.Add(this.lblJET);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblJEK);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIsi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblJEK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblJET;
        private System.Windows.Forms.TextBox tbNP;
    }
}

