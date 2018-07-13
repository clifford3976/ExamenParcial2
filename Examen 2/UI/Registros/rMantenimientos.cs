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
    public partial class rMantenimientos : Form
    {
        decimal ITBIS = 0;
        decimal Total = 0;
        public rMantenimientos()
        {
            InitializeComponent();
            LlenarComboBox();
            Meses();
        }

        private void Meses()
        {
            ProximaFechadateTimePicker.Value = FechadateTimePicker.Value.AddMonths(3);
        }


        private void FechadateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Meses();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        public void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            TotaltextBox.Clear();

            ImportetextBox.Clear();
            SubtotaltextBox.Text = 0.ToString();
            TotaltextBox.Text = 0.ToString();
            ITBIStextBox.Text = 0.ToString();
            DetalledataGridView.DataSource = null;

            ITBIS = 0;
            Total = 0;

            errorProvider1.Clear();
        }

        private Mantenimientos LlenaClase()
        {
            Mantenimientos Mantenimiento = new Mantenimientos();

            Mantenimiento.MantenimientoId = Convert.ToInt32(IdnumericUpDown.Value);
            Mantenimiento.VehiculoId = Convert.ToInt32(VehiculocomboBox.SelectedValue);
            Mantenimiento.Fecha = FechadateTimePicker.Value;
            Mantenimiento.Subtotal = Convert.ToDecimal(SubtotaltextBox.Text);
            Mantenimiento.ITBIS = Convert.ToDecimal(ITBIStextBox.Text);
            Mantenimiento.Total = Convert.ToDecimal(TotaltextBox.Text);
            



    
            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                Mantenimiento.AgregarDetalle
                    (ToInt(item.Cells["id"].Value),
                     Mantenimiento.MantenimientoId,
                       ToInt(item.Cells["tallerId"].Value),
                     ToInt(item.Cells["articulosId"].Value),
                      Convert.ToString(item.Cells["articulo"].Value),
                       ToInt(item.Cells["cantidad"].Value),
                    ToInt(item.Cells["precio"].Value),
                    ToInt(item.Cells["Importe"].Value)



                  );
            }
            return Mantenimiento;
        }


        private void LlenarCampos(Mantenimientos Mantenimiento)
        {
            Limpiar();
            IdnumericUpDown.Value = Mantenimiento.MantenimientoId;
            FechadateTimePicker.Value = Mantenimiento.Fecha;
            SubtotaltextBox.Text = Mantenimiento.Subtotal.ToString();
            ITBIStextBox.Text = Mantenimiento.ITBIS.ToString();
            TotaltextBox.Text = Mantenimiento.Total.ToString();

           
            DetalledataGridView.DataSource = Mantenimiento.Detalle;

        }

        private void LlenarComboBox()
        {
            Repositorio<Vehiculos> vehiculo = new Repositorio<Vehiculos>(new Contexto());
            VehiculocomboBox.DataSource = vehiculo.GetList(c => true);
            VehiculocomboBox.ValueMember = "VehiculosId";
            VehiculocomboBox.DisplayMember = "Descripcion";

            Repositorio<Talleres> taller = new Repositorio<Talleres>(new Contexto());
            TallercomboBox.DataSource = taller.GetList(c => true);
            TallercomboBox.ValueMember = "TallerId";
            TallercomboBox.DisplayMember = "Nombre";

            Repositorio<Articulos> Entrada = new Repositorio<Articulos>(new Contexto());
            ArticuloscomboBox.DataSource = Entrada.GetList(c => true);
            ArticuloscomboBox.ValueMember = "ArticulosId";
            ArticuloscomboBox.DisplayMember = "Descripcion";
        }

        private void rMantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void ArticuloscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in BLL.ArticulosBLL.GetList(x => x.Descripcion == ArticuloscomboBox.Text))
            {
                 PreciotextBox.Text = item.precio.ToString();

            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<MantenimientosDetalle> Detalle = new List<MantenimientosDetalle>();


            if (DetalledataGridView.DataSource != null)
            {
                Detalle = (List<MantenimientosDetalle>)DetalledataGridView.DataSource;
            }



            foreach (var item in BLL.ArticulosBLL.GetList(x => x.Inventario < CantidadnumericUpDown.Value))
            {

                MessageBox.Show("No hay ",
                    "validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (string.IsNullOrEmpty(ImportetextBox.Text))
            {
                MessageBox.Show("llena cantidad",
                    "validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Detalle.Add(
                    new MantenimientosDetalle(id: 0,
                    mantenimientoId: (int)Convert.ToInt32(IdnumericUpDown.Value),
                    tallerId: (int)TallercomboBox.SelectedValue,
                       articulosId: (int)ArticuloscomboBox.SelectedValue,
                            articulo: (string)BLL.ArticulosBLL.RetornarDescripcion(ArticuloscomboBox.Text),
                        cantidad: (int)Convert.ToDecimal(CantidadnumericUpDown.Value),
                        precio: (int)Convert.ToDecimal(PreciotextBox.Text),
                        importe: (int)Convert.ToDecimal(ImportetextBox.Text)

                    ));




              
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = Detalle;


            }

            decimal SubTotal = 0;

            foreach(var item in Detalle)
            {
                SubTotal += item.Importe;
            }

          
                SubtotaltextBox.Text = SubTotal.ToString();
            

            ITBIS = BLL.MantenimientosBLL.CalcularITBIS(Convert.ToDecimal(SubtotaltextBox.Text));

            ITBIStextBox.Text = ITBIS.ToString();

            Total = BLL.MantenimientosBLL.Total(Convert.ToDecimal(SubtotaltextBox.Text), Convert.ToDecimal(ITBIStextBox.Text));

            TotaltextBox.Text = Total.ToString();


        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImportetextBox.Text = BLL.MantenimientosBLL.CalcularImporte(Convert.ToDecimal(PreciotextBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value)).ToString();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Mantenimientos Mantenimiento = BLL.MantenimientosBLL.Buscar(id);

            if (Mantenimiento != null)
            {
                LlenarCampos(Mantenimiento);

            }
            else
                MessageBox.Show("No se encontro!", "buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {


                MessageBox.Show("llenar campos!",
                    "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                if (BLL.MantenimientosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!",
                        "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!",
                        "trata de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (Validar(2))
            {
                MessageBox.Show("agreagar articulo al grid",
                    "validar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                Mantenimientos Mantenimiento = LlenaClase();
                bool Paso = false;



                if (IdnumericUpDown.Value == 0)
                {
                    Paso = BLL.MantenimientosBLL.Guardar(Mantenimiento);
                    errorProvider1.Clear();
                }
                else
                {
                    var P = BLL.MantenimientosBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value));
                    if(P != null)
                    {
                        Paso = BLL.MantenimientosBLL.Modificar(Mantenimiento);
                    }
                  
                    errorProvider1.Clear();
                }

                if (Paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!!", "Exitosamente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo guardar!!", 
                        "trata de nuevo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            MantenimientosDetalle mantenimientos = new MantenimientosDetalle();

            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {

                List<MantenimientosDetalle> Detalle = (List<MantenimientosDetalle>)DetalledataGridView.DataSource;
           

                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                decimal SubTotal = 0;

                foreach(var item in Detalle)
                {
                    SubTotal -= item.Importe;
                }

                SubTotal *= (-1);
                SubtotaltextBox.Text = SubTotal.ToString();



                ITBIS = BLL.MantenimientosBLL.CalcularITBIS(Convert.ToDecimal(SubtotaltextBox.Text));
                ITBIStextBox.Text = ITBIS.ToString();

                Total = BLL.MantenimientosBLL.Total(Convert.ToDecimal(SubtotaltextBox.Text), Convert.ToDecimal(ITBIStextBox.Text));

                TotaltextBox.Text = Total.ToString();


            }

        }

        private bool Validar(int error)
        {
            bool paso = false;



            if (error == 1 && IdnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(IdnumericUpDown,
                   "No dejes id vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(TotaltextBox.Text))
            {
                errorProvider1.SetError(TotaltextBox,
                   "No dejes el total vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(SubtotaltextBox.Text))
            {
                errorProvider1.SetError(SubtotaltextBox,
                   "No dejes el subtotal vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(ITBIStextBox.Text))
            {
                errorProvider1.SetError(ITBIStextBox,
                   "No dejes el Itbis vacio");
                paso = true;
            }

            if (error == 2 && DetalledataGridView.RowCount == 0)
            {
                errorProvider1.SetError(DetalledataGridView,
                    "siempre agregue un articulo");
                paso = true;
            }

            if (error == 3 && string.IsNullOrEmpty(ImportetextBox.Text))
            {
                errorProvider1.SetError(ImportetextBox,
                    "siempre agregue un articulo");
                paso = true;
            }

            return paso;
        }

    }
}
