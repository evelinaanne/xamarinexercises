using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Popup
{
    public partial class MainPage : ContentPage
    {

        private void Iampopup(object sender, EventArgs e)
        {
            popupContent.IsVisible = true;
        }

        private void Popupends(object sender, EventArgs e)
        {
            popupContent.IsVisible = false;
        }
        public MainPage()
        {
            InitializeComponent();


        }




    }

}
