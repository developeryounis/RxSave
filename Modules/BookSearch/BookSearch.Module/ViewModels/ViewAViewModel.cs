using BookSearch.Services;
using Prism.Mvvm;
using Serilog;
using System;

namespace BookSearch.Module.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(ILogger logger, IBookSearchService bookSearchService)
        {
            Message = "View A from your Prism Module";
            logger.Information("Test Info");
            //throw new Exception("hjsjjsjs");
        }
    }
}