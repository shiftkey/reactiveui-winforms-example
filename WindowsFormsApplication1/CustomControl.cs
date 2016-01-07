using System.Windows.Forms;
using ReactiveUI;

namespace WindowsFormsApplication1
{
    public partial class CustomControl : UserControl, IViewFor<ChildViewModel>
    {
        public CustomControl()
        {
            InitializeComponent();

            // WhenActivated inside a control is currently breaking
            // the designer. crying forever, but until i investigate
            // further this needs to be removed
            this.OneWayBind(ViewModel, vm => vm.Name, v => v.name.Text);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ChildViewModel)value; }
        }

        public ChildViewModel ViewModel { get; set; }
    }
}
