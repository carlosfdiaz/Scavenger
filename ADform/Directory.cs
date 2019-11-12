using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Security;
using System.Runtime.InteropServices;
using System.DirectoryServices.Protocols;
using System.Windows.Forms;
using System.IO;

namespace Scavenger
{
    public class Directory
    {   
        private readonly IUIForm form;
        string resultOutput = String.Empty;
        public Directory(IUIForm form)
        {
            
            this.form = form;           
        }

        public void DisplayUserResult(object sender, EventArgs e)
        {
            resultOutput = FormatList(ProcesUserGroups(form.userField));
            form.OUTextBox = resultOutput;
        }

        public User ProcesUserGroups(string userName)
        {
            List<string> userSecGroups = new List<string>();
            User user = new User();
            if (IsLdapOk() != false)
            {
                SearchResult result = GetUser(userName);
                if (result != null)
                {
                    
                    DirectoryEntry userObject = result.GetDirectoryEntry();
                    user.UserName = userObject.Properties["samaccountname"].Value.ToString();
                    user.UserDisplayName = userObject.Properties["displayname"].Value.ToString();

                    for (int counter = 0; counter < userObject.Properties["memberof"].Count; counter++)
                    {
                        userSecGroups.Add(userObject.Properties["memberof"][counter].ToString());
                      
                    }
                    userSecGroups.Sort();
                    user.UserSecGroups = userSecGroups;
                    user.Found = true;
                }
            }
            return user;
        }

        public string FormatList(User user)
        {
            string formattedString = String.Empty;
            if (!String.IsNullOrEmpty(user.UserDisplayName))
            { 
                var builder = new StringBuilder();
                builder.Append("Username: " + user.UserName);
                builder.Append(Environment.NewLine);
                builder.Append("Display Name: " + user.UserDisplayName);
                builder.Append(Environment.NewLine);
                for (int i = 0; i < user.UserSecGroups.Count(); i++)
                {
                    string[] trimPath = user.UserSecGroups[i].Split(',');
                    builder.Append(trimPath[0].Substring(3));
                    builder.Append(Environment.NewLine);
                }
                formattedString = builder.ToString();
            }
  
            return formattedString;
        }

        public void SaveUserSecGroups(object source, EventArgs e)
        {
          SaveFileDialog saveDialog = form.saveDialog;
          if (saveDialog.ShowDialog() == DialogResult.OK)
          {
             using (Stream s = File.Open(saveDialog.FileName, FileMode.Append))
             using (StreamWriter sw = new StreamWriter(s))
             {
                   sw.Write(resultOutput);
             }
          }
        }

        // This function requires Imports System.Net and Imports System.DirectoryServices.Protocols
        bool IsLdapOk()
        {
            string ldapServer = form.domainField;
            bool ldapOK = false;
            if (string.IsNullOrEmpty(ldapServer) == false)
            {
                LdapConnection ldapConnection = new LdapConnection(new LdapDirectoryIdentifier(ldapServer));
                TimeSpan mytimeout = new TimeSpan(0, 0, 3);
                try
                {
                    /**ldapConnection.AuthType = AuthType.Negotiate;
                    ldapConnection.AutoBind = false;*/
                    ldapConnection.Timeout = mytimeout;
                    ldapConnection.Bind();
                    ldapOK = true;
                    ldapConnection.Dispose();
                }
                catch (LdapException e)
                {
                    form.ldapLabel.ForeColor = System.Drawing.Color.FromArgb(179, 0, 0);
                    ldapOK = false;
                }
            }
            if(ldapOK == true)
            {
                form.ldapLabel.ForeColor = System.Drawing.Color.FromArgb(40, 135, 25);
            }
            return ldapOK;
        }


        private DirectoryEntry GetLdapConnection()
        {
            DirectoryEntry ldapConnection = null;
            ldapConnection = new DirectoryEntry("LDAP://" + form.domainField);

            return ldapConnection;

         }

       /** private List<string> GetOrgUnits()
        {
            List<string> orgUnits = new List<string>();
            DirectoryEntry ldapConnection = GetLdapConnection();
            DirectorySearcher searcher = new DirectorySearcher(ldapConnection);
            searcher.Filter = "(objectCategory=organizationalUnit)";
            foreach (SearchResult res in searcher.FindAll())
            {
                orgUnits.Add(res.Path);
            }

            searcher.Dispose();
            ldapConnection.Dispose();
            return orgUnits;
        }*/

        private SearchResult GetUser(string user)
        {
            DirectoryEntry ldapConnection = GetLdapConnection();
            DirectorySearcher searcher = new DirectorySearcher(ldapConnection);
            searcher.PropertiesToLoad.Add("displayname");
            searcher.PropertiesToLoad.Add("sammaccountname");
            searcher.PropertiesToLoad.Add("sn");
            searcher.PropertiesToLoad.Add("memberof");
            searcher.Filter = "(|(cn=" + user + ")(samaccountname=" + user + ")(displayname=" + user + ")(sn=" + user + "))";
            SearchResult result;

            try
            {
                result = searcher.FindOne();
            }
            catch(Exception e)
            {
                result = null;
            }
            if(result == null)
            {
                QuickDialogue quickDialogue = new QuickDialogue();
                quickDialogue.StartPosition = FormStartPosition.CenterScreen;
                bool checkString = String.IsNullOrEmpty(user);
                if (checkString == false )
                {
                    quickDialogue.SetTextErrorLabel("User " + user + " not found");
                }
                quickDialogue.Show();
            }

            searcher.Dispose();
            ldapConnection.Dispose(); 
            return result;
        }

    }
}   




