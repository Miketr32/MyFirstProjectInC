using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProjectInC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido", "Holis");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.textBox1.Text = "Hola";
            this.button3.Text = "Me cambiaron!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Chocolate;
            if (this.BackColor.Equals(Color.White))
            {
                this.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.White;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido", "Holiss");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Deshabilitar")
            {
                button4.Text = "Habilitar";
                this.button3.Enabled = false;
            }
            else if (button4.Text == "Habilitar")
            {
                button4.Text = "Deshabilitar";
                this.button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = DateTime.Now.ToString(); // Siempre sera necesario convertir el valor a String
            if (this.timer1.Enabled == true)
            {
                timer1.Stop();
                button5.Text = "Start";
            }
            else
            {
                timer1.Start();
                button5.Text = "Stop";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please, select an option:", "Title of Message Box", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            // El orden es: Mensaje ==> Titulo ==> Botones ==> Icono ==> Boton seleccionado ==> Estilos
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.Image = Image.FromFile("C:\\Users\\miguel.coronel\\Pictures\\Wallpapers\\Space\\nasa--hI5dX2ObAs-unsplash.jpg"); //Esto puede fallar en la otra compu
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String nombre = this.textBox2.Text;
            MessageBox.Show("Hi: " + nombre);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Forma normal
            
            //int number1 = Convert.ToInt32(this.textBox3.Text);
            //int number2 = Convert.ToInt32(this.textBox4.Text);

            //Forma a prueba de errores

            int number1;
            int number2;

            int.TryParse(this.textBox3.Text, out number1); //Se usa en el caso de que algunos de los valores sean nulos, un String o un valor
            int.TryParse(this.textBox4.Text, out number2);// mayor a Int32. El parametro 'out' setea el valor en un entero (0)

            int suma = number1 + number2;
            
            MessageBox.Show(Convert.ToString(suma),"Resultado"); // Hay que hacer esto ya que la funcion Show devuelve un String
            //Alternativa: MessageBox.Show(suma.ToString());
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\system32\\notepad.exe";
            this.process1.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Dejare esto en pausa hasta aprender una forma mas pro de desarrollar esto =)
        }
    }
}
