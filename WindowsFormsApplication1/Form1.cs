using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form, IViewFor<HomeViewModel>
    {
        public Form1()
        {
            InitializeComponent();

            VM = new HomeViewModel();

            // Bind the view to the ReactiveUI viewmodel
            this.Bind(VM, x => x.EnteredText, x => x.textBoxMyInput.Text);
            this.Bind(VM, x => x.Status, x => x.statusTrayMessage.Text);
            this.BindCommand(VM, x => x.OKCmd, x => x.btnOK);
        }

        public HomeViewModel VM { get; set; }

        object IViewFor.ViewModel
        {
            get { return VM; }
            set { VM = (HomeViewModel)value; }
        }

        HomeViewModel IViewFor<HomeViewModel>.ViewModel
        {
            get { return VM; }
            set { VM = value; }
        }
    }
}
