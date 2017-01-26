using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sporting_Gym.App_Code.Entity_Model;
using System.Windows.Forms;
using Sporting_Gym.App_Code.Models;

namespace Sporting_Gym.App_Code.Handlers
{
    class csAccesosHandler
    {
        private List<csSubModulo> AccesoMayor(List<Generales_Accesos> generales_accesos, int posAccesos, List<csSubModulo> SubsModulos, out int posGeneralesAccesos)
        {
            csSubModuloHandler SubModuloHandler = new csSubModuloHandler();
            List<csSubModulo> SubModulos = SubsModulos;
            posGeneralesAccesos = 0;

            for (int x = posAccesos; x < generales_accesos.Count; x++)
            {
                int pos = x + 1 >= generales_accesos.Count ? x : x + 1;
                if (generales_accesos[pos].orden.Trim().Length > generales_accesos[x].orden.Trim().Length)
                {
                    SubModulos.Add(SubModuloHandler.AddSubModulos(generales_accesos[x]));
                    int ultimoSubModulo = SubModulos.Count - 1;
                    SubModulos[ultimoSubModulo].SubModulos = (this.AccesoMayor(generales_accesos, pos, SubModulos[ultimoSubModulo].SubModulos, out posGeneralesAccesos));
                    x = posGeneralesAccesos;
                    break;
                }
                else if (generales_accesos[pos].orden.Trim().Length < generales_accesos[x].orden.Trim().Length)
                {
                    SubModulos.Add(SubModuloHandler.AddSubModulos(generales_accesos[x]));
                    posGeneralesAccesos = x;
                    break;
                }
                else
                {
                    SubModulos.Add(SubModuloHandler.AddSubModulos(generales_accesos[x]));
                    posGeneralesAccesos = x;
                }
            }

            return SubModulos;
        }

        public List<csModulo> CreateAccesos()
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();
            List<Generales_Accesos> generales_accesos = contexto.Generales_Accesos.Select(a => a).OrderBy(a => a.orden).ToList();

            csSubModuloHandler SubModuloHandler = new csSubModuloHandler();
            csModulo tempModulo = new csModulo();
            List<csModulo> Modulos = new List<csModulo>();

            int posGeneralesAccesos = 0;
            int LengthSistema = 0;
            int countGeneralesAccesos = generales_accesos.Count;

            for (int x = 0; x < countGeneralesAccesos; x++)
            {
                int strNodoLength = generales_accesos[x].orden.Trim().Length;

                if (generales_accesos[x].padre == 1)
                {
                    if (tempModulo.subModulos.Count > 0)
                    {
                        Modulos.Add(tempModulo);
                        tempModulo = new csModulo();
                    }

                    tempModulo.id_General_Acceso = generales_accesos[x].id_acceso;
                    tempModulo.nombre_Acceso = generales_accesos[x].nombre_acceso.Trim();
                    tempModulo.nombre_Form = generales_accesos[x].nombre_form.Trim();

                    LengthSistema = strNodoLength;
                }
                else if (strNodoLength > LengthSistema)
                {
                    tempModulo.subModulos = this.AccesoMayor(generales_accesos, x, tempModulo.subModulos, out posGeneralesAccesos);
                    x = posGeneralesAccesos;

                    LengthSistema = strNodoLength;
                }
                else if (strNodoLength == LengthSistema)
                {
                    tempModulo.subModulos = this.AccesoMayor(generales_accesos, x, tempModulo.subModulos, out posGeneralesAccesos);
                    x = posGeneralesAccesos;
                    LengthSistema = strNodoLength;
                }
                //else if (strNodoLength < LengthSistema)
                //{
                //    if (generales_accesos[x].padre == 1)
                //        x--;
                //    else
                //        tempModulo.subModulos.Add(SubModuloHandler.AddSubModulos(generales_accesos[x]));

                //    LengthSistema = strNodoLength;
                //}
            }

            if (tempModulo.subModulos.Count > 0)
                Modulos.Add(tempModulo);

