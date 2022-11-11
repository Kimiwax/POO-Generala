namespace Generala_KevinArias
{
    partial class ShowDialogGanaste
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_ganaste = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.picB_Ganaste = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Ganaste)).BeginInit();
            this.SuspendLayout();
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
            this.btn_ok.Location = new System.Drawing.Point(229, 214);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(185, 40);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Cerrar";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            this.btn_ok.MouseEnter += new System.EventHandler(this.btn_ok_MouseEnter);
            this.btn_ok.MouseLeave += new System.EventHandler(this.btn_ok_MouseLeave);
            // 
            // lbl_ganaste
            // 
            this.lbl_ganaste.AutoSize = true;
            this.lbl_ganaste.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ganaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ganaste.Font = new System.Drawing.Font("Cyberpunk", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ganaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(18)))));
            this.lbl_ganaste.Location = new System.Drawing.Point(95, 14);
            this.lbl_ganaste.Name = "lbl_ganaste";
            this.lbl_ganaste.Size = new System.Drawing.Size(474, 75);
            this.lbl_ganaste.TabIndex = 2;
            this.lbl_ganaste.Text = "GANASTE";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nombre.Font = new System.Drawing.Font("Cyberpunk", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(18)))));
            this.lbl_nombre.Location = new System.Drawing.Point(144, 89);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(358, 51);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picB_Ganaste
            // 
            this.picB_Ganaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_Ganaste.Image = global::Generala_KevinArias.Properties.Resources.tumblr_macp0x0NFO1r8rjf0o1_500;
            this.picB_Ganaste.Location = new System.Drawing.Point(0, 0);
            this.picB_Ganaste.Name = "picB_Ganaste";
            this.picB_Ganaste.Size = new System.Drawing.Size(665, 261);
            this.picB_Ganaste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB_Ganaste.TabIndex = 0;
            this.picB_Ganaste.TabStop = false;
            // 
            // ShowDialogGanaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 261);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_ganaste);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.picB_Ganaste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowDialogGanaste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDialogGanaste";
            ((System.ComponentModel.ISupportInitialize)(this.picB_Ganaste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picB_Ganaste;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_ganaste;
        private System.Windows.Forms.Label lbl_nombre;

    }
}