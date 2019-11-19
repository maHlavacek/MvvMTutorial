using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvMTutorial.WpfApp.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        private ObservableCollection<Logic.Entities.Employee> employees;

        public ObservableCollection<Logic.Entities.Employee> Employees 
        { 
            get { return employees; }
            set
            {
                employees = value;
                OnPropertyChanged(nameof(Employees));
            }
        }

    }
}