            return Modulos;
        }

        private List<csSubModulo> RecorrerSubModulos(List<csSubModulo> SubModulos, List<Generales_Accesos_Usuarios> GeneralesAccesosUsuarios)
        {
            List<csSubModulo> testSubModulo = new List<csSubModulo>();

            for (int x = 0; x < SubModulos.Count; x++)
            {
                if (SubModulos[x].SubModulos.Count > 0)
                {
                    List<csSubModulo> SubModuloTest = RecorrerSubModulos(SubModulos[x].SubModulos, GeneralesAccesosUsuarios);

                    if (SubModuloTest.Count > 0)
                    {
                        testSubModulo.Add(new csSubModulo()
                        {
                            id_General_Acceso = SubModulos[x].id_General_Acceso,
                            nombre_Acceso = SubModulos[x].nombre_Acceso,
                            nombre_Form = SubModulos[x].nombre_Form,
                            titulo_Button = SubModulos[x].titulo_Button,
                            SubModulos = SubModuloTest
                        });
                    }
                }
                else
                {
                    for (int y = 0; y < GeneralesAccesosUsuarios.Count; y++)
                    {
                        if (SubModulos[x].id_General_Acceso == GeneralesAccesosUsuarios[y].id_acceso)
                            testSubModulo.Add(SubModulos[x]);
                    }
                }
            }

            return testSubModulo;
        }

        public List<csModulo> CreateAccesosUsuarios(int id_Usuario)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();
            var generales_accesos_usuarios = contexto.Generales_Accesos_Usuarios.Where(a => a.id_usuario == id_Usuario).ToList();

            List<csModulo> Modulos = new List<csModulo>();
            List<csModulo> ModulosAccesos = CreateAccesos();

            for (int x = 0; x < ModulosAccesos.Count; x++)
            {
                List<csSubModulo> SubModulos = RecorrerSubModulos(ModulosAccesos[x].subModulos, generales_accesos_usuarios);

                if (SubModulos.Count > 0)
                    Modulos.Add(new csModulo()
                    {
                        id_General_Acceso = ModulosAccesos[x].id_General_Acceso,
                        nombre_Acceso = ModulosAccesos[x].nombre_Acceso,
                        nombre_Form = ModulosAccesos[x].nombre_Form,
                        subModulos = SubModulos
                    });
            }

            if (!(Modulos.Count > 0))
                Modulos = null;

