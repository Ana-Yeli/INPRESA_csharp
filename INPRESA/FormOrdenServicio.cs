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
    public partial class FormOrdenServicio : Form
    {
        ModeloConnect modCon = new ModeloConnect();
        ModeloTable modTab = new ModeloTable();
        View vis = new View();
        string mensaje = "";
        string servidorSQL = @"DESKTOP-GKVD9EA";
        string bd = "INPRESAOF";

        public string consultaCliente = "select Nombre_Completo from Cliente";
        public string consultaTecnico = "select NombreTecnico from Tecnico";
        public string consultaVehiculo = "select NumSerie_VIN from Vehiculo";
        public FormOrdenServicio()
        {
            InitializeComponent();
            vis.MostrarDatosDataReader(cmbCliente, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), consultaCliente));
            vis.MostrarDatosDataReader(cmbTecnico, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), consultaTecnico));
            vis.MostrarDatosDataReader(cmbVehiculo, modCon.ObtenerDataReader(ref mensaje, modCon.Conectar(ref mensaje, servidorSQL, bd), consultaVehiculo));
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            lblidCliente.Text = ".....";
            cmbCliente.Text = "Selecciona";
            NewClient newc = new NewClient();
            AddOwnedForm(newc);
            newc.Show();
        }

        private void btnNewVehicle_Click(object sender, EventArgs e)
        {
            lblidVehiculo.Text = ".....";
            cmbVehiculo.Text = "Selecciona";
            NewVehicle newv = new NewVehicle();
            AddOwnedForm(newv);
            newv.Show();
        }

        private void btnAltaOrdenServicio_Click(object sender, EventArgs e)
        {
            if (cmbCliente.Text == "Selecciona" || cmbVehiculo.Text == "Selecciona" || cmbTecnico.Text == "Selecciona" || cmbNumService.Text == "" ||
                txtKilometraje.Text == "" || txtTrabRealizar.Text == "" || txtDiagYsolucion.Text == "" || cmbNivelGas.Text == "" || cmbLlavesEncendido.Text == ""
                || cmbEspejos.Text == "" || cmbBateria.Text == "" || cmbParabrisasMicas.Text == "" || cmbTaponGasolina.Text == "" || picIdentGolp1.Image == null
                || picIdentGolp2.Image == null || picIdentGolp3.Image == null || picIdentGolp4.Image == null || txtFechaEntrega.Text == "" || cmbEstatus.Text == "")
            {
                MessageBox.Show("Favor de rellenar los campos faltantes");
            }
            else if (cmbNivelGas.Text.Length>5)
            {
                MessageBox.Show("Solo puede introducir 5 letras");
            }
            else if (cmbLlavesEncendido.Text.Length>3 || cmbEspejos.Text.Length>3 || cmbBateria.Text.Length>3 || cmbParabrisasMicas.Text.Length>3 ||
                cmbTaponGasolina.Text.Length > 3)
            {
                MessageBox.Show("En el Cheklist solo puede poner SI o NO");
            }
            else
            {
                SqlConnection cn = null;
                cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
                modTab.InsertarOrdenServicio(cmbDatosCentroServicio.Text, DatepicFecha.Value, Convert.ToInt32(lblidCliente.Text), Convert.ToInt32(lblidVehiculo.Text), cmbNumService.Text, Convert.ToInt32(txtKilometraje.Text), txtTrabRealizar.Text, txtDiagYsolucion.Text, cmbNivelGas.Text, cmbLlavesEncendido.Text,
                    cmbEspejos.Text, cmbBateria.Text, cmbParabrisasMicas.Text, cmbTaponGasolina.Text, picIdentGolp1, picIdentGolp2, picIdentGolp3, picIdentGolp4, Convert.ToInt32(lblidTecnico.Text), txtFechaEntrega.Text, cmbEstatus.Text, ref mensaje, servidorSQL, bd);
                MessageBox.Show(mensaje);
                cn.Close();
                cn.Dispose();
                cmbCliente.Text = "Selecciona";
                cmbVehiculo.Text = "Selecciona";
                cmbTecnico.Text = "Selecciona";
                cmbNumService.Text = "";
                txtKilometraje.Text = "";
                txtTrabRealizar.Text = "";
                txtDiagYsolucion.Text = "";
                cmbNivelGas.Text = "";
                cmbLlavesEncendido.Text = "";
                cmbEspejos.Text = "";
                cmbBateria.Text = "";
                cmbParabrisasMicas.Text = "";
                cmbTaponGasolina.Text = "";
                picIdentGolp1.Image = null;
                picIdentGolp2.Image = null;
                picIdentGolp3.Image = null;
                picIdentGolp4.Image = null;
                txtFechaEntrega.Text = "";
                cmbEstatus.Text = "";
            }
            
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            vis.Mostrarid(lblidCliente, modTab.BuscaidCliente(ref mensaje, ref cn,cmbCliente.Text));
            cn.Close();
            cn.Dispose();
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            vis.Mostrarid(lblidVehiculo, modTab.BuscaidVehiculo(ref mensaje, ref cn, cmbVehiculo.Text));
            cn.Close();
            cn.Dispose();
        }

        private void cmbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = null;
            cn = modCon.Conectar(ref mensaje, servidorSQL, bd);
            vis.Mostrarid(lblidTecnico, modTab.BuscaidTecnico(ref mensaje, ref cn, cmbTecnico.Text));
            cn.Close();
            cn.Dispose();
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            vis.CargarImagen(picIdentGolp1);
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            vis.CargarImagen(picIdentGolp2);
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            vis.CargarImagen(picIdentGolp3);
        }

        private void btnAgregar4_Click(object sender, EventArgs e)
        {
            vis.CargarImagen(picIdentGolp4);
        }

    }
}
