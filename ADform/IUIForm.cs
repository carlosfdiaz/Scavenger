using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scavenger
{
     public interface IUIForm
    {
       string OUTextBox { get; set; }

       string OUTextBox2 { get; set; }
       string OUTextBox3 { get; set; }
       string domainField { get; set; }

       string userField { get; set; }

       string userField2 { get; set; }

       Label ldapLabel { get; set; }

       string missingGroupLabelText { get; set; }

        SaveFileDialog saveDialog { get; set; }
       

     
    }
}
