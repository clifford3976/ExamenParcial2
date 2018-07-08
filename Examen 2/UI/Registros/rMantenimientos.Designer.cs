namespace Examen_2.UI.Registros
{
    partial class rMantenimientos
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CantidadnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ArticuloscomboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TallercomboBox = new System.Windows.Forms.ComboBox();
            this.VehiculocomboBox = new System.Windows.Forms.ComboBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProximaFechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.ImportetextBox = new System.Windows.Forms.TextBox();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.ITBIStextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 425);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "ITBIS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Sub-Total";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(26, 206);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(752, 150);
            this.DetalledataGridView.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Importe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Precio";
            // 
            // CantidadnumericUpDown
            // 
            this.CantidadnumericUpDown.Location = new System.Drawing.Point(173, 179);
            this.CantidadnumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CantidadnumericUpDown.Name = "CantidadnumericUpDown";
            this.CantidadnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CantidadnumericUpDown.TabIndex = 47;
            this.CantidadnumericUpDown.ValueChanged += new System.EventHandler(this.CantidadnumericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cantidad";
            // 
            // ArticuloscomboBox
            // 
            this.ArticuloscomboBox.FormattingEnabled = true;
            this.ArticuloscomboBox.Location = new System.Drawing.Point(26, 179);
            this.ArticuloscomboBox.Name = "ArticuloscomboBox";
            this.ArticuloscomboBox.Size = new System.Drawing.Size(121, 21);
            this.ArticuloscomboBox.TabIndex = 45;
            this.ArticuloscomboBox.SelectedIndexChanged += new System.EventHandler(this.ArticuloscomboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Articulos";
            // 
            // TallercomboBox
            // 
            this.TallercomboBox.FormattingEnabled = true;
            this.TallercomboBox.Location = new System.Drawing.Point(126, 125);
            this.TallercomboBox.Name = "TallercomboBox";
            this.TallercomboBox.Size = new System.Drawing.Size(120, 21);
            this.TallercomboBox.TabIndex = 43;
            // 
            // VehiculocomboBox
            // 
            this.VehiculocomboBox.FormattingEnabled = true;
            this.VehiculocomboBox.Location = new System.Drawing.Point(126, 86);
            this.VehiculocomboBox.Name = "VehiculocomboBox";
            this.VehiculocomboBox.Size = new System.Drawing.Size(120, 21);
            this.VehiculocomboBox.TabIndex = 42;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(126, 17);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdnumericUpDown.TabIndex = 40;
            // 
            // ProximaFechadateTimePicker
            // 
            this.ProximaFechadateTimePicker.CustomFormat = "dd/MM/yy";
            this.ProximaFechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ProximaFechadateTimePicker.Location = new System.Drawing.Point(425, 55);
            this.ProximaFechadateTimePicker.Name = "ProximaFechadateTimePicker";
            this.ProximaFechadateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.ProximaFechadateTimePicker.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "ProximaFecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(126, 53);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechadateTimePicker.TabIndex = 37;
            this.FechadateTimePicker.ValueChanged += new System.EventHandler(this.FechadateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Taller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "MantenimientoId";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(319, 180);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox.TabIndex = 60;
            // 
            // ImportetextBox
            // 
            this.ImportetextBox.Location = new System.Drawing.Point(449, 180);
            this.ImportetextBox.Name = "ImportetextBox";
            this.ImportetextBox.Size = new System.Drawing.Size(100, 20);
            this.ImportetextBox.TabIndex = 61;
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Location = new System.Drawing.Point(102, 366);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.SubtotaltextBox.TabIndex = 62;
            // 
            // ITBIStextBox
            // 
            this.ITBIStextBox.Location = new System.Drawing.Point(102, 392);
            this.ITBIStextBox.Name = "ITBIStextBox";
            this.ITBIStextBox.Size = new System.Drawing.Size(100, 20);
            this.ITBIStextBox.TabIndex = 63;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(102, 418);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 64;
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::Examen_2.Properties.Resources.icons8_Delete_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Removerbutton.Location = new System.Drawing.Point(703, 155);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(75, 50);
            this.Removerbutton.TabIndex = 65;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Examen_2.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(594, 371);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(73, 62);
            this.Eliminarbutton.TabIndex = 59;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Examen_2.Properties.Resources.icons8_Save_as_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(488, 373);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(73, 62);
            this.Guardarbutton.TabIndex = 58;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Examen_2.Properties.Resources.icons8_Add_File_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(380, 373);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(73, 62);
            this.Nuevobutton.TabIndex = 57;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::Examen_2.Properties.Resources.icons8_Add_File_16;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(567, 176);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 23);
            this.Agregarbutton.TabIndex = 52;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Examen_2.Properties.Resources.icons8_Search_Property_16;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(264, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 41;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.ITBIStextBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.ImportetextBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CantidadnumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ArticuloscomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TallercomboBox);
            this.Controls.Add(this.VehiculocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.ProximaFechadateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rMantenimientos";
            this.Text = "Registro de Mantenimientos";
            this.Load += new System.EventHandler(this.rMantenimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox ITBIStextBox;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.TextBox ImportetextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CantidadnumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ArticuloscomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TallercomboBox;
        private System.Windows.Forms.ComboBox VehiculocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.DateTimePicker ProximaFechadateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Removerbutton;
    }
}