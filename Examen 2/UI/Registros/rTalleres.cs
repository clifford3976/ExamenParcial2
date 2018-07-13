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
    public partial class rTalleres : Form
    {
        public rTalleres()
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

            if (error == 2 && string.IsNullOrEmpty(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Clear();


            errorProvider1.Clear();
        }
        private Talleres Llenaclase()
        {
            Talleres taller = new Talleres();
            taller.TallerId = Convert.ToInt32(IdnumericUpDown.Value);
            taller.Nombre = NombretextBox.Text;


            return taller;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar campo");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Talleres taller = BLL.TalleresBLL.Buscar(id);

                if (taller != null)
                {
                    IdnumericUpDown.Value = taller.TallerId;
                    NombretextBox.Text = taller.Nombre;



                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "buscar de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();

            }


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar campo");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.TalleresBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!",
                        "tratar de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Talleres taller = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar campo");
            }
            else
            {
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.TalleresBLL.Guardar(taller);
                }
                else
                {
                    var P = BLL.TalleresBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
                    if(P != null)
                    {
                        paso = BLL.TalleresBLL.Modificar(taller);
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
                        "tratar de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
