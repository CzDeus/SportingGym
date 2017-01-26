using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sporting_Gym.App_Code.Models
{
    class csNodo
    {
        public int posNodo { get; set; }
        public int LengthName { get; set; }
        public TreeNodeCollection nodeCollection { get; set; }

        public csNodo()
        {
            posNodo = 0;
            LengthName = 0;
            nodeCollection = null;
        }
    }
}
