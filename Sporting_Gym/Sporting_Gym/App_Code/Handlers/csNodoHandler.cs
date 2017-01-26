using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Sporting_Gym.App_Code.Entity_Model;
using Sporting_Gym.App_Code.Models;

namespace Sporting_Gym.App_Code.Handlers
{
    class csNodoHandler
    {
        public bool Search(List<csNodo> listNodo, int lengthSistema, out csNodo Nodo)
        {
            Nodo = new csNodo();
            bool exist = false;

            for (int x = 0; x < listNodo.Count; x++)
            {
                if (listNodo[x].LengthName == lengthSistema)
                { Nodo = listNodo[x]; exist = true; }
            }

            return exist;
        }
        public void RecorrerNodos(List<Generales_Accesos_Usuarios> list, TreeNodeCollection treeNodeCollection)
        {
            for (int x = 0; x < treeNodeCollection.Count; x++)
            {
                int countChilNodes = treeNodeCollection[x].Nodes.Count;
                if (countChilNodes == 0)
                {
                    for (int y = 0; y < list.Count; y++)
                    {
                        string str = list[y].id_acceso.ToString();
                        if ((string)treeNodeCollection[x].Tag == str)
                        { treeNodeCollection[x].Checked = true; break; }
                    }
                }
                else if (countChilNodes > 0)
                    RecorrerNodos(list, treeNodeCollection[x].Nodes);
            }
        }

        public List<int> RecorrerNodos(List<int> listNodo, TreeNodeCollection treeNodeCollection)
        {
            for (int x = 0; x < treeNodeCollection.Count; x++)
            {
                int countChilNodes = treeNodeCollection[x].Nodes.Count;
                if (countChilNodes == 0 && treeNodeCollection[x].Checked)
                    listNodo.Add(Convert.ToInt32(treeNodeCollection[x].Tag.ToString()));
                else if (countChilNodes > 0)
                    RecorrerNodos(listNodo, treeNodeCollection[x].Nodes);
            }

            return listNodo;
        }
    }
}