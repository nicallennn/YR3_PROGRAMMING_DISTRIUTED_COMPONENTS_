using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxLibrary
{
    public partial class NumericEntryTextbox : System.Windows.Forms.TextBox
    {
        public NumericEntryTextbox()
        {
            InitializeComponent();
        }

        public NumericEntryTextbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }



        }
    }
}
