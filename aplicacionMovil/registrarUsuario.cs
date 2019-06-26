using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace aplicacionMovil
{
    public class registrarUsuario : ContentPage
    {
        /*
        Entry entryNombre;
        Entry entryApellido;
        Entry entryCurso;
        Entry entryFecha;
        Entry entryDireccion;
        Entry entryCorreo;
        Entry entryPassword;
        Entry entryCodigo;
        Entry entryCedula;
        Entry entryTelefono;
        */
        public static Entry entryNombre { get; set; }
        public static Entry entryApellido { get; set; }
        public static Entry entryCorreo { get; set; }
        public static Entry entryPassword { get; set; }
        public static Entry entryCurso { get; set; }
        public static Entry entryFecha { get; set; }
        public static Entry entryDireccion { get; set; }
        public static Entry entryCodigo { get; set; }
        public static Entry entryCedula { get; set; }
        public static Entry entryTelefono { get; set; }
        //Button btnCrear;


        public registrarUsuario()
        {
            StackLayout viewCrearUsuario = new StackLayout();
            ScrollView scrollCrearUsuario = new ScrollView();

            Label labelTitle = new Label();
            entryNombre = new Entry();
            entryApellido = new Entry();
            entryCorreo = new Entry();
            entryPassword = new Entry();
            entryTelefono = new Entry();
            entryFecha = new Entry();
            entryCedula = new Entry();
            entryCodigo = new Entry();
            entryCurso = new Entry();
            entryDireccion = new Entry();

            Button btnCrear = new Button();

            viewCrearUsuario.VerticalOptions = LayoutOptions.CenterAndExpand;
            scrollCrearUsuario.HorizontalOptions = LayoutOptions.FillAndExpand;

            scrollCrearUsuario.BackgroundColor = Color.FromHex("#FF007ACC");

            labelTitle.BackgroundColor = Color.Black;
            labelTitle.TextColor = Color.White;
            labelTitle.VerticalTextAlignment = TextAlignment.Center;
            labelTitle.HorizontalTextAlignment = TextAlignment.Center;
            labelTitle.FontSize = 20;
            labelTitle.Text = "**  REGISTRAR USUARIO  **";

            entryNombre.Placeholder = "Nombre";
            entryNombre.TextColor = Color.LightGray;
            entryNombre.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryNombre.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryNombre.WidthRequest = 355;

            entryApellido.Placeholder = "Apellido";
            entryApellido.TextColor = Color.LightGray;
            entryApellido.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryApellido.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryApellido.WidthRequest = 355;


            entryCorreo.Placeholder = "Correo";
            entryCorreo.TextColor = Color.LightGray;
            entryCorreo.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryCorreo.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryCorreo.WidthRequest = 355;

            entryPassword.Placeholder = "Password";
            entryPassword.TextColor = Color.LightGray;
            entryPassword.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryPassword.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryPassword.WidthRequest = 355;

            entryTelefono.Placeholder = "Telefono";
            entryTelefono.TextColor = Color.LightGray;
            entryTelefono.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryTelefono.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryTelefono.WidthRequest = 355;

            entryFecha.Placeholder = "Fecha";
            entryFecha.TextColor = Color.LightGray;
            entryFecha.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryFecha.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryFecha.WidthRequest = 355;

            entryCedula.Placeholder = "Cedula";
            entryCedula.TextColor = Color.LightGray;
            entryCedula.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryCedula.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryCedula.WidthRequest = 355;

            entryCodigo.Placeholder = "Codigo";
            entryCodigo.TextColor = Color.LightGray;
            entryCodigo.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryCodigo.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryCodigo.WidthRequest = 355;


            entryCurso.Placeholder = "Curso";
            entryCurso.TextColor = Color.LightGray;
            entryCurso.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryCurso.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryCurso.WidthRequest = 355;

            entryDireccion.Placeholder = "Direccion";
            entryDireccion.TextColor = Color.LightGray;
            entryDireccion.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryDireccion.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryDireccion.WidthRequest = 355;


            btnCrear.Text = "Ingresa";
            btnCrear.BackgroundColor = Color.LightGray;
            btnCrear.TextColor = Color.Black;

            btnCrear.Clicked += BtnCrear_Clicked;


            viewCrearUsuario.Children.Add(labelTitle);
            viewCrearUsuario.Children.Add(entryNombre);
           // viewCrearUsuario.Children.Add(entryApellido);
            viewCrearUsuario.Children.Add(entryCorreo);
            viewCrearUsuario.Children.Add(entryPassword);
            //viewCrearUsuario.Children.Add(entryTelefono);
            //viewCrearUsuario.Children.Add(entryFecha);
            //viewCrearUsuario.Children.Add(entryCedula);
            viewCrearUsuario.Children.Add(entryCodigo);
            viewCrearUsuario.Children.Add(entryCurso);
            //viewCrearUsuario.Children.Add(entryDireccion);

            viewCrearUsuario.Children.Add(btnCrear);

            scrollCrearUsuario.Content = viewCrearUsuario;
            Content = scrollCrearUsuario;
        }


        private async void BtnCrear_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryNombre.Text)
                 //|| string.IsNullOrEmpty((entryApellido.Text))
                 || (string.IsNullOrEmpty((entryCorreo.Text))
                 || (string.IsNullOrEmpty((entryPassword.Text))
                 //|| string.IsNullOrEmpty((entryTelefono.Text))
                 //|| string.IsNullOrEmpty((entryFecha.Text))
                 //|| string.IsNullOrEmpty((entryCedula.Text))
                 || string.IsNullOrEmpty((entryCodigo.Text))
                 || string.IsNullOrEmpty((entryCurso.Text))
                 //|| string.IsNullOrEmpty((entryDireccion.Text))
                 )))

            {

                await DisplayAlert("Modificacion", "Por favor Completar", "Aceptar");
                return;

            }
            await DisplayAlert("Notificacion", "Resgistro Exitoso", "Aceptar");
            await Navigation.PushAsync(new Login());
            Navigation.RemovePage(this);
            // Login.entryUser.Text = entryCorreo.Text;
            //  await Navigation.PushAsync(new paginaPrincipal())
            // paginaPrincipal.entryNombre.Text = entryNombre.Text;

            //else{

            Usuario usuario = new Usuario
            {
                Nombre = entryNombre.Text,
              //  Apellido = entryApellido.Text,
                Correo = entryCorreo.Text,
                Password = entryPassword.Text,
                //Telefono = entryTelefono.Text,
                //FechaNacimiento = entryFecha.Text,
               // Cedula = entryCedula.Text,
                Codigo = entryCodigo.Text,
                Curso = entryCurso.Text,
                //Direccion = entryDireccion.Text
            };

            //App.listaUsuarios.Add(usuario);

            entryNombre.Text = string.Empty;
           // entryApellido.Text = string.Empty;
            entryCorreo.Text = string.Empty;
            entryPassword.Text = string.Empty;
           // entryTelefono.Text = string.Empty;
           // entryFecha.Text = string.Empty;
           // entryCedula.Text = string.Empty;
            entryCodigo.Text = string.Empty;
            entryCurso.Text = string.Empty;
           // entryDireccion.Text = string.Empty;
        }

    }
}


