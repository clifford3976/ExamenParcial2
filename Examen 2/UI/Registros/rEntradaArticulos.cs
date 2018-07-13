using Examen_2.DAL;
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
    public partial class rEntradaArticulos : Form
    {
        public rEntradaArticulos()
        {
            InitializeComponent();
            LlenaComboBox();
        }

        private void LlenaComboBox()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>(new Contexto());
            ArticulocomboBox.DataSource = repositorio.GetList(c => true);
            ArticulocomboBox.ValueMember = "ArticulosId";
            ArticulocomboBox.DisplayMember = "Descripcion";
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(IdnumericUpDown, "Llenar Id");
                errores = true;
            }

            if (error == 2 && CantidadnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CantidadnumericUpDown, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            CantidadnumericUpDown.Value = 0;


            errorProvider1.Clear();
        }
        private EntradaArticulos Llenaclase()
        {
            EntradaArticulos entradaarticulo = new EntradaArticulos();
            entradaarticulo.EntradaId = Convert.ToInt32(IdnumericUpDown.Value);
            entradaarticulo.ArticuloId = (int)ArticulocomboBox.SelectedValue;
            entradaarticulo.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);


            return entradaarticulo;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            EntradaArticulos entradaarticulo = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar campos");
            }
            else
            {
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.EntradaArticulosBLL.Guardar(entradaarticulo);
                }
                else
                {
                    var P = BLL.EntradaArticulosBLL.Buscar(Convert.ToInt32(entradaarticulo));
                    if(P != null)
                    {
                        paso = BLL.EntradaArticulosBLL.Modificar(entradaarticulo);
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
                    MessageBox.Show("No se pudo Guardar!",
                        "trata de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("llenar campos");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                EntradaArticulos entradaarticulo = BLL.EntradaArticulosBLL.Buscar(id);

                if (entradaarticulo != null)
                {
                    IdnumericUpDown.Value = entradaarticulo.EntradaId;
                    ArticulocomboBox.SelectedValue = entradaarticulo.ArticuloId;
                    CantidadnumericUpDown.Value = entradaarticulo.Cantidad;



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
                MessageBox.Show("llenar campos");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.EntradaArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se Pudo Eliminar!",
                        "trata de nuevo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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