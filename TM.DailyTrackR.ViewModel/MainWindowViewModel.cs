namespace TM.DailyTrackR.ViewModel
{
    using Prism.Commands;
    using Prism.Mvvm;
    using System;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using TM.DailyTrackR.Common;
    using TM.DailyTrackR.Logic;

    public class MainWindowViewModel: BindableBase
  {
        private User user;
        private string username;
        private string password;
        private int number = 1;
        private ObservableCollection<string> listOfNumber;

        public ObservableCollection<string> ListOfNumber
        {
            get => listOfNumber;
            set => this.SetProperty(ref listOfNumber, value);
        }

        public MainWindowViewModel()
        {
          //LogicHelper.Instance.ExampleController.DeleteData();
            this.user = new User { Username = "Marcel", Password = "pita" };
            this.ListOfNumber = new ObservableCollection<string> {"1", "2", "3", "4", "5" , "6"};

            this.username = this.user.Username;
            this.password = this.user.Password;
            
            IncreaseNumber = new DelegateCommand(IncreaseNumberExecute, IncreaseNumberCanExecute);
            NewWindowCommand = new DelegateCommand(NewWindowExecute);
            DeleteElementFromIndex = new DelegateCommand(DeleteElementFromIndexExecute);
        }

        

        public DelegateCommand IncreaseNumber
        {
            get;
        }
        public DelegateCommand NewWindowCommand
        {
            get;
        }
        public DelegateCommand DeleteElementFromIndex
        {
            get;
        }
        public string Username {
            get => this.username;
            set => this.SetProperty<string>(ref this.username, value);
        }
        public string Password {
            get => this.password;
            set => this.SetProperty<string>(ref this.password, value);
        }
        public int Number
        {
            get => number;
            set => this.SetProperty(ref this.number, value);
        }
        private void IncreaseNumberExecute() => Number++;

        private bool IncreaseNumberCanExecute() => number < 5;

        private void NewWindowExecute()
        {
            ViewService.Instance.ShowWindow(new AddDataViewModel());
        }

        private void DeleteElementFromIndexExecute()
        {
            this.ListOfNumber.RemoveAt(2);
        }


    }
}
