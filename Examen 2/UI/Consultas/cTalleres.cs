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
    public partial class cTalleres : Form
    {
        public cTalleres()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Talleres, bool>> filtro = x => true;

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

                        filtro = x => x.TallerId == id;

                        if (BLL.TalleresBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe ese Id",
                                "favor revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;

                case 1://Nombre

                    if (Validar(1))
                    {
                        MessageBox.Show(" Llenar campo ",
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Digite un nombre!",
                            "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Nombre.Contains(CriteriotextBox.Text);

                        if (BLL.TalleresBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no hay ese nombre",
                                "favor revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

            }
            ConsultadataGridView.DataSource = BLL.TalleresBLL.GetList(filtro);
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

