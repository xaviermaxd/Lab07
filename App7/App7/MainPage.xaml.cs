using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DynamicDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ExplicitControlDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitDemo());
            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ImplicitControlDemo());
            };
            Item6.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new GlobalDemo());
            };
            Item7.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CssEstilos());
            };
        }
    }
}
