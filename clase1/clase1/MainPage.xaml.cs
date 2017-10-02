using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace clase1
{
	public partial class MainPage : ContentPage
	{
       public int contador = 0;

		public MainPage()
		{
			
            var label = new Label { Text = "Label por Codigo" };
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Margin = 0,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Vertical
            };
            var button = new Button
            {
                Text = "Accion" ,
                HorizontalOptions = LayoutOptions.CenterAndExpand,            
            };
            button.Clicked += clickear;
            layout.Children.Add(label);
            layout.Children.Add(button);
            Content = layout;
        }

        public void clickear(Object sender, EventArgs e)
        {
            DisplayAlert("Hola","Click","ok");
           
        }

    }
}
