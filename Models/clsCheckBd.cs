using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using apiRESTCheckBdTADS.Models;    
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;  
using System.Configuration;

namespace apiRESTCheckBdTADS.Models
{
    public class clsCheckBd
    {
        //Definicion del atributo privado Conexion
        private String cadConn = ConfigurationManager.ConnectionStrings["bdControlAcceso"].ConnectionString;
        //definicion de atributos de salida
        public string statusMsg;
        public int ban;

        //Definicion del metododo de conexion a MySQL
        public void checkBd()
        {
            try
            {
               MySqlConnection conn = new MySqlConnection(cadConn);
                conn.Open();
                conn.Close();
                // conexion exitosa , enviar salida
                ban = 1;
                statusMsg = "Conexión exitosa a la base de datos.";
            }
            catch (Exception ex)
            {
                // error de conexion , enviar salida
                ban = 0;
                statusMsg = ex.Message.ToString();

            }

        }
    }
}