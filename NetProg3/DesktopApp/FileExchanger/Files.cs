using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetProg3
{
    class files
    {
        public files(int v1, string v2, string v3,string v4)
        {
            this.id_user = v1;
            this.name_file = v2;
            this.status_file = v3;
            this.text = v4;

        }

        public int id_user { get; set; }
        public string name_file { get; set; }
        public string status_file { get; set; }
        public string text { get; set; }
        public int id { get; set; }
    }
}
