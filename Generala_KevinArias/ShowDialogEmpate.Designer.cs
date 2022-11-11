namespace Generala_KevinArias
{
    partial class ShowDialogEmpate
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
            this.picB_Empate = new System.Windows.Forms.PictureBox();
            this.lbl_empate = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Empate)).BeginInit();
            this.SuspendLayout();
            // 
            // picB_Empate
            // 
            this.picB_Empate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_Empate.Image = global::Generala_KevinArias.Properties.Resources.tumblr_macp0x0NFO1r8rjf0o1_500;
            this.picB_Empate.Location = new System.Drawing.Point(0, 0);
            this.picB_Empate.Name = "picB_Empate";
            this.picB_Empate.Size = new System.Drawing.Size(649, 222);
            this.picB_Empate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_Empate.TabIndex = 1;
            this.picB_Empate.TabStop = false;
            // 
            // lbl_empate
            // 
            this.lbl_empate.AutoSize = true;
            this.lbl_empate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_empate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_empate.Font = new System.Drawing.Font("Cyberpunk", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(18)))));
            this.lbl_empate.Location = new System.Drawing.Point(88, 34);
            this.lbl_empate.Name = "lbl_empate";
            this.lbl_empate.Size = new System.Drawing.Size(450, 75);
            this.lbl_empate.TabIndex = 4;
            this.lbl_empate.Text = "EMPATE";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(36)))), ((int)(((byte)(175)))));
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Cyberpunk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(18)))));
            this.btn_ok.Location = new System.Drawing.Point(224, 170);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(185, 40);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Cerrar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            this.btn_ok.MouseEnter += new System.EventHandler(this.btn_ok_MouseEnter);
            this.btn_ok.MouseLeave += new System.EventHandler(this.btn_ok_MouseLeave);
            // 
            // ShowDialogEmpate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 222);
            this.Controls.Add(this.lbl_empate);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.picB_Empate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDialogEmpate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDialogEmpate";
            ((System.ComponentModel.ISupportInitialize)(this.picB_Empate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picB_Empate;
        private System.Windows.Forms.Label lbl_empate;
        private System.Windows.Forms.Button btn_ok;
    }
}