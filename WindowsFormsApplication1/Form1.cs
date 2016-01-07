using ReactiveUI;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form, IViewFor<ShellViewModel>
    {
        public Form1()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                // at the root, let's do something
                d(this.Bind(ViewModel, x => x.EnteredText, x => x.textBoxMyInput.Text));
                d(this.BindCommand(ViewModel, x => x.OKCmd, x => x.btnOK));

                // we'll propagate the result to the child control
                d(this.OneWayBind(ViewModel, vm => vm.Child, v => v.child.ViewModel));
            });

            ViewModel = new ShellViewModel();
        }

        public ShellViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ShellViewModel)value; }
        }
    }
}