            return Modulos;
        }

        public void LlenarTreeView(TreeView tv)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();

            var accesos = contexto.Generales_Accesos.Select(acc => acc).OrderBy(acc => acc.orden).ToList();

            List<csNodo> listNodo = new List<csNodo>();
            csNodoHandler NodoHandler = new csNodoHandler();
            csNodo Nodo = new csNodo();
            TreeNodeCollection treeCollection = null;
            int posNodo = 0;
            int LengthSistema = 0;
            bool first = true;

            for (int x = 0; x < accesos.Count; x++)
            {
                TreeNode wnodo = new TreeNode();
                wnodo.Text = " " + accesos[x].nombre_acceso.ToString();
                wnodo.Tag = accesos[x].id_acceso.ToString();
                int strNodoLength = accesos[x].orden.ToString().Trim().Length;

                if (first)
                {
                    first = false;
                    LengthSistema = strNodoLength;
                    treeCollection = tv.Nodes;
                    listNodo.Add(new csNodo { posNodo = posNodo, LengthName = strNodoLength, nodeCollection = treeCollection });
                    treeCollection.Add(wnodo);
                }
                else if (strNodoLength > LengthSistema)
                {
                    posNodo = 0;
                    int countListNodo = listNodo.Count - 1;
                    bool exist = (NodoHandler.Search(listNodo, strNodoLength, out Nodo));
                    treeCollection = listNodo[countListNodo].nodeCollection[listNodo[countListNodo].posNodo].Nodes;
                    treeCollection.Add(wnodo);
                    LengthSistema = strNodoLength;
                    listNodo.Add(new csNodo { posNodo = posNodo, LengthName = LengthSistema, nodeCollection = treeCollection });
                }
                else if (strNodoLength == LengthSistema)
                {
                    bool exist = (NodoHandler.Search(listNodo, strNodoLength, out Nodo));
                    treeCollection = Nodo.nodeCollection;
                    treeCollection.Add(wnodo);
                    LengthSistema = strNodoLength;
                    posNodo = Nodo.posNodo + 1;
                    listNodo.Add(new csNodo { posNodo = posNodo, LengthName = LengthSistema, nodeCollection = treeCollection });
                }
                else if (strNodoLength < LengthSistema)
                {
                    bool exist = (NodoHandler.Search(listNodo, strNodoLength, out Nodo));
                    treeCollection = Nodo.nodeCollection;
                    treeCollection.Add(wnodo);
                    LengthSistema = strNodoLength;
                    posNodo = Nodo.posNodo + 1;
                    listNodo.Add(new csNodo { posNodo = posNodo, LengthName = LengthSistema, nodeCollection = treeCollection });
                }
            }
        }

        public void LlenarTreeViewUsuarios(TreeView tv, int idUsuario)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();

            var accesos_usuarios = contexto.Generales_Accesos_Usuarios.Where(acc => acc.id_usuario == idUsuario).ToList();

            int countList = accesos_usuarios.Count;
            if (countList > 0)
            {
                TreeNodeCollection treeNodeCollection = tv.Nodes;
                (new csNodoHandler()).RecorrerNodos(accesos_usuarios, treeNodeCollection);
            }
        }

        public void AgregaAccesosUsuarios(TreeView tv, int idUsuario)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();

            // BORRAMOS LOS ACCESOS POR USUARIO
            this.BorraAccesos(idUsuario);

            // AGREGAMOS ACCESOS POR USUARIO
            List<int> listNodo = new List<int>();
            listNodo = (new csNodoHandler()).RecorrerNodos(listNodo, tv.Nodes);
            //agrega_acceso_por_usuario(listNodo);

            for (int x = 0; x < listNodo.Count; x++)
            {
                Generales_Accesos_Usuarios Generales_Accesos_Usuarios = new Generales_Accesos_Usuarios();
                Generales_Accesos_Usuarios.id_usuario = idUsuario;
                Generales_Accesos_Usuarios.id_acceso = listNodo[x];

                contexto.Generales_Accesos_Usuarios.Add(Generales_Accesos_Usuarios);
                contexto.SaveChanges();
            }
        }

        public void BorrarAccesosUsuarios(int idUsuario, bool eliminar)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();

            //var accesos_usuario = contexto.Generales_Accesos_Usuarios.Where(acce => acce.id_usuario == idUsuario).ToList();

            //for (int x = 0; x < accesos_usuario.Count; x++)
            //{
            //    contexto.Generales_Accesos_Usuarios.Remove(accesos_usuario[x]);
            //    contexto.SaveChanges();
            //}

            var usuario = contexto.Generales_Usuarios.Where(user => user.id_usuario == idUsuario).Single();

            if (eliminar == true)
            {
                if (MessageBox.Show("¿Seguro desea eliminar usuario?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BorraAccesos(idUsuario);

                    contexto.Generales_Usuarios.Remove(usuario);
                    contexto.SaveChanges();

                    MessageBox.Show("Usuario Elimnado exitosamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //LlenarTreeViewUsuarios(null, idUsuario);
                }
            }
        }

        public void BorraAccesos(int idUsuario)
        {
            db_sporting_gymContainer contexto = new db_sporting_gymContainer();

            var accesos_usuario = contexto.Generales_Accesos_Usuarios.Where(acce => acce.id_usuario == idUsuario).ToList();

            for (int x = 0; x < accesos_usuario.Count; x++)
            {
                contexto.Generales_Accesos_Usuarios.Remove(accesos_usuario[x]);
                contexto.SaveChanges();
            }
        }
    }
}