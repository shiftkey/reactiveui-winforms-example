using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;

namespace WindowsFormsApplication1
{
    public partial class CustomControl : UserControl, IViewFor<ChildViewModel>
    {
        public CustomControl()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel, vm => vm.Name, v => v.name.Text));
            });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ChildViewModel)value; }
        }

        public ChildViewModel ViewModel { get; set; }
    }
}
