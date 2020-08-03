using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVMSample.Enums;

namespace MVVMSample.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string phone;
        private string address;
        private Genre genre;
        private decimal salary;

        public Person()
        {
        }
        public string Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged();

            }
        }
        public string Address
        {
            get => address; set
            {
                address = value;
                OnPropertyChanged();

            }
        }

        public Genre Genre
        {
            get => genre; set
            {
                genre = value;
                OnPropertyChanged();

            }
        }

        public decimal Salary
        {
            get => salary; set
            {
                salary = value;
                OnPropertyChanged();

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        // obtiene nombre de propiedad
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
