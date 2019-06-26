//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xamarin.Forms;

//namespace aplicacionMovil
//{
//    public class EstiloNota : ViewCell
//    {
//        public EstiloNota()
//        {
//            RelativeLayout Vistacelda = new RelativeLayout();

//            Label NotaU = new Label();
//            Label NotaD = new Label();
//            Label NotaT = new Label();

//            BoxView Contenedor = new BoxView { BackgroundColor = Color.Aqua };

//            NotaU.SetBinding(Label.TextProperty, "NotaUno");
          
//            Vistacelda.Children.Add(NotaU,
//                Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
//                    return p.Width* 0.05;
//                }),
//                 Constraint.RelativeToParent((p) => { return p.Height* 0.25; }),
//                  Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
//                      return p.Width* 0.95;
//                  }),
//                   Constraint.RelativeToParent((p) => { return p.Height* 0.5; })
//                );


//            //Vistacelda.Children.Add(Contenedor,
//            //    Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
//            //        return p.Width * 0.70;
//            //    }),
//            //     Constraint.RelativeToParent((p) => { return p.Height * 0; }),
//            //      Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
//            //          return p.Width * 0.30;
//            //      }),
//            //       Constraint.RelativeToParent((p) => { return p.Height * 1; })
//            //    );


//            //Vistacelda.Children.Add(Nota,
//            //  Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
//            //      return p.Width * 0.80;
//            //  }),
//            //   Constraint.RelativeToParent((p) => { return p.Height * 0.25; }),
//            //    Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
//            //        return p.Width * 0.1;
//            //    }),
//            //     Constraint.RelativeToParent((p) => { return p.Height * 0.5; })
//            //  );


//            View = Vistacelda;


//        }





//    }




         

//    }

