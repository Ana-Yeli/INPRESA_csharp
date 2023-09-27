using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INPRESA
{
    public partial class NewClient : Form
    {
        ModeloConnect modCon = new ModeloConnect();
        ModeloTable modTab = new ModeloTable();
        View vis = new View();
        string mensaje = "";
        string servidorSQL = @"DESKTOP-GKVD9EA";
        string bd = "INPRESAOF";
        public NewClient()
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

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            FormOrdenServicio frmOrdenServ = Owner as FormOrdenServicio;

            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            if (txtNomCliente.Text == "" || txtDireccion.Text == "" || txtNumTelefono.Text == "" || txtEmail.Text=="")
            {
                MessageBox.Show("Favor de rellenar los campos faltantes");
            }
            else if(checkAvisoPriv.Checked == false || checkContratoPROF.Checked == false)
            {
                MessageBox.Show("Acepta los terminos y condiciones y Contrato de profeco al mismo tiempo");
            }
            else if(txtNumTelefono.Text.Length <= 9 || txtNumTelefono.Text.Length >= 11)
            {
                MessageBox.Show("El numero de telefono es a 10 dijitos");
            }
            else
            {
                modTab.InsertarCliente(txtNomCliente.Text, txtDireccion.Text, txtNumTelefono.Text, txtNumTelReferencia.Text, txtEmail.Text, checkAvisoPriv, checkContratoPROF, ref mensaje, servidorSQL, bd);
                MessageBox.Show(mensaje);
                frmOrdenServ.cmbCliente.Items.Clear();
                vis.MostrarDatosDataReader(frmOrdenServ.cmbCliente, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), frmOrdenServ.consultaCliente));
                cn.Close();
                cn.Dispose();
                this.Close();
            }   
        }
        private void btnBuscarFirma_Click(object sender, EventArgs e)
        {
            vis.CargarImagen(pBFirma);
        }

        private void lblContratoProfeco_Click(object sender, EventArgs e)
        {
            FormContratoP frmContP = new FormContratoP();
            frmContP.Show();
        }
    }
}
