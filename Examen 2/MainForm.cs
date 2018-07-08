using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rArticulos a = new UI.Registros.rArticulos();
            a.Show();
        }

        private void entradaArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rEntradaArticulos ea = new UI.Registros.rEntradaArticulos();
            ea.Show();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rMantenimientos m = new UI.Registros.rMantenimientos();
            m.Show();
        }

        private void talleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rTalleres t = new UI.Registros.rTalleres();
            t.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.rVehiculos v = new UI.Registros.rVehiculos();
            v.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.cArticulos a = new UI.Consultas.cArticulos();
            a.Show();
        }

        private void entradaArticulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.cEntradaArticulos ea = new UI.Consultas.cEntradaArticulos();
            ea.Show();
        }

        private void talleresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.cTalleres t = new UI.Consultas.cTalleres();
            t.Show();
        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UI.Consultas.cVehiculos v = new UI.Consultas.cVehiculos();
            v.Show();
        }
    }
}
