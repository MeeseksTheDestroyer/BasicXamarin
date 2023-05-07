using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using OpenAI_API;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App2.Classes;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Summary : ContentPage
    {
         
        public ObservableCollection<string> Items { get; set; }
        
        public Summary()
        {
            InitializeComponent();
            SummarizeText text = new SummarizeText();
            string result = String.Join("\n", text.Main().ToArray());
            Summ.Text = result;
            
            
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

   
        }
    }
}
