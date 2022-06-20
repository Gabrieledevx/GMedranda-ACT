using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMedranda_ACT.ProcessA
{
    public class CrudA
    {
        List<Alumno> ListadoAlumnos=new List<Alumno>();
        List<Alumno> ListadoALumnosE = new List<Alumno>();
        //Metodo para agregar alumnos
        public string gmAgregarAlumno(Alumno alum)
        {
            try
            {
                if(alum.nombre!=""|| alum.apellidos!="" 
                   || alum.carrera !="")
                {
                    ListadoAlumnos.Add(alum);
                    MessageBox.Show("Se ha registrado a" + "\n " + alum.nombre + " " + alum.apellidos);
                }

                else { MessageBox.Show("Debe de llenar todos los campos"); }
                

                return "Se ha agregado el alumno correctamente";
            }
            catch(Exception ex)
            {
                return "Error ->: " + ex.ToString();
            }
        }



        //Metodo para editar alumnos


        //Metodo para buscar alumnos por cedula

        public Alumno gmBuscarAlumno(int ced) 
        {
            try
            {
                for(int i = 0; i < ListadoAlumnos.Count; i++) { 
                    
                    if(ced == ListadoAlumnos[i].cedula)
                    {
                        string nombre = ListadoAlumnos[i].nombre;
                        string apellido = ListadoAlumnos[i].apellidos;
                        string carrera = ListadoAlumnos[i].carrera;
                        Alumno alum = new Alumno(ced,nombre,apellido,carrera, false);
                        return alum;
                    }
                    else
                    {
                        return null;
                    }

                }
                return null;
            }
            catch(Exception ex)
            {

                return null;
            }

            
        }


        //Metodo para ver alumnos elimininados 
        public bool gmLlenaListEliminados(ListView miview)
        {
            ListViewItem item = new ListViewItem();

            if (ListadoALumnosE.Count == 0)
            {
                MessageBox.Show("No existen alumnos eliminados!");
            }

            else
            {
                for (int i = 0; i < ListadoALumnosE.Count; i++)
                {

                    item = miview.Items.Add("0" + ListadoALumnosE[i].cedula.ToString());
                    item.SubItems.Add(ListadoALumnosE[i].nombre);
                    item.SubItems.Add(ListadoALumnosE[i].apellidos);
                    item.SubItems.Add(ListadoALumnosE[i].carrera);

                }

            }

            return false;
        }

        //Metodo para llenar el objeto con los datos de la lista
        public bool gmLlenaListView(ListView miview)
        {
            ListViewItem item = new ListViewItem();
            
            if(ListadoAlumnos.Count == 0)
            {
                MessageBox.Show("No existen alumnos registrados !");
            }

            else
            {
                for( int i = 0; i < ListadoAlumnos.Count; i++)
                {
                    
                    item = miview.Items.Add("0" + ListadoAlumnos[i].cedula.ToString());
                    item.SubItems.Add(ListadoAlumnos[i].nombre);
                    item.SubItems.Add(ListadoAlumnos[i].apellidos);
                    item.SubItems.Add(ListadoAlumnos[i].carrera);

                }

            }

            return false;
        }

        //Metodo para eliminar (cambiar estado de alumnos)
        public bool gmEliminarAlumno(ListView miview)
        {
            
                
                /*Alumno alume = new Alumno(ListadoAlumnos[miview.FocusedItem.Index].cedula
                    , ListadoAlumnos[miview.FocusedItem.Index].nombre, ListadoAlumnos[miview.FocusedItem.Index].apellidos
                    , ListadoAlumnos[miview.FocusedItem.Index].carrera, ListadoAlumnos[miview.FocusedItem.Index].ban);
                */
                ListadoALumnosE.Add(new Alumno(ListadoAlumnos[miview.FocusedItem.Index].cedula
                    , ListadoAlumnos[miview.FocusedItem.Index].nombre, ListadoAlumnos[miview.FocusedItem.Index].apellidos
                    , ListadoAlumnos[miview.FocusedItem.Index].carrera, ListadoAlumnos[miview.FocusedItem.Index].ban));
            ListadoAlumnos.RemoveAt(miview.FocusedItem.Index);
            MessageBox.Show("Se ha eliminado a : " + ListadoALumnosE[0].nombre);
            miview.Items.Clear();
            return false;
            
            
           

        }
    }
}
