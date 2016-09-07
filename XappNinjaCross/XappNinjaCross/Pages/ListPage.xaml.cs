using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XappNinjaCross.Pages
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            List<String> list = new List<string>();
            list.Add(string.Empty);
            list.Add(string.Empty);

            this.lstSample.ItemsSource = list;
        }
    }
}
