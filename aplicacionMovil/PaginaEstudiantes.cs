using aplicacionMovil.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace aplicacionMovil
{
    public class PaginaEstudiantes : ContentPage
    {
        public PaginaEstudiantes()
        {
            RelativeLayout Vistageneral = new RelativeLayout(); /*{ BackgroundColor = Color.BlueViolet}*/

            ListView Estudiantes = new ListView { ItemsSource = App.listaEstudiantes, ItemTemplate = new DataTemplate(typeof(EstiloEst))};

            Vistageneral.Children.Add(Estudiantes,
               Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
                   return p.Width * 0;
               }),
                Constraint.RelativeToParent((p) => { return p.Height * 0; }),
                 Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
                     return p.Width * 1;
                 }),
                  Constraint.RelativeToParent((p) => { return p.Height * 1; })
               );

            Estudiantes.ItemTapped += Estudiantes_ItemTapped;
            Content = Vistageneral;


        }

        private void Estudiantes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //((Estudiantes)e.Item).Notas;
        }
    }
}