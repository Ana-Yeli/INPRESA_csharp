using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPRESA
{
    class View
    {
        public void ImprimirMensajes(ref string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        public void CargarImagen(PictureBox pic)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:/Users/newya/OneDrive";
            dialog.Title = "Select image to be upload.";
            dialog.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            dialog.FilterIndex = 1;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pic.Image = Image.FromFile(dialog.FileName);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public void MostrarDatosDataReader(ComboBox cmb, System.Data.SqlClient.SqlDataReader contenedor)
        {
            while (contenedor.Read() == true)
            {
                cmb.Items.Add(contenedor[0]);
            }
        }
        public void Mostrarid(Label lblid/*TextBox txtid*/, System.Data.SqlClient.SqlDataReader contenedor)
        {
            while (contenedor.Read())
            {
                lblid.Text = contenedor[0].ToString();
                //txtid.Text=contenedor[0].ToString();
            }
        }
        public void MostraridEmail(Label lblid, Label lblEmail, System.Data.SqlClient.SqlDataReader contenedor)
        {
            while (contenedor.Read())
            {
                lblid.Text = contenedor[0].ToString();
                lblEmail.Text = contenedor[1].ToString();

            }
        }
        public void MostrarDatosOrdenDeServicio(Label lblDatosCenServicio, Label lblFecha, Label lblNomCliente, Label lblNumCliente, Label lblDirCliente, Label lblTipoVehiculo, Label lblMarca,
            Label lblModelo, Label lblNoSerie, Label lblPlacas, Label lblKilometraje, Label lblColor, Label lblNumServicio, Label lblTrabArea, Label lblDiagnostico, Label lblLavesEncendido,
            Label lblEspejos, Label lblBateria, Label lblParabrisas, Label lblTaponGasolina,/* PictureBox img1, PictureBox img2, PictureBox img3, PictureBox img4*/ Label lblNivelGas,
            Label lblTecnico, Label lblFechaEntrega, ComboBox lblEstatus, System.Data.SqlClient.SqlDataReader contenedor)
        {
            SqlCommand carrito = new SqlCommand();
            MemoryStream ms = new MemoryStream(); 
            while (contenedor.Read())
            {
                lblDatosCenServicio.Text = contenedor[0].ToString();
                lblFecha.Text = contenedor[1].ToString();
                lblNomCliente.Text = contenedor[2].ToString();
                lblNumCliente.Text = contenedor[3].ToString();
                lblDirCliente.Text = contenedor[4].ToString();
                lblTipoVehiculo.Text = contenedor[5].ToString();
                lblMarca.Text = contenedor[6].ToString();
                lblModelo.Text = contenedor[7].ToString();
                lblNoSerie.Text = contenedor[8].ToString();
                lblPlacas.Text = contenedor[9].ToString();
                lblKilometraje.Text = contenedor[10].ToString();
                lblColor.Text = contenedor[11].ToString();
                lblNumServicio.Text = contenedor[12].ToString();
                lblTrabArea.Text = contenedor[13].ToString();
                lblDiagnostico.Text = contenedor[14].ToString();
                lblLavesEncendido.Text = contenedor[15].ToString();
                lblEspejos.Text = contenedor[16].ToString();
                lblBateria.Text = contenedor[17].ToString();
                lblParabrisas.Text = contenedor[18].ToString();
                lblTaponGasolina.Text = contenedor[19].ToString();
                lblNivelGas.Text = contenedor[24].ToString();
                lblTecnico.Text = contenedor[25].ToString();
                lblFechaEntrega.Text = contenedor[26].ToString();
                lblEstatus.Text = contenedor[27].ToString();
             }
        }
    }
}
