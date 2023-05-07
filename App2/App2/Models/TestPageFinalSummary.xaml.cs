using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPageFinalSummary : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public TestPageFinalSummary()
        {
            InitializeComponent();
        }


    }
}
