//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Xamarin.Forms;

//namespace aplicacionMovil
//{
    

//    public class NotasEstu : ContentPage
//    {


//        Entry NotaEst1;
//        Entry NotaEst2;
//        Entry NotaEst3;


//        public NotasEstu()
//        {

//            RelativeLayout Vistageneral = new RelativeLayout(); /*{ BackgroundColor = Color.BlueViolet}*/

//            ListView EstuNotas = new ListView { ItemsSource = App.listaEstudiantes, ItemTemplate = new DataTemplate(typeof(EstiloNota)) };

//            Vistageneral.Children.Add(EstuNotas,
//               Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
//                   return p.Width * 0;
//               }),
//                Constraint.RelativeToParent((p) => { return p.Height * 0; }),
//                 Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
//                     return p.Width * 1;
//                 }),
//                  Constraint.RelativeToParent((p) => { return p.Height * 1; })
//               );

//            Content = Vistageneral;

//            NotaEst1 = new Entry();
//            NotaEst2 = new Entry();
//            NotaEst3 = new Entry();

//            NotaEst2.Text = "";
//            //NotaEst2.VerticalOptions = LayoutOptions.CenterAndExpand;
//            //NotaEst2.HorizontalOptions = LayoutOptions.CenterAndExpand;
//            //NotaEst2.WidthRequest = 355;
//            NotaEst2.Text = "hola";

//            NotaEst3.Text = "NotaEst3";
//            //NotaEst3.VerticalOptions = LayoutOptions.CenterAndExpand;
//            //NotaEst3.HorizontalOptions = LayoutOptions.CenterAndExpand;
//            //NotaEst3.WidthRequest = 355;
//            NotaEst3.Text = "";

//        }


//    }
//}