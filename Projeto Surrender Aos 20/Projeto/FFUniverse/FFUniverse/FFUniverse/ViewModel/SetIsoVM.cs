using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFUniverse.ViewModel
{
    class SetIsoVM : ViewModelBase
    {
        ObservableCollection<Model.SetIso> _conjuntoSetIso;
        public ObservableCollection<Model.SetIso> _ConjuntoSetIso { get { return _conjuntoSetIso; } set { _conjuntoSetIso = value; OnPropertyChanged("_ConjuntoSetIso"); } }

        public SetIsoVM()
        {
            _conjuntoSetIso = new ObservableCollection<Model.SetIso>();
            GetSetIso();
        }

        public async void GetSetIso()
        {
            var setIso = await API.API.GetSetIso();
            for (int i = 0; i < setIso.Count; i++)
            {
                _ConjuntoSetIso.Add(new Model.SetIso
                {
                    nome = setIso[i].nome,
                    atributo0 = setIso[i].atributo0,
                    atributo1 = setIso[i].atributo1,
                    atributo2 = setIso[i].atributo2,
                    atributo3 = setIso[i].atributo3,
                    atributo4 = setIso[i].atributo4,
                    ativacao = setIso[i].ativacao,
                    atributoativacao = setIso[i].atributoativacao,
                    iso1 = setIso[i].iso1,
                    iso2 = setIso[i].iso2,
                    iso3 = setIso[i].iso3,
                    iso4 = setIso[i].iso4,
                    iso5 = setIso[i].iso5,
                    iso6 = setIso[i].iso6,
                    iso7 = setIso[i].iso7,
                    iso8 = setIso[i].iso8
                });
            }
            Xamarin.Forms.Application.Current.MainPage = (new View.ConjuntoIso8(_ConjuntoSetIso));
        }


    }
}
