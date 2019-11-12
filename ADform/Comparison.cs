using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scavenger
{
    class Comparison
    {
        private readonly IUIForm form;
        public Comparison(IUIForm form)
        {
            this.form = form;
            
        }

        public void CompareUsers(object source, EventArgs args)
        {
            form.OUTextBox3 = String.Empty;
            form.missingGroupLabelText = "Missing groups for: ";
            Directory directory = new Directory(form);
            User user1 = directory.ProcesUserGroups(form.userField);
            User user2 = directory.ProcesUserGroups(form.userField2);
            form.OUTextBox = directory.FormatList(user1);
            form.OUTextBox2 = directory.FormatList(user2);
            if(user1.Found && user2.Found == true)
            {
                var differencesList = user1.UserSecGroups.Except(user2.UserSecGroups);
                foreach (string line in differencesList)
                {
                    string[] trimPath = line.Split(',');
                    form.OUTextBox3 += trimPath[0].Substring(3) + Environment.NewLine;
                    form.missingGroupLabelText = "Missing groups for: " + user2.UserDisplayName;
                }
            }
            
            

            


        }


    }
}
