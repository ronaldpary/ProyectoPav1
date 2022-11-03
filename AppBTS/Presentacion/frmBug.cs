using AppBTS.Negocio;
using AppBTS.Servicios.Implementaciones;
using AppBTS.Servicios.Interfaces;
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
    public enum Modo
    {
        Create,
        Read,
        Update,
        Delete
    }
    public partial class frmBug : Form
    {
        Modo modo = Modo.Create;
        Bug oBug = null;
        HistorialBug oHistorialBug = null; 
        Producto oProducto=null;   
        Criticidad oCriticidad=null;
        Prioridad oPrioridad=null;
        IBugService oServicio = null;

        public frmBug(Modo accion,Bug oBugSeleccionado)
        {
            InitializeComponent();
            
            oPrioridad=new Prioridad();
            oProducto=new Producto();
            oCriticidad=new Criticidad();
            oServicio=new BugService();

            if (accion.Equals(Modo.Update))
            {
                modo= accion;
                oBug= oBugSeleccionado;
                this.Text = "Actualizar Bug";
                //oPrioridad = oBugSeleccionado.Id_prioridad;
                //oProducto = oBugSeleccionado.Id_producto;
                //oCriticidad = oBugSeleccionado.Id_criticidad;
                //this.txtTitulo.Text = oBugSeleccionado.Titulo;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Validar!!!!

            switch (modo)
            {
                case Modo.Create:
                    {
                        oBug = new Bug();
                        oBug.Titulo = txtTitulo.Text;
                        oBug.Descripcion = txtDescripcion.Text;
                        oBug.Id_prioridad = (int)cboPrioridad.SelectedValue;
                        oBug.Id_producto = (int)cboProducto.SelectedValue;
                        oBug.Id_criticidad = (int)cboCriticidad.SelectedValue;
                        oBug.Fecha_alta = DateTime.Today;
                        oBug.Id_estado = 1;//Nuevo
                        oBug.Borrado = false;
                        oBug.Id_usuario_responsable = 2;//Usuario logueado con perfil Tester

                        oHistorialBug = new HistorialBug();
                        oHistorialBug.Fecha = DateTime.Today;
                        oHistorialBug.Responsable = 2;
                        oHistorialBug.IdEstado = 1;
                        oHistorialBug.IdDetalle = 1;//para comenzar numero consecutivo de detalles...

                        // insertar oBug nuevo
                        if (oServicio.CrearBugConHistorial(oBug, oHistorialBug))
                            MessageBox.Show("Se creó con éxito un nuevo Bug!!!");
                        else
                            MessageBox.Show("Error al crear un nuevo Bug!!!");

                        break;
                    }
                case Modo.Read:
                    break;
                case Modo.Update:
                    {
                        // update oBugSeleccionado
                        break;
                    }
                case Modo.Delete:
                    break;
                default:
                    break;
            }
            this.Close();
        }

        private void frmBug_Load(object sender, EventArgs e)
        {
            this.CargarCombo(cboPrioridad, oPrioridad.RecuperarTodos());
            this.CargarCombo(cboProducto, oProducto.RecuperarTodos());
            this.CargarCombo(cboCriticidad, oCriticidad.RecuperarTodos());
            
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBug_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de cerrar el formulario..."
                            , "Cerrando"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question
                            , MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
