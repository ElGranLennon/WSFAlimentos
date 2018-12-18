using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ASP_Alimentos
{
    public partial class ListaCliente : System.Web.UI.Page
    {
        SWCliente.WSClienteClient cliente = new SWCliente.WSClienteClient();



        protected void Page_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            DataTable dt = new DataTable();

            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("  Nombre", typeof(string));
                dt.Columns.Add("  Apellido", typeof(string));
                dt.Columns.Add("  Rut", typeof(string));
                dt.Columns.Add("  DV", typeof(string));
                dt.Columns.Add("  Edad", typeof(string));
                dt.Columns.Add("  Estado", typeof(string));


            }


            foreach (var item in cliente.findAllCliente())
            {
                DataRow NewRow = dt.NewRow();
                NewRow[0] = item.nombreCliente;
                NewRow[1] = item.apellidoCliente;
                NewRow[2] = item.rut;
                NewRow[3] = item.dv;
                NewRow[4] = item.edadCliente;
                NewRow[5] = item.estadoCivilIdEstadoCivil.descripcionEstadoCivil;

               dt.Rows.Add(NewRow);
            }



            gv1.DataSource = dt;
            gv1.DataBind();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {


            
        }




    }
}
