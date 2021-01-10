using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetProg3
{
    class admins
    {
        public admins(string v1, string v2, int v3)
        {
            this.login = v1;
            this.password = v2;
            this.role = v3;
        }

        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int role { get; set; }
    }
}
