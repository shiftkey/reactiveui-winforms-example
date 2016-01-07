using ReactiveUI;

namespace WindowsFormsApplication1
{
    public class ChildViewModel : ReactiveObject
    {
        string _name;
        public string Name
        {
            get { return _name; }
            set { this.RaiseAndSetIfChanged(ref _name, value); }
        }
    }
}