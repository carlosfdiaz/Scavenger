using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavenger
{
    public partial class CompareWindowcs : UserControl
    {
        public delegate void SearchButton2ClickedEventHandler(object source, EventArgs args);
        public event SearchButton2ClickedEventHandler SearchButton2Clicked;
        public CompareWindowcs()
        {
            InitializeComponent();
        }

        private void userSearch2_Click(object sender, EventArgs e)
        {
            OnSearchButton2Clicked();
        }

        protected virtual void OnSearchButton2Clicked()
        {
            if (SearchButton2Clicked != null)
            {
                SearchButton2Clicked(this, null);
            }
        }

        public TextBox GetUserField2()
        {
            return userTField2;
        }

       public RichTextBox GetOutBox()
        {
            return displayInfo2;
        }
         
    }
}
