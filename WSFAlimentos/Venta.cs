
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WSFAlimentos
{
    public partial class Venta : Form 
    {
        SWProducto.WSProductoClient producto = new SWProducto.WSProductoClient();
        SWVenta.WSVentasClient venta = new SWVenta.WSVentasClient();
        SWCliente.WSClienteClient cliente = new SWCliente.WSClienteClient();
        SWEstadoCivil.WSEstadoCivilClient estadoCivil = new SWEstadoCivil.WSEstadoCivilClient();
        SWBoletas.WSBoletaClient boletas = new SWBoletas.WSBoletaClient();
        SWDetalle.WSDetalleClient detalle = new SWDetalle.WSDetalleClient();

        public Venta()
        {
            InitializeComponent();
            ini();

        }

        private void ini()
        {
            
            //fila.CreateCells(dataGridView1);
            //fila.Cells[0].Value = "nombre";
            //fila.Cells[1].Value = "precio";

            //dataGridView1.Rows.Add(fila);

            SWProducto.WSProductoClient producto = new SWProducto.WSProductoClient();


            foreach (var item in producto.findAllProducto())
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView1);
                fila.Cells[0].Value = item.idProducto;
                fila.Cells[1].Value = item.nombreProducto;
                fila.Cells[2].Value = item.descripcionProducto;
                fila.Cells[3].Value = item.precioProducto;
                fila.Cells[4].Value = item.anioF;
                fila.Cells[5].Value = item.anioV;
                fila.Cells[6].Value = item.subtipoProducto.tipoProducto.descripcionTp;
                fila.Cells[7].Value = item.subtipoProducto.descripcionStp;


                dataGridView1.Rows.Add(fila);

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idproducto = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SWProducto.producto pro = producto.findProducto(int.Parse(idproducto));

            DataGridViewRow fila2 = new DataGridViewRow();

            fila2.CreateCells(dgvBoleta);
            fila2.Cells[0].Value = pro.idProducto;
            fila2.Cells[1].Value = pro.nombreProducto;
            fila2.Cells[2].Value = pro.precioProducto;

            dgvBoleta.Rows.Add(fila2);

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (venta.CrearVenta2(false, dtpFechaEntrega.Value, txtDV.Text, int.Parse(txtRut.Text)))
                {
                    dto.clases.Boleta boleta = new dto.clases.Boleta();
                    SWBoletas.boleta b = new SWBoletas.boleta();
                    int idV = 0;
                    foreach (var item in venta.findAllVentas())
                    {
                        idV = item.idventas;
                    }

                    boletas.CreateBoleta2(idV);
                    int idB = 0;
                    foreach (var item in boletas.findAllBoleta())
                    {
                        idB = item.idBoleta;
                    }

                    for (int fila = 0; fila < dgvBoleta.Rows.Count - 1; fila++)
                    {
                        int idDet = int.Parse(dgvBoleta.Rows[fila].Cells["ID_Producto"].Value.ToString());
                        detalle.createDetalle2(idDet, idB);
                    }


                    dgvBoleta.Rows.Clear();
                    dgvBoleta.Refresh();
                    MessageBox.Show("Agrego");

                }
                else
                {
                    MessageBox.Show("NO!! Agrego");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
