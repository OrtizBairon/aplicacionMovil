using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace aplicacionMovil
{
  public class EstiloEst : ViewCell
    {
        public EstiloEst() {


            RelativeLayout Vistacelda = new RelativeLayout();

            Label Nombre = new Label { BackgroundColor = Color.White, TextColor= Color.Black };
            Label Nota = new Label();
            BoxView Contenedor = new BoxView { BackgroundColor = Color.Aqua };

            Nombre.SetBinding(Label.TextProperty, "Nombre_Apellido");
          
            Vistacelda.Children.Add(Nombre,
                Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
                    return p.Width * 0.05;
                }),
                 Constraint.RelativeToParent((p) => { return p.Height * 0.25; }),
                  Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
                      return p.Width * 0.95;
                  }),
                   Constraint.RelativeToParent((p) => { return p.Height * 0.5; })
                );


            //Vistacelda.Children.Add(Contenedor,
            //    Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
            //        return p.Width * 0.70;
            //    }),
            //     Constraint.RelativeToParent((p) => { return p.Height * 0; }),
            //      Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
            //          return p.Width * 0.30;
            //      }),
            //       Constraint.RelativeToParent((p) => { return p.Height * 1; })
            //    );


            //Vistacelda.Children.Add(Nota,
            //  Constraint.RelativeToParent((p) => { /*Nombre.HeightRequest=p.Height * 0.1;*/
            //      return p.Width * 0.80;
            //  }),
            //   Constraint.RelativeToParent((p) => { return p.Height * 0.25; }),
            //    Constraint.RelativeToParent((p) => { /*Nombre.WidthRequest=p.Width * 0.65;*/
            //        return p.Width * 0.1;
            //    }),
            //     Constraint.RelativeToParent((p) => { return p.Height * 0.5; })
            //  );


            View = Vistacelda;


        }





    }




         

    }

