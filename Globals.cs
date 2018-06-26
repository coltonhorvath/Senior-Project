using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DARS
{
    class Globals
    {
        private static string v_Username = "";

        public static string username
        {
            get { return v_Username; }
            set { v_Username = value; }
        }
    }
}
