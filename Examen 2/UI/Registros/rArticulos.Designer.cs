namespace Examen_2.UI.Registros
{
    partial class rArticulos
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
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.InventariotextBox = new System.Windows.Forms.TextBox();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GanancianumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GanancianumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Examen_2.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(375, 255);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(66, 56);
            this.Eliminarbutton.TabIndex = 31;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Examen_2.Properties.Resources.icons8_Save_as_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(275, 255);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(66, 56);
            this.Guardarbutton.TabIndex = 30;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Examen_2.Properties.Resources.icons8_Add_File_32;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(173, 255);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(66, 56);
            this.Nuevobutton.TabIndex = 29;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Examen_2.Properties.Resources.icons8_Search_Property_16;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(275, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 28;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // InventariotextBox
            // 
            this.InventariotextBox.Location = new System.Drawing.Point(338, 207);
            this.InventariotextBox.Name = "InventariotextBox";
            this.InventariotextBox.Size = new System.Drawing.Size(120, 20);
            this.InventariotextBox.TabIndex = 27;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(103, 205);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecionumericUpDown.TabIndex = 26;
            this.PrecionumericUpDown.ValueChanged += new System.EventHandler(this.PrecionumericUpDown_ValueChanged);
            // 
            // CostonumericUpDown
            // 
            this.CostonumericUpDown.Location = new System.Drawing.Point(103, 137);
            this.CostonumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.CostonumericUpDown.Name = "CostonumericUpDown";
            this.CostonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CostonumericUpDown.TabIndex = 25;
            this.CostonumericUpDown.ValueChanged += new System.EventHandler(this.CostonumericUpDown_ValueChanged);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(103, 82);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(120, 20);
            this.DescripciontextBox.TabIndex = 24;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(103, 32);
            this.IdnumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdnumericUpDown.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ganancia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ArticuloId";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GanancianumericUpDown
            // 
            this.GanancianumericUpDown.Location = new System.Drawing.Point(338, 131);
            this.GanancianumericUpDown.Name = "GanancianumericUpDown";
            this.GanancianumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.GanancianumericUpDown.TabIndex = 32;
            this.GanancianumericUpDown.ValueChanged += new System.EventHandler(this.GanancianumericUpDown_ValueChanged);
            // 
            // rArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(489, 341);
            this.Controls.Add(this.GanancianumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.InventariotextBox);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.CostonumericUpDown);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(505, 380);
            this.MinimumSize = new System.Drawing.Size(505, 380);
            this.Name = "rArticulos";
            this.Text = "Registro de Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GanancianumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox InventariotextBox;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.NumericUpDown CostonumericUpDown;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown GanancianumericUpDown;
    }
}