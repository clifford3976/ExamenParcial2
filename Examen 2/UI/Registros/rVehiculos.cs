using Examen_2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen_2.UI.Registros
{
    public partial class rVehiculos : Form
    {
        public rVehiculos()
        {
            InitializeComponent();
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(IdnumericUpDown, "Llenar Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Llene Descripcion");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            TotalMantenimientotextBox.Clear();

            errorProvider1.Clear();
        }
        private Vehiculos Llenaclase()
        {
            TotalMantenimientotextBox.Text = 0.ToString();
            Vehiculos vehiculo = new Vehiculos();
            vehiculo.VehiculosId = Convert.ToInt32(IdnumericUpDown.Value);
            vehiculo.Descripcion = DescripciontextBox.Text;
            vehiculo.TotalMantenimiento = Convert.ToDecimal(TotalMantenimientotextBox.Text);


            return vehiculo;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            if (validar(1))
            {
                MessageBox.Show("llenar vehiculoId");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Vehiculos vehiculo = BLL.VehiculosBLL.Buscar(id);

                if (vehiculo != null)
                {
                    IdnumericUpDown.Value = vehiculo.VehiculosId;
                    DescripciontextBox.Text = vehiculo.Descripcion;
                    TotalMantenimientotextBox.Text = vehiculo.TotalMantenimiento.ToString();


                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "busacr de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Vehiculos vehiculo = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                if(id == 0)
                {
                    paso = BLL.VehiculosBLL.Guardar(vehiculo);
                }
                else
                {
                    var P = BLL.VehiculosBLL.Buscar(id);
                    if(P != null)
                    {
                        paso = BLL.VehiculosBLL.Modificar(vehiculo);
                    }
                }
                Limpiar();
                errorProvider1.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!",
                        "guardar de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            if (validar(1))
            {
                MessageBox.Show("llenar vehiculoId");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.VehiculosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", 
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No fue Eliminar!", 
                        "eliminar de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
