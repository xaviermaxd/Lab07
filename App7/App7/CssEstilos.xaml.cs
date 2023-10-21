using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace App7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CssEstilos : ContentPage
    {
        public CssEstilos()
        {
            InitializeComponent();

            //this.Resources = new ResourceDictionary();
            //this.Resources.Add(StyleSheet.FromResource("App7.estilos.css", typeof(App).Assembly));
            this.Resources.Add(StyleSheet.FromAssemblyResource(
                IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly,
                "App7.estilos.css"));



        }
    }
}