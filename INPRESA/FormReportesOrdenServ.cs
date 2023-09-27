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
    public partial class FormReportesOrdenServ : Form
    {
        ModeloConnect modCon = new ModeloConnect();
        ModeloTable modTab = new ModeloTable();
        View vis = new View();
        string mensaje = "";
        string servidorSQL = @"DESKTOP-GKVD9EA";
        string bd = "INPRESAOF";

        public FormReportesOrdenServ()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //TODO: esta línea de código carga datos en la tabla 'DataSetPrincipal.OrdenServicioXid' Puede moverla o quitarla según sea necesario.
            this.OrdenServicioXidTableAdapter.Fill(this.DataSetPrincipal.OrdenServicioXid, Convert.ToInt32(cmbidOrdenServ.Text));
            this.reportViewer1.RefreshReport();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {          
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            string consultaOrdenServ = "select idOrdenDeServicio from OrdenDeServicio";
            vis.MostrarDatosDataReader(cmbidOrdenServ, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), consultaOrdenServ));
            cn.Close();
            cn.Dispose();           
        }

        private void btnFormEnviarEmail_Click(object sender, EventArgs e)
        {
            FormEnviarEmail frmEnviarE = new FormEnviarEmail();
            frmEnviarE.Show();
        }
    }
}
