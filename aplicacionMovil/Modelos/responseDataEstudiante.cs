using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace aplicacionMovil.Modelos
{

    public class Data1
    {
        public int est_id { get; set; }
        public string est_nombre { get; set; }
        public string est_apellido { get; set; }
        public string ce_primera_nota { get; set; }
        public string ce_segunda_nota { get; set; }
        public string ce_tercera_nota { get; set; }
        public string ce_semestre { get; set; }
        public string car_nombre { get; set; }
        public string car_jornada { get; set; }

    }

    public class responseDataEstudiante : messageDefault
    {

        public  List<Data1> data { get; set; }

    }

    public class messageDefault1
    {
        public int success { get; set; }
        public int responseCode { get; set; }
        public string message { get; set; }
    }
}

