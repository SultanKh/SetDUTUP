using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetThisUp
{
    class UserUsing
    {
        private string name;
        private string pass;

        public UserUsing()
        {
            this.name = "";
            this.pass = "";
        }
        public UserUsing(string n,string p)
        {
            this.name = n;
            this.pass = p;
        }

    }
}
