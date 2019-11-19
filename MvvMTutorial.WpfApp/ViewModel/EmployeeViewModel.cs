using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MvvMTutorial.WpfApp.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        private Logic.Entities.Employee selectedEmployee = null;

        private ObservableCollection<Logic.Entities.Employee> employees;

        public Logic.Entities.Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set 
            { 
                selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }

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
