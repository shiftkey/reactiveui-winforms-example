using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace WindowsFormsApplication1
{
    public class HomeViewModel : ReactiveObject
    {
        public HomeViewModel()
        {
            var OKCmdObs = this.WhenAnyValue(vm => vm.EnteredText)
                .Select(s => !string.IsNullOrWhiteSpace(s));

            OKCmd = ReactiveCommand.Create(OKCmdObs);
            OKCmd.Subscribe(_ => Status = EnteredText + " is saved.");
        }


    string enteredText;
        public string EnteredText
        {
            get { return enteredText; }
            set { this.RaiseAndSetIfChanged(ref enteredText, value); }
        }

        string statusString = "";
        public string Status
        {
            get { return statusString; }
            set { this.RaiseAndSetIfChanged(ref statusString, value); }
        }

        public ReactiveCommand<object> OKCmd { get; private set; }
    }
}
