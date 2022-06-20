namespace GMedranda_ACT

{
    public partial class Form1 : Form
    {
        ProcessA.CrudA gmedranda = new ProcessA.CrudA();

        public Form1()
        {
            InitializeComponent();
            btneliminar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
            gmedranda.gmEliminarAlumno(miview);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try { 
                int ced = Int32.Parse(txtcedula.Text);
            string nom = txtnombres.Text;
            string ape = txtapellidos.Text;
            string carr = txtcarrera.Text;
            Alumno alum = new Alumno(ced, nom, ape, carr, false);
            gmedranda.gmAgregarAlumno(alum);
           

           
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe de llenar todos los datos");
            }
        }

        private void btnelementos_Click(object sender, EventArgs e)
        {
            btneliminar.Enabled = true;
            miview.Items.Clear();
            gmedranda.gmLlenaListView(miview);
        }

        private void miview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnelmelim_Click(object sender, EventArgs e)
        {
            btneliminar.Enabled=false;
            miview.Items.Clear();
            gmedranda.gmLlenaListEliminados(miview);
        }
    }
}