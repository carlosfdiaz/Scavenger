using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scavenger
{
    public class User
    {
        public User()
        {
            UserName = String.Empty;
            UserDisplayName = String.Empty;
            UserSecGroups = new List<string>();
            Found = false;
        }
        public string UserName { get; set; }

        public string UserDisplayName { get; set; }

        public List<string> UserSecGroups { get; set; }
        
        public bool Found { get; set; }
    }
}
