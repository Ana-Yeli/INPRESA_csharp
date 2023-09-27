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
    public partial class FormConsultarOrdenDservicio : Form
    {
        ModeloConnect modCon = new ModeloConnect();
        ModeloTable modTab = new ModeloTable();
        View vis = new View();
        string mensaje = "";
        string servidorSQL = @"DESKTOP-GKVD9EA";
        string bd = "INPRESAOF";
        public FormConsultarOrdenDservicio()
        {
            InitializeComponent();
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            string consultaOrdenServ = "select idOrdenDeServicio from OrdenDeServicio";
            vis.MostrarDatosDataReader(cmbidOrdenServ, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), consultaOrdenServ));
            cn.Close();
            cn.Dispose();
        }

        private void cmbidOrdenServ_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            vis.MostrarDatosOrdenDeServicio(lblDatosCentroDsERV, lblFecha, lblNomCliente, lblNumCliente, lblDirCliente, lblTipoVehiculo, lblMarca, lblModelo,
                lblNoSerie, lblPlacas, lblKilometraje, lblColor, lblNumServicio, lblTrabRealizar, lblDiagYsolucion, lblLavesEnc, lblEspejos, lblBateria,
                lblParabrisas, lblTaposDgas,/* picIdentGolp1, picIdentGolp1, picIdentGolp1, picIdentGolp1,*/ lblNivelGas, lblTecnico, lblFechaPEntrega, cmbEstatus,
                modTab.BuscaDatosOrdenServ(ref mensaje, ref cn, Convert.ToInt32(cmbidOrdenServ.Text), picIdentGolp1));
            cn.Close();
            cn.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            modTab.ActualizarOrdenDservicio(cmbEstatus.Text, Convert.ToInt32(cmbidOrdenServ.Text), ref mensaje, servidorSQL, bd);
            MessageBox.Show(mensaje);
            cn.Close();
            cn.Dispose();
        }

        private void FormConsultarOrdenDservicio_Load(object sender, EventArgs e)
        {

        }
    }
}
