using System;
using System.Windows.Input;
using MVVMSample.Models;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class MainPageViewModel
    {
        public Person CurrentPerson { get; set; }

        public ICommand SaveCommand { get; set; }

        public MainPageViewModel()
        {
            LoadData();
            SaveCommand = new Command(() => {
               App.Current.MainPage.DisplayAlert("Saving", "Saving Data", "Ok");
                //CurrentPerson.Name = "Juan";
                //CurrentPerson.Phone = "090909";
                //CurrentPerson.Address = "z Address";
                //CurrentPerson = new Person { Name = "Ismar", Phone = "Tele", Address = "addsds" };
            });
        }

        public void LoadData()
        {
            // Connecting to Web Service
            CurrentPerson = new Person
            { Name = "Ismar", Phone = "9999999999", Address = "X Address",
            Genre = Enums.Genre.Male, Salary = 2500m};

            //txtName.Text = CurrentPerson.Name;
            //txtPhone.Text = CurrentPerson.Phone;
            //txtAddress.Text = CurrentPerson.Address;

        }


    }
}
