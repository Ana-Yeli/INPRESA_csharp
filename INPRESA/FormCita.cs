using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPRESA
{
    public partial class FormCita : Form
    {
        ModeloConnect modCon = new ModeloConnect();
        ModeloTable modTab = new ModeloTable();
        ModeloCorreo modC = new ModeloCorreo();
        View vis = new View();
        string mensaje = "";
        string servidorSQL = @"DESKTOP-GKVD9EA";
        string bd = "INPRESAOF";

        public string consultaCliente = "select Nombre_Completo from Cliente";
        public FormCita()
        {
            InitializeComponent();
            vis.MostrarDatosDataReader(cmbCliente, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), consultaCliente));
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            vis.MostraridEmail(lblidCliente, lblEmail, modTab.BuscaidClienteEmail(ref mensaje, ref cn, cmbCliente.Text));
            cn.Close();
            cn.Dispose();
        }

        private void btnAltaCita_Click(object sender, EventArgs e)
        {
            if(cmbCliente.Text=="Selecciona" || txtMotivo.Text == "")
            {
                MessageBox.Show("Favor de llenar los campos faltantes");
            }
            else
            {
                SqlConnection cn = null;
                cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
                modTab.InsertarCita(Convert.ToInt32(lblidCliente.Text), DatepicFecha.Value, dTPHora.Value, txtMotivo.Text, ref mensaje, servidorSQL, bd);
                MessageBox.Show(mensaje);
                cn.Close();
                cn.Dispose();

                modC.EnviarCita(lblEmail.Text, DatepicFecha.Value, dTPHora.Value, txtMotivo.Text);
            }
        }
    }
}
