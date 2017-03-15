using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    class MenuPrincial:ContentPage
    {
        
        
            public class Dados
            {
                public string img { get; set; }


            }

            List<Dados> Lista;

            BoxView box = new BoxView
            {
                Color = Color.Blue,
                WidthRequest = 250,
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Fill

            };

            Image imag = new Image
            {
                Source = "Assets/download.jpg",
                Aspect = Aspect.AspectFit,
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 250,
                HeightRequest = 250,

            };

            ContentView content = new ContentView
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                //HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Black,
                Content = new Label
                {
                    Text = "Seja Bem Vindo (a) ao HelpAnimals",
                    FontSize = 70,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.White

                },
                Padding = new Thickness(370)
            };

            public MenuPrincial()
            {
                CarouselView name = new CarouselView
                {
                    VerticalOptions = LayoutOptions.Start,
                    HeightRequest = 200,



                };

                Lista = new List<Dados>();
                Lista.Add(new Dados
                {
                    img = "cahorro.jpg"
                });


                Lista.Add(new Dados
                {
                    img = "animal2.jpg"
                });

                Lista.Add(new Dados
                {
                    img = "animal.jpg"
                });



                var tapesGestureRecognizer = new TapGestureRecognizer(); //Evento para toque na imagem.
                tapesGestureRecognizer.Tapped += (s, e) =>
                {
                    imag.Opacity = .4;
                };
                imag.GestureRecognizers.Add(tapesGestureRecognizer);

                Label labelGrande = new Label
                {

                    Text = "Seja Bem Vindo(a) ao HelpAnimals",
                    FontSize = 15,
                    TextColor = Color.Black,
                    FontAttributes = FontAttributes.Bold,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.EndAndExpand


                };
              


                //labelGrande.FontFamily = Device.OnPlatform(   Mudar a fonte para Cada aparelho.
                //    iOS: "Courier",
                //    Android: "Droid Sans Mono",
                //    WinPhone: "Courier New"
                //    );

                Button button2 = new Button
                {
                    Text = "Cadastrar",
                    TextColor = Color.White,
                    BackgroundColor = Color.FromHex("#00FFFF"),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                    //HorizontalOptions = LayoutOptions.CenterAndExpand,
                    //VerticalOptions = LayoutOptions.FillAndExpand,
                };

            Button button = new Button
            {
                Text = "Entrar",
                TextColor = Color.White,
                BackgroundColor = Color.FromHex("#00FFFF"),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                //VerticalOptions = LayoutOptions.FillAndExpand,

                };
                    Padding = new Thickness(110);
                //button.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button));


                StackLayout layout = new StackLayout
                {
                    Children =
                {
                    labelGrande,
                    button,
                    button2,
                },
                    HeightRequest = 1500,
                };
                name.ItemsSource = Lista;
            this.BackgroundImage = "Resources/drawable/cao.jpg";
            //this.BackgroundColor = Color.Green;

            this.Content = layout;

                button.Clicked += (sender, args) =>
                {
                    
                    Navigation.PushAsync(new Class2(), true);
                    //button.Text = "Você Clicou em mim";
                };
            }
        }
    }
