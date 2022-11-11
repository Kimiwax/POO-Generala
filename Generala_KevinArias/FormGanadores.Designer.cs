namespace Generala_KevinArias
{
    partial class FormGanadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_atras = new System.Windows.Forms.Button();
            this.dgv_ganadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ganadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.Transparent;
            this.btn_atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(36)))), ((int)(((byte)(175)))));
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Font = new System.Drawing.Font("Cyberpunk", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(18)))));
            this.btn_atras.Location = new System.Drawing.Point(12, 587);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(185, 40);
            this.btn_atras.TabIndex = 0;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.button1_Click);
            this.btn_atras.MouseEnter += new System.EventHandler(this.btn_atras_MouseEnter);
            this.btn_atras.MouseLeave += new System.EventHandler(this.btn_atras_MouseLeave);
            // 
            // dgv_ganadores
            // 
            this.dgv_ganadores.AllowUserToAddRows = false;
            this.dgv_ganadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Cyberpunk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            this.dgv_ganadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_ganadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ganadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ganadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ganadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            this.dgv_ganadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ganadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_ganadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Cyberpunk", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(55)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ganadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv_ganadores.ColumnHeadersHeight = 50;
            this.dgv_ganadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ganadores.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgv_ganadores.Enabled = false;
            this.dgv_ganadores.EnableHeadersVisualStyles = false;
            this.dgv_ganadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.dgv_ganadores.Location = new System.Drawing.Point(131, 24);
            this.dgv_ganadores.Name = "dgv_ganadores";
            this.dgv_ganadores.ReadOnly = true;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Cyberpunk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ganadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgv_ganadores.RowHeadersVisible = false;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Cyberpunk", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_ganadores.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.dgv_ganadores.Size = new System.Drawing.Size(643, 529);
            this.dgv_ganadores.TabIndex = 1;
            // 
            // FormGanadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(12)))), ((int)(((byte)(42)))));
            this.BackgroundImage = global::Generala_KevinArias.Properties.Resources.fondopuntaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 639);
            this.Controls.Add(this.dgv_ganadores);
            this.Controls.Add(this.btn_atras);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGanadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGanadores";
            this.Load += new System.EventHandler(this.FormGanadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ganadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.DataGridView dgv_ganadores;
    }
}