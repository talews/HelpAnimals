using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    class Class2:ContentPage
    {
        public Class2()
        {
            Label test = new Label
            {
                Text = "Testando página  2",
                TextColor = Color.White,
                FontSize = 70,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
            };


            StackLayout Layout2 = new StackLayout
            {
                Children =
            {
                test
            },

                HeightRequest = 1500,
            };

            this.Content = Layout2;
        }
    }
}
