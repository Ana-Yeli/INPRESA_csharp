using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPRESA
{
    class ModeloConnect
    {
        public SqlConnection Conectar(ref string mensaje, string servidorSQL, string bd)
        {
            SqlConnection Carretera = new SqlConnection();
            Carretera.ConnectionString = "data source=" + servidorSQL + "; Initial Catalog=" + bd + "; Integrated Security=true";
            try
            {
                Carretera.Open();
                mensaje = "Conexión Abierta :)";
            }
            catch (Exception t)
            {
                Carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
            return Carretera;
        }
        public void Insertar_y_Actualizar_Registro_Foto(SqlConnection carretera, ref string mensaje,
            string sentenciaSQL, System.Windows.Forms.PictureBox img)
        {
            SqlCommand carrito = new SqlCommand();
            try
            {
                carrito.Connection = carretera;
                carrito.CommandText = sentenciaSQL;
                carrito.Parameters.Add("@foto", System.Data.SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                img.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                carrito.Parameters["@foto"].Value = ms.GetBuffer();
                int x = carrito.ExecuteNonQuery();
                mensaje = "Éxito";
                carretera.Close();
            }
            catch (Exception e)
            {
                carretera = null;
                mensaje = "ERROR: " + e.Message;
            }
        }
        public void Insertar_y_Actualizar_OrdenServicio(SqlConnection carretera, ref string mensaje,
            string sentenciaSQL, System.Windows.Forms.PictureBox img1, System.Windows.Forms.PictureBox img2,
            System.Windows.Forms.PictureBox img3, System.Windows.Forms.PictureBox img4)
        {
            SqlCommand carrito = new SqlCommand();
            try
            {
                carrito.Connection = carretera;
                carrito.CommandText = sentenciaSQL;

                MemoryStream ms1 = new MemoryStream();
                carrito.Parameters.Add("@foto1", System.Data.SqlDbType.Image);
                img1.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                carrito.Parameters["@foto1"].Value = ms1.GetBuffer();

                MemoryStream ms2 = new MemoryStream();
                carrito.Parameters.Add("@foto2", System.Data.SqlDbType.Image);
                img2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                carrito.Parameters["@foto2"].Value = ms2.GetBuffer();

                MemoryStream ms3 = new MemoryStream();
                carrito.Parameters.Add("@foto3", System.Data.SqlDbType.Image);
                img3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg);
                carrito.Parameters["@foto3"].Value = ms3.GetBuffer();

                MemoryStream ms4 = new MemoryStream();
                carrito.Parameters.Add("@foto4", System.Data.SqlDbType.Image);
                img4.Image.Save(ms4, System.Drawing.Imaging.ImageFormat.Jpeg);
                carrito.Parameters["@foto4"].Value = ms4.GetBuffer();

                int x = carrito.ExecuteNonQuery();
                mensaje = "Éxito";
                carretera.Close();
            }
            catch (Exception e)
            {
                carretera = null;
                mensaje = "ERROR: " + e.Message;
            }
        }
        public void InsertarRegistro(SqlConnection carretera, ref string mensaje, string sentenciaSQL)
        {
            SqlCommand carrito = new SqlCommand();
            try
            {
                carrito.CommandText = sentenciaSQL;
                carrito.Connection = carretera;
                int x = carrito.ExecuteNonQuery();
                mensaje = "Éxito";
                carretera.Close();
            }
            catch (Exception t)
            {
                carretera = null;
                mensaje = "ERROR: " + t.Message;
            }
        }
        public SqlDataReader ObtenerDataReader(ref string mensaje, SqlConnection carretera, string consulta)
        {
            SqlCommand carrito = new SqlCommand();
            SqlDataReader contenedor;
            try
            {
                carrito.Connection = carretera;
                carrito.CommandText = consulta;
                contenedor = carrito.ExecuteReader();
                mensaje = "Consulta Realizada";
            }
            catch (Exception t)
            {
                contenedor = null;
                mensaje = t.Message;
            }
            return contenedor;
        }
        public System.Data.DataSet ConsultaDataSet(SqlConnection cna, string consulta, ref String mensaje, System.Windows.Forms.PictureBox img)
        {
            System.Data.DataSet contenedor = new System.Data.DataSet();
            SqlCommand carrito = new SqlCommand();
            SqlDataAdapter trailer = new SqlDataAdapter();
            DataSet ds = new DataSet();

            carrito.Connection = cna;
            carrito.CommandText = consulta;
            trailer.SelectCommand = carrito;

            byte[] MisFotos = new byte[0];

            try
            {
                trailer.Fill(contenedor, "OrdenDeServicio");
                DataRow myRow = ds.Tables["OrdenDeServicio"].Rows[0];
                MisFotos = (byte[])myRow["IdentGolpes1"];
                MemoryStream ms = new MemoryStream(MisFotos);
                img.Image = Image.FromStream(ms);
                mensaje = "Consulta correcta DataSet";
            }
            catch (Exception t)
            {
                contenedor = null;
                mensaje = "ERROR: " + t.Message;
            }
            cna.Close();
            cna.Dispose();
            return contenedor;
        }
    }
}
