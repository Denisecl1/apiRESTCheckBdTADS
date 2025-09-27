using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiRESTCheckBdTADS.Models
{
    //modelo de saida de la API
    public class clsApiStatus
    {
        // Estado de ejecución del endpoint (método)
        public bool statusExec { get; set; }
        // Descripción del resultado de tipo boleano si o no 
        public string msg { get; set; }
        // Código de ejecución del endpoint (método) mensaje al usuario
        public int ban { get; set; }
        // Objeto Json para envío de datos status de salida del mensaje 
        public JObject datos { get; set; }
    }
}