using AppBTS.Entidades;
using AppBTS.Negocio;
using AppBTS.Servicios;
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
    public partial class frmUsuarios : Form
    {
        enum Acciones
        {
            Alta,
            Modificacion,
            Baja
        }

        Acciones MiAccion;
        PerfilService oPerfil = new PerfilService();
        UsuarioService oUsuario = new UsuarioService();
             
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil,oPerfil.traerTodos());
            CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            HabilitarModoEdicion(false);
            MiAccion = Acciones.Modificacion;
        }

        private void HabilitarModoEdicion(bool v)
        {
            //txtId.Enabled = v; porque es autoincremental en la BD
            txtNombre.Enabled = v;
            txtPassword.Enabled = v;
            txtEmail.Enabled = v;
            cboPerfil.Enabled= v;
            btnGrabar.Enabled = v;
            btnCancelar.Enabled = v;
            btnNuevo.Enabled = !v;
            btnEditar.Enabled = !v;
            btnBorrar.Enabled = !v;
            btnSalir.Enabled=!v;
            grdUsuarios.Enabled = !v;
        }
        private void LimpiarCampos()
        {
            txtId.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
            cboPerfil.SelectedIndex = -1;
        }
        private void CargarCombo(ComboBox combo, List<Perfil> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdPerfil";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_usuario"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["email"]);
            }
            grilla.Focus();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            HabilitarModoEdicion(true);
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //VALIDAR!!!!
            if (ValidarDatos())
            {
                //Crear y Cargar objeto

                Usuario u = new Usuario();
                u.Nombre = txtNombre.Text;
                u.Password = txtPassword.Text;
                u.Email = txtEmail.Text;
                u.Id_perfil = (Perfil)cboPerfil.SelectedItem;

                if (MiAccion == Acciones.Alta)
                {
                    //insert
                    u.Estado = "N";
                    u.Borrado = false;
                    if (oUsuario.insertarUsuario(u) > 0)
                        MessageBox.Show("El usuario se creó con éxito!!!");
                }
                else
                {
                    //update
                    u.Id_usuario = int.Parse(txtId.Text);
                    if (oUsuario.actualizarUsuario(u)>0)
                        MessageBox.Show("El usuario se actualizó con éxito!!!");
                }
            }
            CargarGrilla(grdUsuarios, oUsuario.traerTodos());
            MiAccion = Acciones.Modificacion;
            HabilitarModoEdicion(false);
        }
        private bool ValidarDatos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar nombre de usuario...");
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar password...");
                txtPassword.Focus();
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Debe ingresar E-mail...");
                txtEmail.Focus();
                return false;
            }
            if (cboPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un perfil...");
                cboPerfil.Focus();
                return false;
            }
            return true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            LimpiarCampos();
            HabilitarModoEdicion(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarModoEdicion(true);
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void grdUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)grdUsuarios.CurrentRow.Cells[0].Value);
        }

        private void CargarCampos(int idUsuario)
        {
            DataTable tabla = oUsuario.traerPorId(idUsuario);
            txtId.Text = tabla.Rows[0]["id_usuario"].ToString();
            txtNombre.Text = tabla.Rows[0]["usuario"].ToString();
            txtPassword.Text = tabla.Rows[0]["password"].ToString();
            txtEmail.Text = tabla.Rows[0]["email"].ToString();
            cboPerfil.SelectedValue = tabla.Rows[0]["id_perfil"];
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar este usuario?"
                               ,"ELIMINANDO"
                               ,MessageBoxButtons.YesNo
                               ,MessageBoxIcon.Warning
                               ,MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                //Delete 
                if (oUsuario.eliminarUsuario((int)grdUsuarios.CurrentRow.Cells[0].Value) > 0)
                {
                    MessageBox.Show("El usuario se eliminó con éxito!!!");
                    CargarGrilla(grdUsuarios, oUsuario.traerTodos());
                }
            }
        }


    }
}
