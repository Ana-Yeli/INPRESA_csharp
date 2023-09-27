using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPRESA
{
    public partial class NewVehicle : Form
    {
        ModeloConnect modCon = new ModeloConnect();
        ModeloTable modTab = new ModeloTable();
        View vis = new View();
        string mensaje = "";
        string servidorSQL = @"DESKTOP-GKVD9EA";
        string bd = "INPRESAOF";

        public NewVehicle()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnAltaVehicleYserv_Click(object sender, EventArgs e)
        {
            FormOrdenServicio frmOrdenServ = Owner as FormOrdenServicio;
            if (cmbTipoVehiculo.Text == "Selecciona" || txtMarca.Text == "" || txtModelo.Text == "" || txtNumSerieOvin.Text == "" || 
                txtPlacas.Text == "" || txtColor.Text == "")
            {
                MessageBox.Show("Favor de rellenar los campos faltantes");
            }
            else
            {
               
                SqlConnection cn = null;
                cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
                modTab.InsertarVehiculo(Convert.ToInt32(frmOrdenServ.lblidCliente.Text) , cmbTipoVehiculo.Text, txtMarca.Text, txtModelo.Text, txtNumSerieOvin.Text, txtPlacas.Text, txtColor.Text, ref mensaje, servidorSQL, bd);
                MessageBox.Show(mensaje);
                vis.MostrarDatosDataReader(frmOrdenServ.cmbVehiculo, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), frmOrdenServ.consultaVehiculo));
                cn.Close();
                cn.Dispose();
                this.Close();
            }
        }
    }
}
