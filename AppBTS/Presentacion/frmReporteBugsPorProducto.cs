using AppBTS.Datos;
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

namespace AppBTS.Presentacion
{
    public partial class frmReporteBugsPorProducto : Form
    {
        public frmReporteBugsPorProducto()
        {
            InitializeComponent();
        }

        private void frmReporteBugsPorProducto_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dtpFechaDesde.Value <= dtpFechaHasta.Value)
            {
                rpvBugs.LocalReport.SetParameters(new ReportParameter[]
                                   { new ReportParameter("prFechaDesde", dtpFechaDesde.Value.ToString("yyyy/MM/dd")),
                                     new ReportParameter("prFechaHasta", dtpFechaHasta.Value.ToString("yyyy/MM/dd"))});

                //DATASOURCE
                string consultaSQL = "SELECT t2.nombre as producto, t3.nombre as estado, COUNT(*) as ctd" +
                                    " FROM Bugs t1, Productos t2, Estados t3" +
                                    " WHERE t1.id_producto = t2.id_producto" +
                                    " AND t1.id_estado = t3.id_estado" +
                                    " AND t1.fecha_alta between '" + dtpFechaDesde.Value.ToString("yyyy/MM/dd") +
                                    "' AND '" + dtpFechaHasta.Value.ToString("yyyy/MM/dd") +
                                    "' GROUP BY t3.nombre, t2.nombre";

                rpvBugs.LocalReport.DataSources.Clear();
                rpvBugs.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", BDHelper.obtenerInstancia().consultar(consultaSQL)));
                rpvBugs.RefreshReport();
            }
        }
    }
}
