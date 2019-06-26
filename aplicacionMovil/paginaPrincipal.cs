using aplicacionMovil.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aplicacionMovil
{
    public class paginaPrincipal : ContentPage
    {
   

        ListView listViewUsuario;

        int do_id1;

        public paginaPrincipal(int do_id)
        {
            do_id1 = do_id;
            

            StackLayout contentPrincipal = new StackLayout { HorizontalOptions = LayoutOptions.Center };
            listViewUsuario = new ListView();

            //listViewUsuario.ItemsSource = App.listaUsuarios; 
           // listViewUsuario.ItemsSource =  ;
            listViewUsuario.ItemTemplate = new DataTemplate(typeof(MyViewCell));
            listViewUsuario.ItemTapped += ListViewUsuario_ItemTapped;
            listViewUsuario.ItemSelected += ListViewUsuario_ItemSelected;
            listViewUsuario.RowHeight = 60;
            listViewUsuario.IsPullToRefreshEnabled = true;
            listViewUsuario.Refreshing += ListViewUsuario_Refreshing;


/*
             listViewUsuario.ItemSelected += (sender, e) =>
            {
                ((ListView)sender).SelectedItem = null;

            };

            listViewUsuario.ItemTapped += (sender, e) =>
            {
               
                

            };
*/
       


            contentPrincipal.Children.Add(listViewUsuario);

            Content = contentPrincipal;

        }

        private void ListViewUsuario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        private async void ListViewUsuario_ItemTapped(object sender, ItemTappedEventArgs e)
        {


            decimal nota1 = Convert.ToDecimal(((Data1)e.Item).ce_primera_nota);
            decimal nota2 = Convert.ToDecimal(((Data1)e.Item).ce_segunda_nota);
            decimal nota3 = Convert.ToDecimal(((Data1)e.Item).ce_tercera_nota);
            decimal total = ((nota1 + nota2 + nota3) / 3)/10;

            if(total >= 3)
            {
                await DisplayAlert("Notificacion", "Ganaste: " + ((Data1)e.Item).est_nombre, "Aceptar");
                return;
            }
            else
            {
                await DisplayAlert("Notificacion", "Perdiste: " + ((Data1)e.Item).est_nombre, "Aceptar");
                return;
            }

        }

        private async void ListViewUsuario_Refreshing(object sender, EventArgs e)
        {
           

            if (listViewUsuario.IsRefreshing)
            {
                IServicios servicios = DependencyService.Get<IServicios>();
                responseDataEstudiante responseServer = await servicios.Estudiante(do_id1);
                listViewUsuario.ItemsSource = responseServer.data;
            }
              //  await Task.Delay(1000);
            {
                listViewUsuario.EndRefresh();
            }
            //  throw new NotImplementedException();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            // int do_id;
            IServicios servicios = DependencyService.Get<IServicios>();
            responseDataEstudiante responseServer = await servicios.Estudiante(do_id1);
            listViewUsuario.ItemsSource = responseServer.data;
      
        }


    }
}

