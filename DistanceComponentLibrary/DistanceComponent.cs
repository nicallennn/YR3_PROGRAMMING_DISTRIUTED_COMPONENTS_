using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceComponentLibrary
{
    public partial class DistanceComponent : System.Windows.Forms.TextBox
    {
        public DistanceComponent()
        {
            InitializeComponent();
        }

        public DistanceComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            CheckDistanceValue();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);



        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }



        }

        //check distance value and repaint border red
        private void CheckDistanceValue()
        {
            //float input;
            decimal input;
            if (decimal.TryParse(this.Text, out input))
            {
                if (input > 50)
                {
                    this.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.ForeColor = System.Drawing.Color.Empty;
                }
            }



        }
    }
}
