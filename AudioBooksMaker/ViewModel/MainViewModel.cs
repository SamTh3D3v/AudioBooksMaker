using GalaSoft.MvvmLight;
using AudioBooksMaker.Model;

namespace AudioBooksMaker.ViewModel
{
   
    public class MainViewModel : ViewModelBase
    {
        #region Consts
        public const string CoreDocumentPropertyName = "CoreDocument";
        #endregion
        #region Fields
        private string _coreDocument = string.Empty;
        #endregion
        #region Properties
        public string CoreDocument
        {
            get
            {
                return _coreDocument;
            }

            set
            {
                if (_coreDocument == value)
                {
                    return;
                }

                _coreDocument = value;
                RaisePropertyChanged(CoreDocumentPropertyName);
            }
        }
        #endregion    
        public MainViewModel()
        {
            CoreDocument = "The file goes here";
        }
    }
}