using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacionMovil.Modelos
{
    public class Data
    {
        public int do_id {get; set;}
        public string do_nombre { get; set; }
        public string do_apellido { get; set; }
        public string do_email { get; set; }
    }

    public class responseData : messageDefault 
    {
        public Data data { get; set; }
    }

    public class messageDefault
    {
        public int success { get; set; }
        public int responseCode { get; set; }
        public string message { get; set; }
    }

}
