using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPav1.Servicios.Implementaciones;
using TPPav1.Servicios.Interfaces;

namespace TPPav1.Presentacion
{
    public partial class frmReporteClienteConMasCompras : Form
    {
        IFacturaService oFactura;
        public frmReporteClienteConMasCompras()
        {
            InitializeComponent();
            oFactura = new FacturaService();
        }

        private void frmReporteClienteConMasCompras_Load(object sender, EventArgs e)
        {

            this.rpvClientesMasCompras.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha DESDE debe ser menor a la fecha HASTA","FECHA ERRONEA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                rpvClientesMasCompras.LocalReport.DataSources.Clear();
                rpvClientesMasCompras.LocalReport.DataSources.Add(new ReportDataSource("DatosClientesConMasCompras", oFactura.RecuperarPorFecha(dtpDesde.Value.ToString("dd/MM/yyyy"), dtpHasta.Value.ToString("dd/MM/yyyy"))));
                this.rpvClientesMasCompras.RefreshReport();
            }
        }
    }
}
