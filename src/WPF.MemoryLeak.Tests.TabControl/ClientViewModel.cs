using System.Collections.ObjectModel;
using WPF.MemoryLeak.Tests.TabControl.MVVM;

namespace WPF.MemoryLeak.Tests.TabControl
{
    public class ClientViewModel : ViewModelBase
    {
        #region "----------------------------- Private Fields ------------------------------"

        #endregion



        #region "------------------------------ Constructor --------------------------------"
        public ClientViewModel()
        {
            Selection.Add("Value 1");
            Selection.Add("Value 2");
            Selection.Add("Value 3");
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
            
        }
        #endregion
        #endregion



        #region "--------------------------- Public Propterties ----------------------------"
        #region "------------------------------- Properties --------------------------------"
        public string Name { get => _name; set { _name = value; OnMySelfChanged(); } }
        private string _name = string.Empty;

        public ObservableCollection<string> Selection { get => _selection; set { _selection = value; OnMySelfChanged(); } }
        private ObservableCollection<string> _selection = [];
        #endregion

        #region "--------------------------------- Events ----------------------------------"

        #endregion

        #region "-------------------------------- Commands ---------------------------------"

        #endregion
        #endregion
    }
}