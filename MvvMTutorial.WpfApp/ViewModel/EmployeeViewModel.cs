using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MvvMTutorial.WpfApp.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        private Logic.Entities.Employee selectedEmployee = null;

        private ObservableCollection<Logic.Entities.Employee> employees;

        public EmployeeViewModel()
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            if (employees == null)
            {
                employees = new ObservableCollection<Logic.Entities.Employee>();
            }

            foreach (var item in Logic.EmployeeRepository.GetEmployees())
            {
                employees.Add(item);
            }

            if (employees.Any())
            {
                selectedEmployee = employees[0];
            }
            else
            {
                selectedEmployee = new Logic.Entities.Employee();
            }
        }

        public string FirstName
        {
            get { return SelectedEmployee.FirstName; }
            set
            {
                SelectedEmployee.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get { return SelectedEmployee.LastName; }
            set
            {
                SelectedEmployee.LastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }


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

        private ICommand cmdSaveChanges;
        public ICommand CmdSaveChanges
        {
            get
            {
                if(cmdSaveChanges == null)
                {
                    cmdSaveChanges = new RelayCommand();
                }
            }
        }

    }
}
