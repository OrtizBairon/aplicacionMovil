using System;
using System.Collections.Generic;
using System.Text;

namespace aplicacionMovil.Modelos
{
    public class Estudiantes
    {

        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Apellido { get {


                return Nombre +" "+ Apellido; 
            }
        } 
        public string Email { get; set; }
        public Notas Notas { get; set; }


    }

    public class Notas
    {

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }


        public double Notafinal
        {
            get
            {
                double result = (Nota1 * 0.3 + Nota2 * 0.3 + Nota3 * 0.4);

                return result;
            }


        }
    }
}