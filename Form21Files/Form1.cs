namespace Form21Files
{
    public partial class Form1 : Form
    {

        private string Path { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Path = @"C:\Users\Alumnos MCSD Mañana\Desktop\file1.txt";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }


        private void txtContenido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.Path);
            using (TextWriter writer = file.CreateText()) 
            {
                string contenido = this.GetNombresListBox();
                await writer.WriteAsync(contenido);
                await writer.FlushAsync();
                writer.Close();
                MessageBox.Show("Datos almacenados");
            }
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.Path);
            using (TextReader reader = file.OpenText()) 
            {
                string contenido = await reader.ReadToEndAsync();
                this.txtContenido.Text = contenido;
                this.RellenarListBox(contenido);
                reader.Close();
            }
           
        }


        
        private async void RellenarListBox(String contenido)
        {
                string[] list = contenido.Split(',');
                foreach (string str in list)
                {
                    lstNombres.Items.Add(str);
                }
           
            }
           
        }
}
