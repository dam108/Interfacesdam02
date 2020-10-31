using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Practica_05_DovalFragaJoseAngel_TreeView
{
    public partial class Formulario : Form
    {
        // variables globales
        private List<Trabajador> trabajadores;
        private List<string> localidades;
        BindingSource listaLocalidadesBS;
        ListViewItem item;
        ImageList iconos;

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
            localidades.Add("FERROL");
            localidades.Add("BETANZOS");
            localidades.Add("SADA");
            localidades.Add("CORUÑA");

            // creamos un par de trabajadores 
            trabajadores = new List<Trabajador>();
            trabajadores.Add(new Trabajador("JOSE","DOVAL", "BETANZOS", "JEFE", 1));
            trabajadores.Add(new Trabajador("MANUEL", "ORTEGA", "SADA", "JEFE", 2));
            trabajadores.Add(new Trabajador("DIEGO", "PEREZ", "FERROL", "JEFE", 0));
            trabajadores.Add(new Trabajador("JUAN", "SANCHEZ", "BETANZOS", "1º OFICIAL", 0));
            trabajadores.Add(new Trabajador("MIGUEL", "CASTRO", "SADA", "1º OFICIAL", 0));
            trabajadores.Add(new Trabajador("JESUS", "IGLESIAS", "BETANZOS", "2º OFICIAL", 0));
            trabajadores.Add(new Trabajador("PABLO", "SILVA", "CORUÑA", "JEFE", 3));

            //Binding de localidades
            listaLocalidadesBS = new BindingSource();
            listaLocalidadesBS.DataSource = localidades;
            localidades_comboBox.DataSource = listaLocalidadesBS;

            // ListView
            item = new ListViewItem();


            // Imagenes treeView
            iconos = new ImageList();
            iconos.Images.Add(Image.FromFile(@"../../../icons/archivo.png"));
            iconos.Images.Add(Image.FromFile(@"../../../icons/carpetaAbierta.png"));
            iconos.Images.Add(Image.FromFile(@"../../../icons/carpetaCerrada.png"));
            iconos.Images.Add(Image.FromFile(@"../../../icons/archivoAbierto.png"));
            trabajadores_TreeView.ImageList = iconos;
            trabajadores_TreeView.SelectedImageIndex = 2;

            // cargamos el treeView
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
                MessageBox.Show("Esta Localidad ya existe", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                localidad_TextBox.Clear();
                localidad_TextBox.Focus();
            }

        }

        private void nuevoEmpleado_Btn_Click(object sender, EventArgs e)
        {
            string localidad;
            string cargo;
            int id_padre;
            string nombre = nombre_TextBox.Text.ToUpper();
            string apellido = apellido_TextBox.Text.ToUpper();

            var lstNombres = trabajadores.Where(t => t.Nombre == nombre && t.Apellido == apellido).ToList();

            if (lstNombres.Count > 0) // comprobamos si el nombre y el apellido ya existe
            {
                MessageBox.Show("Este Trabajador ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarCampos();
                nombre_TextBox.Focus();
            }
            else if (nombre == "")
            {
                MessageBox.Show("Te falta el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nombre_TextBox.Focus();
            }
            else if (apellido == "")
            {
                MessageBox.Show("Te falta el apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                apellido_TextBox.Focus();
            }
            else if (trabajadores_TreeView.SelectedNode == null || trabajadores_TreeView.SelectedNode.Level == 0)
            {
                MessageBox.Show("Tienes que seleccionar un nodo a partir de localidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (trabajadores_TreeView.SelectedNode.Level == 1)  // si el elemento seleccionado es Localidad
                {
                    if (ComprobarNodoTieneHijos(trabajadores_TreeView.SelectedNode)) // comprobamos que no tenga hijos
                    {
                        MessageBox.Show("Ya hay un jefe es esta localidad, no se pueden crear mas jefes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        // crear aqui al jefe
                        localidad = trabajadores_TreeView.SelectedNode.Name.Substring(11);
                        cargo = "JEFE";
                        id_padre = trabajadores_TreeView.SelectedNode.Parent.Index;
                        trabajadores.Add(new Trabajador(nombre, apellido, localidad, cargo, id_padre));
                        actualizarVinculos();
                    }
                }
                else if (trabajadores_TreeView.SelectedNode.Level == 2) // si el elemento seleccionado es Jefe
                {
                    // crear aqui al primer oficial
                    localidad = trabajadores_TreeView.SelectedNode.Parent.Name.Substring(11);
                    cargo = "1º OFICIAL";
                    id_padre = trabajadores_TreeView.SelectedNode.Parent.Index;
                    trabajadores.Add(new Trabajador(nombre, apellido, localidad, cargo, id_padre));
                    actualizarVinculos();
                }
                else if (trabajadores_TreeView.SelectedNode.Level == 3) // si el elemento seleccionado es 1º oficial
                {
                    // crear aqui al segundo oficial
                    localidad = trabajadores_TreeView.SelectedNode.Parent.Parent.Name.Substring(11);
                    cargo = "2º OFICIAL";
                    id_padre = trabajadores_TreeView.SelectedNode.Parent.Index;
                    trabajadores.Add(new Trabajador(nombre, apellido, localidad, cargo, id_padre));
                    actualizarVinculos();
                }
                else 
                {
                    MessageBox.Show("No se puede crear un un trabajador por debajo de la carpeta 2º OFICIAL, porfavor selecciona otra carpeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //
        // Metodos
        //
        private bool ComprobarNodoTieneHijos(TreeNode nodo)
        {
            if (nodo.Nodes.Count > 0) return true;

            return false;
        }

        private void ActualizarListView(string txt)
        {
            trabajadores_ListView.Items.Clear();
            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].Localidad == txt)
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
        }

        private void CrearTreeView()
        {

            trabajadores_TreeView.Nodes.Clear();
            trabajadores_TreeView.BeginUpdate();

            // creamos el nodo Principal
            trabajadores_TreeView.Nodes.Add("CUADRILLAS", "CUADRILLAS", 1);
            int x = 0;
            localidades.ForEach(i =>
            {
                trabajadores_TreeView.Nodes[0].Nodes.Add("LOCALIDAD: " + i, "LOCALIDAD: " + i, 1);

                var lstJefes = trabajadores.Where(t => t.Localidad == i && t.Cargo == "JEFE").ToList();

                lstJefes.ForEach(s =>
                {
                    int j = 0;
                    trabajadores_TreeView.Nodes[0].Nodes[x].Nodes.Add("JEFE: " + s.Nombre + " " + s.Apellido, "JEFE: " + s.Nombre + " " + s.Apellido, 1 );

                    var lstOficial_1 = trabajadores.Where(t => t.Localidad == i && t.Cargo == "1º OFICIAL").ToList();
                    lstOficial_1.ForEach(h =>
                    {
                        trabajadores_TreeView.Nodes[0].Nodes[x].Nodes[j].Nodes.Add("1º OFICIAL: " + h.Nombre + " " + h.Apellido, "1º OFICIAL: " + h.Nombre + " " + h.Apellido, 1);
                        int xj = 0;
                        var lstOficial_2 = trabajadores.Where(t => t.Localidad == i && t.Cargo == "2º OFICIAL").ToList();
                        lstOficial_2.ForEach(sh => {
                            trabajadores_TreeView.Nodes[0].Nodes[x].Nodes[j].Nodes[xj].Nodes.Add("2º OFICIAL: " + sh.Nombre + " " + sh.Apellido, "2º OFICIAL: " + sh.Nombre + " " + sh.Apellido, 0, 3);
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
    }
}
