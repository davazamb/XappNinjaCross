using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XappNinjaCross.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Click(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListPage());
        }
    }
}
