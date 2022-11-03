using AppBTS.Negocio;
using AppBTS.Servicios;
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
    public partial class frmReporteBugs : Form
    {
        Bug oBug = new Bug();
        Estado oEstado = new Estado();
        Prioridad oPrioridad = new Prioridad();
        Producto oProducto = new Producto();
        UsuarioService oUsuario = new UsuarioService();
        Criticidad oCriticidad = new Criticidad();

        public frmReporteBugs()
        {
            InitializeComponent();
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void frmReporteBugs_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cboEstado, oEstado.RecuperarTodos());
            this.CargarCombo(cboPrioridad, oPrioridad.RecuperarTodos());
            this.CargarCombo(cboProducto, oProducto.RecuperarTodos());
            this.CargarCombo(cboAsignadoA, oUsuario.traerTodos(), "usuario", "id_usuario");
            this.CargarCombo(cboCriticidad, oCriticidad.RecuperarTodos());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string _estado, _asignado, _prioridad, _criticidad, _producto;
            _estado = _asignado = _prioridad = _criticidad = _producto = string.Empty;

            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("Fechas erroneas!!!");
                dtpFechaDesde.Focus();
                return;
            }
            if (cboEstado.SelectedIndex != -1)
                _estado = cboEstado.SelectedValue.ToString();
            if (cboAsignadoA.SelectedIndex != -1)
                _asignado = cboAsignadoA.SelectedValue.ToString();
            if (cboPrioridad.SelectedIndex != -1)
                _prioridad = cboPrioridad.SelectedValue.ToString();
            if (cboCriticidad.SelectedIndex != -1)
                _criticidad = cboCriticidad.SelectedValue.ToString();
            if (cboProducto.SelectedIndex != -1)
                _producto = cboProducto.SelectedValue.ToString();

            this.dsBugsBindingSource.DataSource = oBug.RecuperarFiltrados(dtpFechaDesde.Value.ToString("yyyy/MM/dd"),
                                                               dtpFechaHasta.Value.ToString("yyyy/MM/dd"),
                                                               _estado,
                                                               _asignado,
                                                               _prioridad,
                                                               _criticidad,
                                                               _producto);
            
            this.reportViewer1.RefreshReport();

        }
    }
}
