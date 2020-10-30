using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_05_DovalFragaJoseAngel_TreeView
{
    public partial class Formulario : Form
    {
        // variables globales
        List<Trabajador> trabajadores;
        private List<string> localidades;
        BindingSource listaLocalidadesBS;
        ListViewItem item;


        public Formulario()
        {
            InitializeComponent();
        }

        //
        // Eventos
        //

        private void Formulario_Load(object sender, EventArgs e)
        {

            // creamos un par de localidades
            localidades = new List<string>();
            localidades.Add("FERROL"); //0
            localidades.Add("BETANZOS"); //1
            localidades.Add("SADA"); //2
            localidades.Add("CORUÑA"); //3

            // creamos un par de trabajadores 
            trabajadores = new List<Trabajador>();
            trabajadores.Add(new Trabajador("JOSE","DOVAL", "BETANZOS", "JEFE", 1));
            trabajadores.Add(new Trabajador("DANIEL", "DI PASCUA", "SADA", "JEFE", 2));
            trabajadores.Add(new Trabajador("XIAN", "PEREZ", "FERROL", "JEFE", 0));
            trabajadores.Add(new Trabajador("PEDRO", "SANCHEZ", "BETANZOS", "1º OFICIAL", 0));
            trabajadores.Add(new Trabajador("CRISTIAN", "CASTRO", "SADA", "1º OFICIAL", 0));
            trabajadores.Add(new Trabajador("MARIANO", "RAJOY", "BETANZOS", "2º OFICIAL", 0));
            trabajadores.Add(new Trabajador("PABLO", "IGLESIAS", "CORUÑA", "JEFE", 3));

            

            //Binding de localidades
            listaLocalidadesBS = new BindingSource();
            listaLocalidadesBS.DataSource = localidades;
            localidades_comboBox.DataSource = listaLocalidadesBS;

            // ListView
            item = new ListViewItem();

            // TreeView
            CrearTreeView();

        }

        private void trabajadores_Btn_Click(object sender, EventArgs e)
        {
            int n = localidades_comboBox.SelectedIndex;
            string txt = localidades[n];
            ActualizarListView(txt);
        }

        private void altaLocalidad_Btn_Click(object sender, EventArgs e)
        {
            if (!localidades.Contains(localidad_TextBox.Text.ToUpper()))
            {
                localidades.Add(localidad_TextBox.Text.ToUpper());
                limpiarCampos();
                actualizarVinculos();
            }
            else
            {
                MessageBox.Show("Esta Localidad ya existe");
                localidad_TextBox.Clear();
                localidad_TextBox.Focus();
            }

        }

        private void nuevoEmpleado_Btn_Click(object sender, EventArgs e)
        {
            // recoger valores nombre, apellido, localidad seleccionada desde el tree y cargo seleccionado desde el tree, de momento la parte del tree esta sin hacer

            trabajadores.Add(new Trabajador(nombre_TextBox.Text, apellido_TextBox.Text));
            limpiarCampos(); 
        }

        //
        // Metodos
        //

        private void ActualizarListView(string txt)
        {
            trabajadores_ListView.Items.Clear();
            for (int i = 0; i < trabajadores.Count; i++)
            {
                if(trabajadores[i].Localidad == txt)
                item = trabajadores_ListView.Items.Add(trabajadores[i].Nombre);
                item.SubItems.Add(trabajadores[i].Apellido);
                item.SubItems.Add(trabajadores[i].Cargo);
            }
        }

        private void actualizarVinculos()
        {
            listaLocalidadesBS.ResetBindings(false);
            CrearTreeView();



        }

        private void limpiarCampos()
        {
            localidad_TextBox.Clear();
            nombre_TextBox.Clear();
            apellido_TextBox.Clear();
            trabajadores_TreeView.Nodes.Clear();
        }

        private void CrearTreeView()
        {

            trabajadores_TreeView.Nodes.Clear();
            trabajadores_TreeView.BeginUpdate();

            // creamos el nodo Principal
            trabajadores_TreeView.Nodes.Add("CUADRILLAS", "CUADRILLAS");
            int x = 0;
            localidades.ForEach(i =>
            {
                //trabajadores_TreeView.Nodes[0].Nodes.Clear();
                trabajadores_TreeView.Nodes[0].Nodes.Add("LOCALIDAD: " + i, "LOCALIDAD: " + i /*, id_imagen*/);

                var lstJefes = trabajadores.Where(t => t.Localidad == i && t.Cargo == "JEFE").ToList();

                lstJefes.ForEach(s =>
                {
                    int j = 0;
                    trabajadores_TreeView.Nodes[0].Nodes[x].Nodes.Add("JEFE: " + s.Nombre + " " + s.Apellido, "JEFE: " + s.Nombre + " " + s.Apellido /*, id_imagen*/ );

                    var lstOficial_1 = trabajadores.Where(t => t.Localidad == i && t.Cargo == "1º OFICIAL").ToList();
                    lstOficial_1.ForEach(h =>
                    {
                        trabajadores_TreeView.Nodes[0].Nodes[x].Nodes[j].Nodes.Add("1º OFICIAL: " + h.Nombre + " " + h.Apellido, "1º OFICIAL: " + h.Nombre + " " + h.Apellido);
                        int xj = 0;
                        var lstOficial_2 = trabajadores.Where(t => t.Localidad == i && t.Cargo == "2º OFICIAL").ToList();
                        lstOficial_2.ForEach(sh => {
                            trabajadores_TreeView.Nodes[0].Nodes[x].Nodes[j].Nodes[xj].Nodes.Add("2º OFICIAL: " + sh.Nombre + " " + sh.Apellido, "2º OFICIAL: " + sh.Nombre + " " + sh.Apellido);
                        });
                        xj++;
                    });
                    j++;
                });
                x++;
            });

            trabajadores_TreeView.ExpandAll();
            trabajadores_TreeView.EndUpdate();

        }

        //void PopulateTree(ref TreeNode root, List<Trabajador> trabajadoresList)
        //{
        //    if (root == null)
        //    {
        //        root = new TreeNode();
        //        root.Text = "Cuadrilla";
        //        root.Tag = null;
        //        // get all departments in the list with parent is null
        //        var details = trabajadoresList.Where(t => t.Localidad == null);
        //        foreach (var detail in details)
        //        {
        //            var child = new TreeNode()
        //            {
        //                Text = detail.Localidad,
        //                Tag = detail.Localidad,
        //            };
        //            PopulateTree(ref child, trabajadoresList);
        //            root.Nodes.Add(child);
        //        }
        //    }
        //    else
        //    {
        //        var id = (string)root.Tag;
        //        var details = trabajadoresList.Where(t => t.Cargo == id);
        //        foreach (var detail in details)
        //        {
        //            var child = new TreeNode()
        //            {
        //                Text = detail.Nombre,
        //                Tag = detail.Cargo,
        //            };
        //            PopulateTree(ref child, trabajadoresList);
        //            root.Nodes.Add(child);
        //        }
        //    }
        //}

    }
}
// tenemos 
/*
 * TreeNodes:
 * Treenode Cuadrillas --> 0 Cuadrillas
 *      Treenode Localidades --> 0 Localidad_1
 *                  Treenode Cargos: Jefe --> 0 Jefe_1
 *                              Treenode Cargos: Oficial_1 --> 0 Oficial1_1
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1

 *                              Treenode Cargos: Oficial_1 --> 1 Oficial1_2
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                                          Treenode Cargos: Oficial_2 --> 1 Oficial2_2

 *                              Treenode Cargos: Oficial_1 --> 2 Oficial1_3
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *      Treenode Localidades --> 1 Localidad_2
 *                  Treenode Cargos: Jefe --> 1 Jefe_2
 *                              Treenode Cargos: Oficial_1 --> 0 Oficial1_1
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                              Treenode Cargos: Oficial_1 --> 1 Oficial1_2
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                                          Treenode Cargos: Oficial_2 --> 1 Oficial2_2
 *                              Treenode Cargos: Oficial_1 --> 2 Oficial1_3
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *      Treenode Localidades --> 2 Localidad_3
 *                  Treenode Cargos: Jefe --> 2 Jefe_3
 *                              Treenode Cargos: Oficial_1 --> 0 Oficial1_1
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                              Treenode Cargos: Oficial_1 --> 1 Oficial1_2
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                                          Treenode Cargos: Oficial_2 --> 1 Oficial2_2
 *                                          Treenode Cargos: Oficial_2 --> 2 Oficial2_3
 *                              Treenode Cargos: Oficial_1 --> 2 Oficial1_3
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *      Treenode Localidades --> 3 Localidad_4
 *                  Treenode Cargos: Jefe --> 3 Jefe_4
 *                              Treenode Cargos: Oficial_1 --> 0 Oficial1_1
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                              Treenode Cargos: Oficial_1 --> 1 Oficial1_2
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *                                          Treenode Cargos: Oficial_2 --> 1 Oficial2_2
 *                              Treenode Cargos: Oficial_1 --> 2 Oficial1_3
 *                                          Treenode Cargos: Oficial_2 --> 0 Oficial2_1
 *      
 * 
 * Listas
 * 
 * Lista Localidades --> contiene lista Jefes
 * lista de trabajadores --> Contien objetos con los datos de cada trabajador
 * 
 * Clases
 * 
 * Trabajador --> objeto que contiene nombre , apellidos, Localidad, cargo, id_padre
 * 
 * Rellenar TreeNode --> tengo una funcion con lamdas donde recogo los datos de la listas y relleno el treeView,
 * con esta funcion no da igual el tamaño de las listas, los unico problema seria si se añaden mas cargos
 * 
 * 
 */