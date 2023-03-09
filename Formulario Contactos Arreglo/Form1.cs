using System.Xml.Linq;
using System;

namespace Formulario_Contactos_Arreglo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contacto[] agendar;
       
        int numconctact;
        int length = 0;
        int index = 0;

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtnumcontact.Text);
            index = num;
            length = 0;
            agendar = new Contacto[index];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Contacto agendar = new Contacto();
            agendar.Nombre = txtname.Text;
            agendar.Telefono = txtcell.Text;
            agendar.FechaNacimiento = dtpfecha.Value;
            agendar.Correo = txtcorreo.Text;
         
            length++;
            CONTACTO.Items.Add(agendar);
        }

        private void CONTACTO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}