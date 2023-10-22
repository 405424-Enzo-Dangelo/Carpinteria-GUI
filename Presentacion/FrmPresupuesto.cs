using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CarpinteriaGUI.Entidades;
using CarpinteriaGUI.Datos;
using CarpinteriaGUI.Datos.interfaz;
using CarpinteriaGUI.Datos.implementacion;
using CarpinteriaGUI.Servicios.interfaz;
using CarpinteriaGUI.Servicios.implementacion;
using CarpinteriaGUI.Servicios;

namespace CarpinteriaGUI
{
    public partial class FrmPresupuesto : Form
    {
        IServicio servicio = null;
        Presupuesto nuevo=null;
        public FrmPresupuesto(FabricaServicio fabrica)
        {
            InitializeComponent();
            nuevo = new Presupuesto();
            servicio = fabrica.CrearServicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_fecha.Text = DateTime.Today.ToShortDateString();
            txt_cliente.Text = "Consumidor Final";
            txt_descuento.Text = "0";
            txt_cantidad.Text = "1";
            lbl_npresupuesto.Text = lbl_npresupuesto.Text + " " +servicio.TraerProximoNro().ToString();
            //ProximoPresupuesto();
            CargarProductos();
        }

        private void CargarProductos()
        {
            cb_productos.DataSource = servicio.TraerProductos();
            cb_productos.ValueMember = "ProductoNro";
            cb_productos.DisplayMember = "Nombre";
            cb_productos.SelectedIndex = -1;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (cb_productos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un producto...","Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txt_cantidad.Text) || !int.TryParse(txt_cantidad.Text, out _) || Convert.ToInt32(txt_cantidad.Text) < 1)
            {
                MessageBox.Show("Debe ingresar una cantidad valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow fila in dgv_detalles.Rows)
            {
                if (fila.Cells["Col_producto"].Value.ToString().Equals(cb_productos.Text))
                {
                    MessageBox.Show("Este producto ya esta presupuestado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            /*DataRowView item = (DataRowView)cb_productos.SelectedItem;
            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[2]);
            Producto p = new Producto(nro, nom, pre);*/

            Producto p = (Producto)cb_productos.SelectedItem;
            int cant = Convert.ToInt32(txt_cantidad.Text);
            DetallesPresupuesto detalle = new DetallesPresupuesto(p, cant);

            nuevo.AgregarDetalle(detalle);
            dgv_detalles.Rows.Add(new object[] { p.Productonro, p.Nombre, p.Precio, cant, "Quitar" });

            CalcularTotales();
        }

        private void CalcularTotales()
        {
            double total = nuevo.CalcularTotal();
            txt_subtotal.Text = total.ToString();
            double dto = total * Convert.ToDouble(txt_descuento.Text) / 100;
            txt_total.Text = (total - dto).ToString();
        }

        private void dgv_detalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 4 ) // es el boton quitar?
            //{
            //    nuevo.QuitarDetalle(e.RowIndex);
            //    dgv_detalles.Rows.RemoveAt(e.RowIndex);
            //    CalcularTotales();
            //}

            if (dgv_detalles.CurrentCell.ColumnIndex == 4 || dgv_detalles.CurrentRow.Index > 0) // es el boton quitar?
            {
                nuevo.QuitarDetalle(dgv_detalles.CurrentRow.Index);
                dgv_detalles.Rows.RemoveAt(dgv_detalles.CurrentRow.Index);
                CalcularTotales();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            //Validar...
            if (string.IsNullOrEmpty(txt_cliente.Text))
            {
                MessageBox.Show("Debe ingresar un cliente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgv_detalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Grabar presupuesto como M-D
            GrabarPresupuesto();
        }

        private void GrabarPresupuesto()
        {
            nuevo.Fecha = Convert.ToDateTime(txt_fecha.Text);
            nuevo.Cliente = txt_cliente.Text;
            nuevo.Descuento = Convert.ToDouble(txt_descuento.Text);
            
            if (servicio.GrabarPresupuesto(nuevo))
            {
                MessageBox.Show("Se grabo con exito el presupuesto", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose(); //cierra y elimina de memoria el objeto (libera memoria)
            }
            else
            {
                MessageBox.Show("No se pudo grabar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
