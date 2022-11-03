﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TPPav1.Datos;
using TPPav1.Entidades;
using TPPav1.Servicios.Implementaciones;

namespace TPPav1.Presentacion
{
    public partial class frmReporteProveedoresPorBarrio : Form
    {
        ProveedorService oProveedor = new ProveedorService();
        LocalidadService oLocalidad = new LocalidadService();
        BarrioService oBarrio = new BarrioService();

        public frmReporteProveedoresPorBarrio()
        {
            InitializeComponent();
        }

        private void frmReporteProveedoresPorBarrio_Load(object sender, EventArgs e)
        {
            CargarComboLocalidad(cboLocalidad, oLocalidad.traerTodos());
            CargarComboBarrio(cboBarrio, oBarrio.traerTodosB());
            CargarComboCantidad(cboCantidad);
            
            //this.reportViewer1.RefreshReport();
        }

        private void CargarComboCantidad(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Insert(0, "Menor a mayor");
            combo.Items.Insert(1, "Mayor a menor");
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboBarrio(ComboBox combo, List<Barrio> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreBarrio";
            combo.ValueMember = "IdBarrio";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboLocalidad(ComboBox combo, List<Localidad> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "IdLocalidad";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //string consultaSQL = "select l.nombreLocalidad as Localidad, b.nombreBarrio as Barrio, count(*) as Cantidad from Localidades l inner join Barrios b on (l.idLocalidad = b.idLocalidad) inner join Proveedores p on (p.idBarrio = b.idBarrio) group by b.nombreBarrio, l.nombreLocalidad";
            //rpvProveedores.LocalReport.DataSources.Clear();
            //rpvProveedores.LocalReport.DataSources.Add(new ReportDataSource("DatosProveedoresPorBarrio", BDHelper.ObtenerInstancia().Consultar(consultaSQL)));
            //rpvProveedores.RefreshReport();

            string _localidad, _barrio;
            _localidad = _barrio = string.Empty;
            int _cantidad = -1;

            //DataTable tabla = oProveedor.TraerFiltrados();
            //this.dsProveedoresBindingSource.DataSource = oProveedor.TraerFiltrados();

            if (cboLocalidad.SelectedIndex != -1)
                _localidad = cboLocalidad.SelectedValue.ToString();
            if (cboBarrio.SelectedIndex != -1)
                _barrio = cboBarrio.SelectedValue.ToString();
            if (cboCantidad.SelectedIndex != -1)
                _cantidad = cboCantidad.SelectedIndex;

            rpvProveedores.LocalReport.DataSources.Clear();
            rpvProveedores.LocalReport.DataSources.Add(new ReportDataSource("DatosProveedoresPorBarrio", oProveedor.TraerFiltrados(_localidad, _barrio, _cantidad)));
            this.rpvProveedores.RefreshReport();

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            if (cboLocalidad.Text == string.Empty && cboBarrio.Text == string.Empty && cboCantidad.Text == string.Empty)
            {
                MessageBox.Show("Nada para limpiar.");
            }
            else
            {
                cboLocalidad.SelectedIndex = -1;
                cboBarrio.SelectedIndex = -1;
                cboCantidad.SelectedIndex = -1;
            }
        
        }
    }
}
