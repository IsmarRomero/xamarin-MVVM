using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Foundation.ObjectHydrator;
using MVVMSample.Models;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class PeopleViewModel : INotifyPropertyChanged
    {
        private Person selectedPerson;
        private ObservableCollection<Person> people;

        public PeopleViewModel()
        {
            var hydrator = new Hydrator<Person>()
                .WithFirstName(n => n.Name);
            OriginalPeople = new List<Person>(hydrator.GetList(50));
            People = new ObservableCollection<Person>(OriginalPeople);
            SelectedPerson = People.Skip(3).FirstOrDefault();
            SearchCommand = new Command((searchValue) =>
            {
                var filter = OriginalPeople
                .Where(s => s.Name
                .ToLower()
                .Contains(searchValue.ToString().ToLower()))
                .ToList();
                People = new ObservableCollection<Person>(filter);
            });
            ItemTappedCommand = new Command((item) =>
            {
                var i = item;

            });
        }
        public ObservableCollection<Person> People
        {
            get => people; set
            {
                people = value;
                OnPropertyChanged();
            }
        }

        public List<Person> OriginalPeople { get; set; }

        public Person SelectedPerson
        {
            get => selectedPerson; set
            {
                selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public ICommand SearchCommand { get; set; }
        public ICommand ItemTappedCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        // obtiene nombre de propiedad
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
