namespace W7
{
    partial class FormW7
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
            this.lbMasukkanKalimat = new System.Windows.Forms.Label();
            this.lbMasukkanHuruf = new System.Windows.Forms.Label();
            this.tbInputKalimat = new System.Windows.Forms.TextBox();
            this.tbInputHuruf1 = new System.Windows.Forms.TextBox();
            this.lbMenjadi = new System.Windows.Forms.Label();
            this.tbInputHuruf2 = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.lbHasil = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMasukkanKalimat
            // 
            this.lbMasukkanKalimat.AutoSize = true;
            this.lbMasukkanKalimat.Location = new System.Drawing.Point(46, 34);
            this.lbMasukkanKalimat.Name = "lbMasukkanKalimat";
            this.lbMasukkanKalimat.Size = new System.Drawing.Size(104, 15);
            this.lbMasukkanKalimat.TabIndex = 0;
            this.lbMasukkanKalimat.Text = "Masukkan Kalimat";
            // 
            // lbMasukkanHuruf
            // 
            this.lbMasukkanHuruf.AutoSize = true;
            this.lbMasukkanHuruf.Location = new System.Drawing.Point(55, 71);
            this.lbMasukkanHuruf.Name = "lbMasukkanHuruf";
            this.lbMasukkanHuruf.Size = new System.Drawing.Size(95, 15);
            this.lbMasukkanHuruf.TabIndex = 1;
            this.lbMasukkanHuruf.Text = "Masukkan Huruf";
            // 
            // tbInputKalimat
            // 
            this.tbInputKalimat.Location = new System.Drawing.Point(156, 26);
            this.tbInputKalimat.Name = "tbInputKalimat";
            this.tbInputKalimat.Size = new System.Drawing.Size(281, 23);
            this.tbInputKalimat.TabIndex = 2;
            this.tbInputKalimat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputKalimat_KeyPress);
            // 
            // tbInputHuruf1
            // 
            this.tbInputHuruf1.Location = new System.Drawing.Point(156, 63);
            this.tbInputHuruf1.Name = "tbInputHuruf1";
            this.tbInputHuruf1.Size = new System.Drawing.Size(100, 23);
            this.tbInputHuruf1.TabIndex = 3;
            this.tbInputHuruf1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputHuruf1_KeyPress);
            // 
            // lbMenjadi
            // 
            this.lbMenjadi.AutoSize = true;
            this.lbMenjadi.Location = new System.Drawing.Point(279, 71);
            this.lbMenjadi.Name = "lbMenjadi";
            this.lbMenjadi.Size = new System.Drawing.Size(50, 15);
            this.lbMenjadi.TabIndex = 4;
            this.lbMenjadi.Text = "Menjadi";
            // 
            // tbInputHuruf2
            // 
            this.tbInputHuruf2.Location = new System.Drawing.Point(337, 63);
            this.tbInputHuruf2.Name = "tbInputHuruf2";
            this.tbInputHuruf2.Size = new System.Drawing.Size(100, 23);
            this.tbInputHuruf2.TabIndex = 5;
            this.tbInputHuruf2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInputHuruf2_KeyPress);
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(156, 109);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(281, 23);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi!";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // lbHasil
            // 
            this.lbHasil.AutoSize = true;
            this.lbHasil.Location = new System.Drawing.Point(117, 161);
            this.lbHasil.Name = "lbHasil";
            this.lbHasil.Size = new System.Drawing.Size(33, 15);
            this.lbHasil.TabIndex = 8;
            this.lbHasil.Text = "Hasil";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(156, 161);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(38, 15);
            this.lbOutput.TabIndex = 9;
            this.lbOutput.Text = "label6";
            // 
            // FormW7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 240);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lbHasil);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.tbInputHuruf2);
            this.Controls.Add(this.lbMenjadi);
            this.Controls.Add(this.tbInputHuruf1);
            this.Controls.Add(this.tbInputKalimat);
            this.Controls.Add(this.lbMasukkanHuruf);
            this.Controls.Add(this.lbMasukkanKalimat);
            this.Name = "FormW7";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMasukkanKalimat;
        private Label lbMasukkanHuruf;
        private TextBox tbInputKalimat;
        private TextBox tbInputHuruf1;
        private Label lbMenjadi;
        private TextBox tbInputHuruf2;
        private Button btnKonversi;
        private Label lbHasil;
        private Label lbOutput;
    }
}