﻿namespace AppControlHoras.EmpleadosArea
{
    partial class EmpleadosArea
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosArea));
            this.PbCodice = new System.Windows.Forms.PictureBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAnadir = new System.Windows.Forms.Button();
            this.dgvEmpleadosArea = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosArea)).BeginInit();
            this.SuspendLayout();
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 21;
            this.PbCodice.TabStop = false;
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btVolver.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolver.Location = new System.Drawing.Point(692, 371);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 20;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Location = new System.Drawing.Point(223, 371);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 19;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Location = new System.Drawing.Point(131, 371);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 18;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAnadir
            // 
            this.btAnadir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnadir.Location = new System.Drawing.Point(38, 371);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 17;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = false;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // dgvEmpleadosArea
            // 
            this.dgvEmpleadosArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleadosArea.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvEmpleadosArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleadosArea.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleadosArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosArea.EnableHeadersVisualStyles = false;
            this.dgvEmpleadosArea.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvEmpleadosArea.Location = new System.Drawing.Point(37, 104);
            this.dgvEmpleadosArea.Name = "dgvEmpleadosArea";
            this.dgvEmpleadosArea.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvEmpleadosArea.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleadosArea.Size = new System.Drawing.Size(730, 244);
            this.dgvEmpleadosArea.TabIndex = 16;
            // 
            // EmpleadosArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.dgvEmpleadosArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpleadosArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpleadosArea";
            this.Load += new System.EventHandler(this.EmpleadosArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCodice;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.DataGridView dgvEmpleadosArea;
    }
}