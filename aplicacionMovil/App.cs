using aplicacionMovil.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace aplicacionMovil
{

    public class App : Application
    {
        public static List<Estudiantes> listaEstudiantes;

        public App()
        {

            listaEstudiantes = new List<Estudiantes>();
            llenadolocal();

            //Login _page = new Login(listaUsuarios);
            MainPage = new NavigationPage(new Login());
        }

        public void llenadolocal()
        {

            Estudiantes estudianteuno = new Estudiantes
            {
                Cedula = 11233,
                Nombre = "bairon",
                Apellido = "Ortiz",
                Email = "bairon@gmail.com",
                Notas = new Notas
                {
                    Nota1 = 4.0,
                    Nota2 = 4.5,
                    Nota3 = 3.8


                }

            };

            Estudiantes estudiantedos = new Estudiantes
            {
                Cedula = 11233,
                Nombre = "oscar",
                Apellido = "Ortiz",
                Email = "oscar@gmail.com",
                Notas = new Notas
                {
                    Nota1 = 5.0,
                    Nota2 = 3.5,
                    Nota3 = 2.8


                }

            };

            Estudiantes estudiantetres = new Estudiantes
            {
                Cedula = 11233,
                Nombre = "pedro",
                Apellido = "Ortiz",
                Email = "pedro@gmail.com",
                Notas = new Notas
                {
                    Nota1 = 4.0,
                    Nota2 = 3.5,
                    Nota3 = 3.0


                }

            };

            listaEstudiantes.Add(estudianteuno);
            listaEstudiantes.Add(estudiantedos);
            listaEstudiantes.Add(estudiantetres);

        }


    }
}