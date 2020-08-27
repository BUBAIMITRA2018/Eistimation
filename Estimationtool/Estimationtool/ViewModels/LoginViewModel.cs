using Estimationtool.Helper;
using Estimationtool.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;


namespace Estimationtool.ViewModels
{
    class LoginViewModel:BaseViewModel
    {

        private string _username;
        private string _password;
        private bool _areCredentialsInvalid;
     

        public LoginViewModel()
        {

            AreCredentialsInvalid = false;

        }


        public string Username
        {
            get =>this._username;
            set
            {
                this.SetProperty(ref this._username, value);
            }
        }

        public string Password
        {
            get => this._password;
            set
            {
                this.SetProperty(ref this._password, value);

               
            }
        }

        public bool AreCredentialsInvalid
        {
            get => _areCredentialsInvalid;
            set
            {
                this.SetProperty(ref this._areCredentialsInvalid, value);
            }
        }



        private ICommand authenticateCommand;
        public ICommand AuthenticateCommand
        {
            get
            {
                return authenticateCommand ?? (authenticateCommand = new DelegateCommand<object>(X =>
                                                                                      {

                                                                                          AreCredentialsInvalid = !UserAuthenticated(Username, Password);
                                                                                          if (AreCredentialsInvalid) return;

                                                                                          App.Current.MainPage = new MainPage();

                                                                                      }));
            }



        }
     

        private bool UserAuthenticated(string username, string password)
        {
            if (string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password))
            {
                return false;
            }

            return username.ToLowerInvariant() == "joe"
              && password.ToLowerInvariant() == "secret";
        }
    }
}
