using System;
using System.Reactive.Linq;
using ReactiveUI;

namespace WindowsFormsApplication1
{
    public class ShellViewModel : ReactiveObject
    {
        public ShellViewModel()
        {
            var canExecute = this.WhenAnyValue(vm => vm.EnteredText)
                .Select(s => !string.IsNullOrWhiteSpace(s));

            OKCmd = ReactiveCommand.Create(canExecute);
            OKCmd.Subscribe(_ => Status = EnteredText + " is saved.");
        }

        string _enteredText;
        public string EnteredText
        {
            get { return _enteredText; }
            set { this.RaiseAndSetIfChanged(ref _enteredText, value); }
        }

        string _statusString = "";
        public string Status
        {
            get { return _statusString; }
            set { this.RaiseAndSetIfChanged(ref _statusString, value); }
        }

        public ReactiveCommand<object> OKCmd { get; private set; }
    }
}
