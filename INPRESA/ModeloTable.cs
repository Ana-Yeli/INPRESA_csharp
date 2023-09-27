using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INPRESA
{
    class ModeloTable
    {
        private ModeloConnect modCon = new ModeloConnect();
        string mensaje = "";
        public void InsertarClienteConFoto(string nomCliente,string Direccion, string NumTelefono, string NumTelRef, string Email, System.Windows.Forms.CheckBox AvisoPrivacidad, System.Windows.Forms.CheckBox ContratoProfeco, System.Windows.Forms.PictureBox img,
            ref string mens, string servidorSQL, string bd)
        {
            SqlConnection carretera = null;
            carretera = modCon.Conectar(ref mens, servidorSQL, bd);
            string AvisoP;
            string ContratoP;
            if (AvisoPrivacidad.Checked == true)
            {
                if (ContratoProfeco.Checked == true)
                {
                    AvisoP = "Acepto";
                    ContratoP = "Acepto";
                    string sentenciaSQL =
                    "insert into Cliente(Nombre_Completo, Direccion, NumeroTelefono, NumeroReferencia, Email, AvisoPrivacidad, ContratoProfeco, Firma)" +
                    " values('" + nomCliente + "', '" + Direccion + "', '" + NumTelefono + "', '" + NumTelRef + "', '" + Email + "', '" + AvisoP + "','" + ContratoP + "', @foto);";
                    modCon.Insertar_y_Actualizar_Registro_Foto(carretera, ref mens, sentenciaSQL, img);
                }
            }
        }
        public void InsertarCliente(string nomCliente, string Direccion, string NumTelefono, string NumTelRef, string Email, System.Windows.Forms.CheckBox AvisoPrivacidad, System.Windows.Forms.CheckBox ContratoProfeco,
            ref string mens, string servidorSQL, string bd)
        {
            SqlConnection carretera = null;
            carretera = modCon.Conectar(ref mens, servidorSQL, bd);
            string AvisoP;
            string ContratoP;
            if (AvisoPrivacidad.Checked == true)
            {
                if (ContratoProfeco.Checked == true)
                {
                    AvisoP = "Acepto";
                    ContratoP = "Acepto";
                    string sentenciaSQL =
                    "insert into Cliente(Nombre_Completo, Direccion, NumeroTelefono, NumeroReferencia, Email, AvisoPrivacidad, ContratoProfeco)" +
                    " values('" + nomCliente + "', '" + Direccion + "', '" + NumTelefono + "', '" + NumTelRef + "', '" + Email + "', '" + AvisoP + "','" + ContratoP + "');";
                    modCon.InsertarRegistro(carretera, ref mens, sentenciaSQL);
                }
            }
        }
        public SqlDataReader BuscaidCliente(ref string mens, ref SqlConnection conexion, string NomClien)
        {
            SqlDataReader cajatemp = null;
            string consulta = "select idCliente from Cliente where Nombre_Completo = '" + NomClien + "'";
            cajatemp = modCon.ObtenerDataReader(ref mens, conexion, consulta);
            return cajatemp;
        }
        public void InsertarVehiculo(int idCliente, string TipoVehiculo, string Marca, string Modelo, string NumSerie_VIN, string Placas, string Color,
            ref string mens, string servidorSQL, string bd)
        {
            SqlConnection carretera = null;
            carretera = modCon.Conectar(ref mens, servidorSQL, bd);
            string sentenciaSQL =
            "insert into Vehiculo(idCliente, TipoVehiculo, Marca, Modelo, NumSerie_VIN,Placas, Color)" +
            " values(" + idCliente + ", '" + TipoVehiculo + "', '" + Marca + "', '" + Modelo + "', '" + NumSerie_VIN + "', '" + Placas + "','" + Color + "');";
            modCon.InsertarRegistro(carretera, ref mens, sentenciaSQL);
        }
        public SqlDataReader BuscaidClienteEmail(ref string mens, ref SqlConnection conexion, string NomClien)
        {
            SqlDataReader cajatemp = null;
            string consulta = "select Cliente.idCliente, Cliente.Email from Cliente where Cliente.Nombre_Completo='" + NomClien + "' ";
            cajatemp = modCon.ObtenerDataReader(ref mens, conexion, consulta);
            return cajatemp;
        }
        public SqlDataReader BuscaidVehiculo(ref string mens, ref SqlConnection conexion, string NumSerie)
        {
            SqlDataReader cajatemp = null;
            string consulta = "select idVehiculo from Vehiculo where NumSerie_VIN='" + NumSerie + "' ";
            cajatemp = modCon.ObtenerDataReader(ref mens, conexion, consulta);
            return cajatemp;
        }
        public SqlDataReader BuscaNumVinDdVehiculo(ref string mens, ref SqlConnection conexion, int id)
        {
            SqlDataReader cajatemp = null;
            string consulta = "select Vehiculo.NumSerie_VIN from Vehiculo where idCliente = " + id + " ";
            cajatemp = modCon.ObtenerDataReader(ref mens, conexion, consulta);
            return cajatemp;
        }
        public SqlDataReader BuscaidTecnico(ref string mens, ref SqlConnection conexion, string NomTecnico)
        {
            SqlDataReader cajatemp = null;
            string consulta = "select idTecnico from Tecnico where NombreTecnico='" + NomTecnico + "' ";
            cajatemp = modCon.ObtenerDataReader(ref mens, conexion, consulta);
            return cajatemp;
        }
        public void InsertarOrdenServicio( string DatosCentroServicio, DateTime datePicFecha, int idCliente, int idVehiculo, string NumServ, int kilometraje, string trabArealizar,
            string diagnosYsol, string nivelgas, string llavesEncen, string espejos, string bateria, string parabrisasmicas, string tapongasolina,
            System.Windows.Forms.PictureBox img1, System.Windows.Forms.PictureBox img2, System.Windows.Forms.PictureBox img3, System.Windows.Forms.PictureBox img4,
            int idTecnico, string FechaEntrega, string estatus, ref string mens, string servidorSQL, string bd)
        {
            SqlConnection carretera = null;
            carretera = modCon.Conectar(ref mens, servidorSQL, bd);
            string format = "yyyy-MM-dd HH:mm:ss";
            string sentenciaSQL =
            "insert into OrdenDeServicio(DatosCentroServicio, Fecha, idCliente, idVehiculo, NumServicio, Kilometraje, TrabajosArealizar, DiagnosticoYSolucion, NivelGasolina, LlavesEncendido, Espejos, Bateria, Parabrisas_Micas, TaponGasolina, IdentGolpes1, IdentGolpes2, IdentGolpes3, IdentGolpes4, idTecnico, FechaPEntrega, Estatus) " +
            " values('" + DatosCentroServicio + "',' " + datePicFecha.ToString(format) + "', " + idCliente + ", " + idVehiculo + ", '" + NumServ + "', " + kilometraje + ",'" + trabArealizar + "','" + diagnosYsol + "','" + nivelgas + "','" + llavesEncen + "','" + espejos + "','" + bateria + "','" + parabrisasmicas + "','" + tapongasolina + "',@foto1, @foto2, @foto3, @foto4," + idTecnico + ",'" + FechaEntrega + "','" + estatus + "');";
                    modCon.Insertar_y_Actualizar_OrdenServicio(carretera, ref mens, sentenciaSQL, img1, img2, img3, img4);
        }
        public SqlDataReader BuscaDatosOrdenServ(ref string mens, ref SqlConnection conexion, int idOrden, PictureBox img)
        {
            SqlDataReader cajatemp = null;
            string consulta = " Select OrdenDeServicio.DatosCentroServicio, OrdenDeServicio.Fecha, Cliente.Nombre_Completo, Cliente.NumeroTelefono, Cliente.Direccion, Vehiculo.TipoVehiculo as Vehiculo, Vehiculo.Marca, Vehiculo.Modelo, Vehiculo.NumSerie_VIN, Vehiculo.Placas, OrdenDeServicio.Kilometraje, Vehiculo.Color, OrdenDeServicio.NumServicio, OrdenDeServicio.TrabajosArealizar, OrdenDeServicio.DiagnosticoYSolucion, OrdenDeServicio.LlavesEncendido, OrdenDeServicio.Espejos, OrdenDeServicio.Bateria, OrdenDeServicio.Parabrisas_Micas, OrdenDeServicio.TaponGasolina, OrdenDeServicio.IdentGolpes1, OrdenDeServicio.IdentGolpes2, OrdenDeServicio.IdentGolpes3, OrdenDeServicio.IdentGolpes4, OrdenDeServicio.NivelGasolina, Tecnico.NombreTecnico as Tecnico, OrdenDeServicio.FechaPEntrega, OrdenDeServicio.Estatus from Cliente inner join OrdenDeServicio on Cliente.idCliente = OrdenDeServicio.idCliente inner join Vehiculo on Vehiculo.idVehiculo = OrdenDeServicio.idVehiculo inner join Tecnico on Tecnico.idTecnico = OrdenDeServicio.idTecnico where OrdenDeServicio.idOrdenDeServicio = " + idOrden + "";
            cajatemp = modCon.ObtenerDataReader(ref mens, conexion, consulta);
            return cajatemp;
        }
        public void ActualizarOrdenDservicio(string Estatus, int id, ref string mens, string servidorSQL, string bd)
        {
            SqlConnection carretera = null;
            carretera = modCon.Conectar(ref mens, servidorSQL, bd);
            string sentenciaSQL = "update OrdenDeServicio set Estatus = " + "'" + Estatus + "' where idOrdenDeServicio = " + "" + id;
            modCon.InsertarRegistro(carretera, ref mens, sentenciaSQL);
        }
        public void InsertarCita(int idCliente, DateTime datePicFecha, DateTime datePicHora, string MotivoCita,
            ref string mens, string servidorSQL, string bd)
        {
            SqlConnection carretera = null;
            carretera = modCon.Conectar(ref mens, servidorSQL, bd);
            string fecha = "yyyy-MM-dd";
            string hora = "HH:mm:ss";
            string sentenciaSQL =
             "insert into Cita(idCliente, Fecha, Hora, MotivoCita)" +
             " values(" + idCliente + ", '" + datePicFecha.ToString(fecha) + "', '" + datePicHora.ToString(hora) + "', '" + MotivoCita + "');";
             modCon.InsertarRegistro(carretera, ref mens, sentenciaSQL);
        }
        

    }
}