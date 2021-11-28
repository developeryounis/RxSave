using BookSearch.BL;
using Prism.Mvvm;

namespace BookStore.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IBookSearchBL2 test)
        {
        }
    }
}