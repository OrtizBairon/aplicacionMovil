using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionMovil.Modelos
{
    public interface IServicios
    {
        // responseData Login();
        // void GetData(); //Traer informacion de los estudiantes
        Task<responseData> Login(string entryUser, string entryPass);
        Task<responseDataEstudiante> Estudiante(int id);
    }
}
