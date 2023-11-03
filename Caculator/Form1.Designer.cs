namespace Caculator
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.btTru = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "số B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(142, 34);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(181, 20);
            this.txtA.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(142, 86);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(181, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.AutoSize = true;
            this.txtKQ.Location = new System.Drawing.Point(32, 146);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(44, 13);
            this.txtKQ.TabIndex = 0;
            this.txtKQ.Text = "Kết quả";
            this.txtKQ.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(142, 143);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(181, 20);
            this.txt.TabIndex = 1;
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(322, 211);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(59, 40);
            this.btTru.TabIndex = 2;
            this.btTru.Text = "Trừ";
            this.btTru.UseVisualStyleBackColor = true;
            
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(197, 211);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(59, 40);
            this.btCong.TabIndex = 2;
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 339);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtKQ);
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
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label txtKQ;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btCong;
    }
}

