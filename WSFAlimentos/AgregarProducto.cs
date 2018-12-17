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
    public partial class AgregarProducto : Form
    {
        SWSubTipo.WSSubTipoClient subTipo = new SWSubTipo.WSSubTipoClient();
        SWTipo.WSTipoClient tipo = new SWTipo.WSTipoClient();
        SWProducto.WSProductoClient producto = new SWProducto.WSProductoClient();



        public AgregarProducto()
        {
            InitializeComponent();
            ini();
        }

        private void ini()
        {
           
            //cboSubTipo.DataSource = tipo.findAllTipo();

            
            var tipo2 = new BindingList<KeyValuePair<string, string>>();
            


            foreach (var item in tipo.findAllTipo())
            {
                tipo2.Add(new KeyValuePair<string, string>(item.idTp.ToString(),item.descripcionTp));
            }

            cboTipo.DataSource = tipo2;
            cboTipo.ValueMember = "Key";
            cboTipo.DisplayMember = "Value";


            //foreach (SWTipo.tipoProducto item in tipo.findAllTipo())
            //{
            //    cboTipo.Items.Add(item.descripcionTp);
            //}
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var tipo2 = new BindingList<KeyValuePair<string, string>>();



            foreach (var item in subTipo.findAllSubTipo())
            {
                if ((cboTipo.SelectedIndex + 1).ToString().Equals(item.tipoProducto.idTp.ToString()))
                {

                    tipo2.Add(new KeyValuePair<string, string>(item.subtipoProductoPK.subtipoP.ToString(), item.descripcionStp));
                }
            }

            cboSubTipo.DataSource = tipo2;
            cboSubTipo.ValueMember = "Key";
            cboSubTipo.DisplayMember = "Value";




            //cboSubTipo.Items.Clear();
            //foreach (SWSubTipo.subtipoProducto item in subTipo.findAllSubTipo())
            //{
            //    if ((cboTipo.SelectedIndex + 1).ToString().Equals(item.tipoProducto.idTp.ToString()))
            //    {
            //        cboSubTipo.Items.Add(item.descripcionStp);

            //    }

            //}
            //cboSubTipo.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            dto.clases.SubtipoProducto sub = new dto.clases.SubtipoProducto();

            // sub.TipoProducto.IdTp = short.Parse(cboTipo.SelectedIndex + 1);

            

            // get selected KVP
            KeyValuePair<string, string> selectedEntry
                = (KeyValuePair<string, string>)cboSubTipo.SelectedItem;

            // get selected Key
            string selectedKey = selectedEntry.Key;

            MessageBox.Show(selectedKey);

            double tarifa = 0.1;
            if(producto.CreateProducto2(txtNombrePreoducto.Text, int.Parse(txtStock.Text), dtpFabricacion.Value, dtpVencimiento.Value, txtDescripcion.Text, int.Parse(txtStock.Text), tarifa, int.Parse(selectedKey)))
            {
                MessageBox.Show("Agrego");
            }
            else
            {
                MessageBox.Show("NO Agrego");
            }
            

        }
    }
}
