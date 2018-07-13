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
    public partial class rArticulos : Form
    {
        public rArticulos()
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

            if (error == 2 && PrecionumericUpDown.Value == 0)
            {
                errorProvider1.SetError(PrecionumericUpDown, "Llenar precio");
                errores = true;
            }

            if (error == 2 && GanancianumericUpDown.Value == 0)
            {
                errorProvider1.SetError(GanancianumericUpDown, "Llena Ganancia");
                errores = true;
            }

            if (error == 2 && CostonumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CostonumericUpDown, "Llena Costo");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Llena Descripcion");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(InventariotextBox.Text))
            {
                errorProvider1.SetError(InventariotextBox, "Llena Inventario");
                errores = true;
            }


            return errores;

        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            CostonumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            InventariotextBox.Clear();
            DescripciontextBox.Clear();
            GanancianumericUpDown.Value = 0;
            InventariotextBox.Text = 0.ToString();


            errorProvider1.Clear();
        }

        private Articulos Llenaclase()
        {
            Articulos articulo = new Articulos();

            InventariotextBox.Text = 0.ToString();
            articulo.ArticulosId = Convert.ToInt32(IdnumericUpDown.Value);
            articulo.Descripcion = DescripciontextBox.Text;
            articulo.costo = Convert.ToDecimal(CostonumericUpDown.Value);
            articulo.Ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);
            articulo.precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            articulo.Inventario = Convert.ToInt32(InventariotextBox.Text);

            return articulo;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulo = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("llenar campo");
            }
            else
            {
                if (IdnumericUpDown.Value == 0)
                {
                    paso = BLL.ArticulosBLL.Guardar(articulo);
                }
                else
                {
                    var P = BLL.ArticulosBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
                    if(P != null)
                    {
                        paso = BLL.ArticulosBLL.Modificar(articulo);
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
                MessageBox.Show("llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Articulos articulo = BLL.ArticulosBLL.Buscar(id);

                if (articulo != null)
                {
                    IdnumericUpDown.Value = articulo.ArticulosId;
                    DescripciontextBox.Text = articulo.Descripcion;
                    CostonumericUpDown.Value = articulo.costo;
                    GanancianumericUpDown.Value = articulo.Ganancia;
                    PrecionumericUpDown.Value = articulo.precio;
                    InventariotextBox.Text = articulo.Inventario.ToString();

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!",
                        "trata de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                errorProvider1.Clear();
            }


        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            if (validar(1))
            {
                MessageBox.Show("llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);

                if (BLL.ArticulosBLL.Eliminar(id))
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

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);

            if (PrecionumericUpDown.Value != 0  && CostonumericUpDown.Value != 0)
            {
                GanancianumericUpDown.Value = BLL.ArticulosBLL.CalcularGanancia(costo,precio);
                return;
            }

                if (CostonumericUpDown.Value != 0 && GanancianumericUpDown.Value != 0 && PrecionumericUpDown.Value == 0)
            {

                PrecionumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
                return;
            }


        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);

            if (PrecionumericUpDown.Value != 0  && CostonumericUpDown.Value != 0 && CostonumericUpDown.Value < PrecionumericUpDown.Value)
            {
                GanancianumericUpDown.Value = BLL.ArticulosBLL.CalcularGanancia(costo, precio);
                return;

            }
            
        }

        private void GanancianumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(CostonumericUpDown.Value);
            decimal precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(GanancianumericUpDown.Value);


            if (CostonumericUpDown.Value != 0 && GanancianumericUpDown.Value != 0)
            {

                PrecionumericUpDown.Value = BLL.ArticulosBLL.CalcularPrecio(costo, ganancia);
                return;
            }

        }
    }
}
