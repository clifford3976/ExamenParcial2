using Examen_2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Examen_2.UI.Consultas
{
    public partial class cArticulos : Form
    {
        public cArticulos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("llenar campo ",
                            "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Digite un numero!", 
                            "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        filtro = x => x.ArticulosId == id;

                        if (BLL.ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe ese Id",
                                "favor revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;

                case 1://Descripcion

                    if (Validar(1))
                    {
                        MessageBox.Show(" Llenar campo ", 
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Digite una Descripcion!", 
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);

                        if (BLL.ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no hay esa descripcion", 
                                "favor revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 2://Costo

                    if (Validar(1))
                    {
                        MessageBox.Show("Llenar campo ", 
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Digite un numero!",
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal costo = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.costo == costo;


                        if (BLL.ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe este costo", 
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://Ganancia

                    if (Validar(1))
                    {
                        MessageBox.Show("llenar campo ", 
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Digite un numero!",
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal Ganancia = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.Ganancia == Ganancia;


                        if (BLL.ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe la ganancia",
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }



                    break;

                case 4://precio
                    if (Validar(1))
                    {
                        MessageBox.Show("llenar campo ", 
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Digite un numeroo!",
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal precio = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.precio == precio;


                        if (BLL.ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe el precio",
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 5://Inventario
                    if (Validar(1))
                    {
                        MessageBox.Show("llenar campo ", 
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Digite un numero!",
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal Invetario = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.Inventario == Invetario;


                        if (BLL.ArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("el inventario es vacio",
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 6://Todo
                    filtro = x => true;
                    break;
            }

            ConsultadataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
            CriteriotextBox.Clear();
            errorProvider1.Clear();
        }

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                errorProvider1.SetError(CriteriotextBox, "siempre, LLenar Campo!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                errorProvider1.SetError(CriteriotextBox, "Digite un numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                errorProvider1.SetError(CriteriotextBox, "Digite cararcter");
                paso = true;
            }

            return paso;
        }
    }
}

