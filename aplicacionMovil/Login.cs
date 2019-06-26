using aplicacionMovil.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aplicacionMovil
{
    public class Login : ContentPage
    {
        //DEFINO LOS DATOS A MANEJAR
        public static Entry entryUser { get; set; }
        Entry entryPass;
        Label labelRegistrarUsuario;
        Label labelRecuperarContraseña;
        Switch switch_login;
        TapGestureRecognizer tapRegistrarUsuario = new TapGestureRecognizer();
        TapGestureRecognizer tapRecuperarContraseña = new TapGestureRecognizer();

        ActivityIndicator activity = new ActivityIndicator();

        public Login()
        {
            switch_login = new Switch();
            //CREACION DE LOS EVENTOS ENTRE PAGINAS
            //  TapGestureRecognizer tapLogin = new TapGestureRecognizer();



            // 1. LAYOUT (VIEW DEL LOGIN)
            StackLayout viewLogin = new StackLayout();
            ScrollView scrollLogin = new ScrollView();

            // 2. CREACION DE CONTROLES
            Label labelTitle = new Label();
            entryUser = new Entry();
            entryPass = new Entry();
            Button btnLogin = new Button();
            labelRegistrarUsuario = new Label();
            labelRecuperarContraseña = new Label();


            // 3. PROPIEDADES DE LOS CONTROLES
            scrollLogin.BackgroundColor = Color.FromHex("#FF007ACC");

            viewLogin.VerticalOptions = LayoutOptions.CenterAndExpand;
            viewLogin.HorizontalOptions = LayoutOptions.CenterAndExpand;

            labelTitle.BackgroundColor = Color.Black;
            labelTitle.TextColor = Color.White;
            labelTitle.VerticalTextAlignment = TextAlignment.Center;
            labelTitle.HorizontalTextAlignment = TextAlignment.Center;
            labelTitle.FontSize = 20;
            labelTitle.Text = "**  LOGIN  **";


            entryUser.Placeholder = "Usuario";
            entryUser.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryUser.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryUser.WidthRequest = 355;
            entryUser.Text = "";

            entryPass.Placeholder = "Contraseña";
            entryPass.IsPassword = true;
            entryPass.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryPass.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryPass.WidthRequest = 355;
            entryPass.Text = "";

           // activity.IsEnabled = false;
            activity.IsRunning = true;
            activity.IsVisible = false;

            
            btnLogin.Text = "Ingresa";
            btnLogin.BackgroundColor = Color.LightGray;
            btnLogin.TextColor = Color.Black;
            btnLogin.Clicked += BtnLogin_Clicked1;
            


            labelRegistrarUsuario.FontSize = 16;
            labelRegistrarUsuario.TextColor = Color.White;
            labelRegistrarUsuario.VerticalTextAlignment = TextAlignment.Center;
            labelRegistrarUsuario.HorizontalTextAlignment = TextAlignment.Center;
            labelRegistrarUsuario.Text = "Crear Cuenta";

            tapRegistrarUsuario.Tapped += TapRegistrarUsuario_Tapped;
            labelRegistrarUsuario.GestureRecognizers.Add(tapRegistrarUsuario);


            labelRecuperarContraseña.FontSize = 16;
            labelRecuperarContraseña.TextColor = Color.White;
            labelRecuperarContraseña.VerticalTextAlignment = TextAlignment.Center;
            labelRecuperarContraseña.HorizontalTextAlignment = TextAlignment.Center;
            labelRecuperarContraseña.Text = "Recuperar Contraseña";

            tapRecuperarContraseña.Tapped += TapRecuperarContraseña_Tapped;
            labelRecuperarContraseña.GestureRecognizers.Add(tapRecuperarContraseña);



            // 4. SE AGREGA EL CONTENIDO O CONTROLES A LA VISTA/LAYOUT
            viewLogin.Children.Add(labelTitle);
            viewLogin.Children.Add(entryUser);
            viewLogin.Children.Add(entryPass);
            viewLogin.Children.Add(activity);
            viewLogin.Children.Add(switch_login);
            viewLogin.Children.Add(btnLogin);
            viewLogin.Children.Add(labelRegistrarUsuario);
            viewLogin.Children.Add(labelRecuperarContraseña);


            // 5. EL CONTENIDO ES VISUALIZADO EN EL STACKLAYOUT
            scrollLogin.Content = viewLogin;
            Content = scrollLogin;
        }


        //EVENTO RECUPERAR CONTRASEÑA
        private async void TapRecuperarContraseña_Tapped(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryUser.Text))
            {
                await DisplayAlert("Validacion", "Campo de usuario Vacio", "Aceptar");
                return;
            }

            //recuperarContraseña recuperar = new recuperarContraseña();


            await Navigation.PushAsync(new recuperarContraseña());
            recuperarContraseña.entryUser1.Text = entryUser.Text;

        }


        //EVENTO REGISTRAR USUARIO
        private async void TapRegistrarUsuario_Tapped(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new registrarUsuario());

        }

        private async void BtnLogin_Clicked1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryUser.Text))
            {
                await DisplayAlert("Validacion", "Campo de usuario Vacio", "Aceptar");
                return;
            }

            if (switch_login.IsToggled)
            {

                await Navigation.PushAsync(new PaginaEstudiantes());
            }

            else { await Navigation.PushAsync(new PaginaDocentes()); }


            //activity.IsVisible = true;
            //await Task.Delay(1000);
            //IServicios servicios = DependencyService.Get<IServicios>();
            //var responseServer = await servicios.Estudiante(1);
            //activity.IsVisible = false;

            //if (responseServer == null) return;

            //if(responseServer.success !=0)
            //{
            //    var potsman = responseServer.data;
            //    await DisplayAlert("Acceso", responseServer.message, "Ok");
            //    await Navigation.PushAsync(new paginaPrincipal(responseServer.data.do_id));
            //    Navigation.RemovePage(this);
            //}
            //else
            //{
            //    await DisplayAlert("Acceso", responseServer.message, "Ok");
            //}

        }
   
        }
}
