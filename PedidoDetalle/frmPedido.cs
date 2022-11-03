using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PedidoDetalle.Entidades;
using PedidoDetalle.Servicios.Implementaciones;
using PedidoDetalle.Servicios.Interfaces;

namespace PedidoDetalle
{
    public partial class frmPedido : Form
    {
        IArticuloServicio servicio;
        List<Articulo> lstArticulos;

        IClienteServicio ocliente;

        IPedidoServicio oPedido;
        Pedido op;

        public frmPedido()
        {
            InitializeComponent();
            servicio = new ArticuloService();
            ocliente = new ClienteServicio();
            oPedido = new PedidoService();
            op = new Pedido();
        }

        private void txt_id_clientes_TextChanged(object sender, EventArgs e)
        {
            GroupBox1.Enabled = false;
            //txt_id_clientes.Text = String.Empty;
            txt_n_clientes.Text = String.Empty;
            btnConfirmar.Enabled = true;


        }

        

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {
            double x, y;
            if (txt_cantidad.Text != "" && txt_precio.Text != "")
            {
                int numero;
                if (Int32.TryParse(txt_cantidad.Text, out numero))
                {
                    x = Convert.ToDouble(txt_cantidad.Text);
                    y = Convert.ToDouble(txt_precio.Text);
                    txt_Subtotal.Text = Math.Round((x * y), 2).ToString();
                }
                else
                    MessageBox.Show("Debe ingresar una cantidad numérica...");
            }
        }

        private void btn_agregar_grilla_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 1 && txt_cantidad.Text != "")
            {
                if (!existe(comboBox1.Text))
                {
                    DetallePedido dp = new DetallePedido();
                    dp.Cantidad = Convert.ToInt32(txt_cantidad.Text);
                    dp.Articulo = lstArticulos[comboBox1.SelectedIndex];
                    dp.Precio = lstArticulos[comboBox1.SelectedIndex].Precio;
                    op.AgregarDetalle(dp);

                    grdDetalle.Rows.Add(dp.Cantidad, dp.Articulo.IdArticulo, dp.Articulo.Nombre, dp.Precio, dp.CalcularSubTotal());

                    txt_sub_total.Text = op.CalcularTotal().ToString();
                    txt_total.Text = op.CalcularTotal().ToString();

                }
                else
                    MessageBox.Show("El articulo ya fue seleccionado");
            }
            else
                MessageBox.Show("Debe seleccionar un articulo y cantidad");
            
         
        }

        private bool existe(string articuloSelec)
        {
            bool aux = false;
            foreach (DataGridViewRow item in grdDetalle.Rows)
            {
                if (item.Cells["Articulo"].Value.ToString().Equals(articuloSelec))
                {
                    aux = true;
                    break;
                }

            }
            return aux;
        
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            if (validarPedido())
            {
                if (grdDetalle.Rows.Count > 0)

                {
                    op.Fecha = dtpFecha.Value;
                    op.SubTotal = Convert.ToDouble(txt_sub_total.Text);
                    op.Descuento = Convert.ToDouble(txt_decuento.Text);
                    op.Total = Convert.ToDouble(txt_total.Text);

                    if (oPedido.GrabarPedido(op))
                    {
                        MessageBox.Show("El pedido se grabó con éxito!!!");
                        //Application.Restart();
                        //txt_pedido.Text = oPedido.ProximoNumero().ToString();
                        //frmPedido.Re
                    }
                    else
                    {
                        MessageBox.Show("No se pudo grabar el pedido!!!");
                        //Application.Exit();
                    }
                        




                }
                else
                    MessageBox.Show("Debe tener al menos un item de pedido...");
            }
        }

        private bool validarPedido()
        {
            if(dtpFecha.Value==null)
            {
                MessageBox.Show("Debe ingresar fecha...");
                dtpFecha.CalendarTitleBackColor = Color.Red;
                dtpFecha.Focus();
                return false;
            }
           
            if (txt_id_clientes.Text == string.Empty || txt_n_clientes.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un cliente...");
                txt_id_clientes.BackColor = Color.Red;
                txt_id_clientes.Focus();
                return false;
            }
           
            return true;
        }

        private void txt_decuento_TextChanged(object sender, EventArgs e)
        {
            double x, y;
            if (txt_sub_total.Text != "" && txt_decuento.Text != "")
            {
                int numero;
                if (Int32.TryParse(txt_decuento.Text, out numero))
                {
                    x = Convert.ToDouble(txt_sub_total.Text);
                    y = Convert.ToDouble(txt_decuento.Text);
                    txt_total.Text = Math.Round((x - y), 2).ToString();
                }
                else
                    MessageBox.Show("Debe ingresar un descuento numérico...");
            }
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            txt_pedido.Text = oPedido.ProximoNumero().ToString();
            CargarArticulos();
            btn_grabar.Enabled = false;
        }

        private void CargarArticulos()
        {
            lstArticulos = servicio.ObtenerArticulos();
            comboBox1.DataSource = lstArticulos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IdArticulo";
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_precio.Text = lstArticulos[comboBox1.SelectedIndex].Precio.ToString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPedido_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_buscar_cliente_Click(object sender, EventArgs e)
        {
            if (txt_id_clientes.Text == "")
                MessageBox.Show("Debe ingresar un cliente...");
            else
            {
                int numero;
                if (Int32.TryParse(txt_id_clientes.Text, out numero))
                {
                    Cliente c = ocliente.TraerPorId(numero);
                    if (c != null)
                    {
                        op.Cliente = c;
                        txt_n_clientes.Text = op.Cliente.Nombre;
                    }

                    else
                    {
                        MessageBox.Show("Cliente no encontrado...");
                        txt_id_clientes.Text = String.Empty;
                        txt_n_clientes.Text = String.Empty;
                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar un número de cliente...");
                    txt_id_clientes.Text = String.Empty;
                    txt_n_clientes.Text = String.Empty;
                }


            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txt_id_clientes.Text = string.Empty;
            txt_n_clientes.Text = string.Empty;
            txt_cantidad.Text = string.Empty;
            txt_Subtotal.Text = string.Empty;
            txt_sub_total.Text = "0";
            txt_total.Text = "0";
            txt_decuento.Text = "0";
            //dtpFecha.Text = string.Empty;
            grdDetalle.Rows.Clear();
            btnConfirmar.Enabled = true;
            //txt_pedido.Text = string.Empty;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txt_n_clientes.Text != string.Empty)
            {
                GroupBox1.Enabled = true;
                btnConfirmar.Enabled = false;
                btn_grabar.Enabled = true;
                //grdDetalle.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Busque el cliente primero para luego confirmarlo");
            }
            
        }
    }
}
