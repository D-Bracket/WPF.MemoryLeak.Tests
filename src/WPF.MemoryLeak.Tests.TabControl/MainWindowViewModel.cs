using System.Collections.ObjectModel;
using System.Windows.Input;
using WPF.MemoryLeak.Tests.TabControl.MVVM;

namespace WPF.MemoryLeak.Tests.TabControl
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region "----------------------------- Private Fields ------------------------------"
        private static int _clientNumber = 1;
        #endregion



        #region "------------------------------ Constructor --------------------------------"
        public MainWindowViewModel()
        {

        }
        #endregion



        #region "--------------------------------- Methods ---------------------------------"
        #region "----------------------------- Public Methods ------------------------------"

        #endregion

        #region "----------------------------- Private Methods -----------------------------"

        #endregion

        #region "------------------------------ Event Handling -----------------------------"

        #endregion

        #region "----------------------------- Command Handling ----------------------------"
        public override void ExecuteCommands(object? command)
        {
            switch (command)
            {
                case "AddClient":
                    Clients.Add(new ClientViewModel() { Name = $"Client_{_clientNumber}" });
                    _clientNumber++;
                    break;

                case "RemoveFirstClient":
                    if (Clients.Count > 0)
                        Clients.RemoveAt(0);
                    break;

                default:
                    break;
            }
        }

        private void ExecuteRemoveCommand(object? obj)
        {
            if (obj is not ClientViewModel clientViewModel)
                return;

            Clients.Remove(clientViewModel);
        }
        #endregion
        #endregion



        #region "--------------------------- Public Propterties ----------------------------"
        #region "------------------------------- Properties --------------------------------"
        public ObservableCollection<ClientViewModel> Clients { get => _clients; set { _clients = value; OnMySelfChanged(); } }
        private ObservableCollection<ClientViewModel> _clients = [];
        #endregion

        #region "--------------------------------- Events ----------------------------------"

        #endregion

        #region "-------------------------------- Commands ---------------------------------"
        /// <summary>Commands from the UI</summary>
        public ICommand RemoveCommand => new RelayCommand(ExecuteRemoveCommand);
        #endregion
        #endregion
    }
}