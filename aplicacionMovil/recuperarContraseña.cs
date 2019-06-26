using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace aplicacionMovil
{
    public class recuperarContraseña : ContentPage
    {
        public static Entry entryUser1 { get; set; }



        public recuperarContraseña()
        {

            StackLayout viewRecovery = new StackLayout();
            ScrollView scrollRecovery = new ScrollView();

            Label labelTitle = new Label();


            entryUser1 = new Entry();
            //entryUser1 = Login.entryUser;
            Button btnRepass = new Button();


            scrollRecovery.BackgroundColor = Color.FromHex("#FF007ACC");

            viewRecovery.VerticalOptions = LayoutOptions.CenterAndExpand;
            viewRecovery.HorizontalOptions = LayoutOptions.CenterAndExpand;

            labelTitle.BackgroundColor = Color.Black;
            labelTitle.TextColor = Color.White;
            labelTitle.VerticalTextAlignment = TextAlignment.Center;
            labelTitle.HorizontalTextAlignment = TextAlignment.Center;
            labelTitle.FontSize = 20;
            labelTitle.Text = "**  RECUPERAR PASSWORD  **";


            entryUser1.Text = "";
            entryUser1.Placeholder = "Usuario";
            entryUser1.VerticalOptions = LayoutOptions.CenterAndExpand;
            entryUser1.HorizontalOptions = LayoutOptions.CenterAndExpand;
            entryUser1.WidthRequest = 355;







            btnRepass.Text = "Aceptar";
            btnRepass.BackgroundColor = Color.LightGray;
            btnRepass.TextColor = Color.Black;


            viewRecovery.Children.Add(labelTitle);
            viewRecovery.Children.Add(entryUser1);
            viewRecovery.Children.Add(btnRepass);

            scrollRecovery.Content = viewRecovery;
            Content = scrollRecovery;


        }
    }
}