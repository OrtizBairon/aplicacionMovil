using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace aplicacionMovil
{
    public class MyViewCell : ViewCell
    {
       

        public MyViewCell()
        {
            

            StackLayout viewTexto = new StackLayout
            {
                BackgroundColor = Color.Transparent,
                Spacing = 0,
                Padding = 0,
                
            };

            StackLayout viewGeneral = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.Azure,
                Padding = 0,
                
            };
            
            

            Image imagenAvatar = new Image
            {
                //Source = ImageSource.FromFile("fotoPerfil.jpg"),
                Source= "fotoPerfil.jpg",
                Aspect = Aspect.AspectFit,
                WidthRequest = 90,
                HeightRequest = 90,
              //  BackgroundColor = Color.Yellow
            };

            Label est_nombre = new Label { Text = "", FontSize = 9 };
            Label est_apellido = new Label { Text = "", FontSize = 9 };
            Label ce_primera_nota = new Label { Text = "", FontSize = 9 };
            Label ce_segunda_nota = new Label { Text = "", FontSize = 9 };
            Label ce_tercera_nota = new Label { Text = "", FontSize = 9 };
            Label ce_semestre = new Label { Text = "", FontSize = 9 };
            Label car_nombre = new Label { Text = "", FontSize = 9 };
            Label car_jornada = new Label { Text = "", FontSize = 9 };


            est_nombre.SetBinding(Label.TextProperty, new Binding("est_nombre"));
            est_apellido.SetBinding(Label.TextProperty, new Binding("est_apellido"));
            ce_primera_nota.SetBinding(Label.TextProperty, new Binding("ce_primera_nota"));
            ce_segunda_nota.SetBinding(Label.TextProperty, new Binding("ce_segunda_nota"));
            ce_tercera_nota.SetBinding(Label.TextProperty, new Binding("ce_tercera_nota"));
            ce_semestre.SetBinding(Label.TextProperty, new Binding("ce_semestre"));
            car_nombre.SetBinding(Label.TextProperty, new Binding("car_nombre"));
            car_jornada.SetBinding(Label.TextProperty, new Binding("car_jornada"));


            viewTexto.Children.Add(est_nombre);
            viewTexto.Children.Add(est_apellido);
            viewTexto.Children.Add(ce_primera_nota);
            viewTexto.Children.Add(ce_segunda_nota);
            viewTexto.Children.Add(ce_tercera_nota);
            viewTexto.Children.Add(ce_semestre);
            viewTexto.Children.Add(car_nombre);
            viewTexto.Children.Add(car_jornada);

            viewGeneral.Children.Add(imagenAvatar);
            viewGeneral.Children.Add(viewTexto);

            View = viewGeneral;
        }

     
    }
}