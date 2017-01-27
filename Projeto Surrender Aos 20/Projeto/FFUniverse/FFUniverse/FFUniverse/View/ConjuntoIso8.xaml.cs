using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FFUniverse.View
{
    public partial class ConjuntoIso8 : ContentPage
    {
        public ConjuntoIso8()
        {
            InitializeComponent();
            BindingContext = new ViewModel.SetIsoVM();
        }

        public ConjuntoIso8(ObservableCollection<Model.SetIso> SetIsoWR)
        {
            InitializeComponent();
            SetIso.ItemsSource = SetIsoWR;
        }
    }
}
