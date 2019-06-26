using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using aplicacionMovil.Droid;
using aplicacionMovil.Modelos;
using Newtonsoft.Json;
using RestSharp;
using Xamarin.Forms;


[assembly: Dependency(typeof(Servicios))]
namespace aplicacionMovil.Droid
{
    public class Servicios : IServicios
    {
        public Task<responseDataEstudiante> Estudiante(int id)
        {
            try
            {
                //RestClient Cliente = new RestClient("http://172.16.20.108/api");
                RestClient Cliente = new RestClient("http://localhost:50486/api/");
                RestRequest request = new RestRequest("ConsultaEstudiantes", Method.POST)
                { RequestFormat = DataFormat.Json };

                request.AddParameter("CEDULA", 1143);
                request.AddParameter("CORREO", "BAIRON@GMAIL.COM");


                var response = Cliente.Execute(request);
                //responseDataEstudiante contenido = JsonConvert.DeserializeObject<responseDataEstudiante>(response.Content);

                return null;

            }
            catch (Exception )
            {
                return null;
            }
        }

        public Task<responseData> Login(string entryUser, string entryPass)
        {
            try
            {
                //RestClient Cliente = new RestClient("http://172.16.20.108/api");
                RestClient Cliente = new RestClient("http://youis.000webhostapp.com/Project/Utap/api/");
                RestRequest request = new RestRequest("/utap0-0.php", Method.POST)
                { RequestFormat = DataFormat.Json };

                request.AddParameter("email", entryUser);
                request.AddParameter("password", entryPass);

                var response = Cliente.Execute(request);
                responseData contenido = JsonConvert.DeserializeObject<responseData>(response.Content);

                return Task.FromResult( contenido);

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}