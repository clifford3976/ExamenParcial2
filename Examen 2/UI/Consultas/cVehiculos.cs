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
    public partial class cVehiculos : Form
    {
        public cVehiculos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Vehiculos, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("llena campo ", 
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

                        filtro = x => x.VehiculosId == id;

                        if (BLL.VehiculosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("El id no existe", 
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    break;
                case 1://Descripcion
                    if (Validar(1))
                    {
                        MessageBox.Show("llenar campo ",
                            "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Digite una descripcion!",
                            "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);

                        if (BLL.VehiculosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe esa descripcion",
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;
                case 2://Total Mantenimiento
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
                        decimal mantenimiento = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.TotalMantenimiento == mantenimiento;


                        if (BLL.VehiculosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("no existe el total de mantenimiento",
                                "revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;
                case 3://Todo

                    filtro = x => true;
                    break;
            }

            ConsultadataGridView.DataSource = BLL.VehiculosBLL.GetList(filtro);
            errorProvider1.Clear();
        }

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                errorProvider1.SetError(CriteriotextBox, "siempre, LLenar campo!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                errorProvider1.SetError(CriteriotextBox, "Digite un numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                errorProvider1.SetError(CriteriotextBox, "Digite caracter");
                paso = true;
            }

            return paso;
        }
    }
    }

