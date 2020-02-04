using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPV_Restaurante_Comida_Rapida
{
    public partial class Pantalla1 : Form
    {
        List<producto> carrito = new List<producto>();
        producto pollo1 = new producto();
        producto pollo2 = new producto();
        producto ternera1 = new producto();
        producto ternera2 = new producto();
        producto ternera3 = new producto();
        producto ternera4 = new producto();
        producto oferta1 = new producto();
        producto oferta2 = new producto();
        producto oferta3 = new producto();
        producto oferta4 = new producto();
        producto productoActual = new producto();
        int contadorpollo1;
        int contadorpollo2;
        int contadorternera1;
        int contadorternera2;
        int contadorternera3;
        int contadorternera4;
        int contadoroferta1;
        int contadoroferta2;
        int contadoroferta3;
        int contadoroferta4;
        int numeropedido;
        String tipopedido;
        ListViewItem elementoListView;
        double preciopedido;

        public Pantalla1()
        {
            InitializeComponent();

            numeropedido = 1;
            preciopedido = 0.0;
            //pollo1
            pollo1.setNombre("Crispy Chicken");
            pollo1.setPrecio(3.99);
            
            pollo1.ingredientes.Add("Tomate");
            pollo1.ingredientes.Add("Lechuga");
            pollo1.ingredientes.Add("Mayonesa");
          
            ControlBox = false;

            //pollo2
            pollo2.setNombre("Long Chicken");
            pollo2.setPrecio(4.99);
            
            pollo2.ingredientes.Add("Lechuga");
            pollo2.ingredientes.Add("Mayonesa");
     
            ControlBox = false;

            //ternera1
            ternera1.setNombre("Cheese Burger");
            ternera1.setPrecio(5.50);
            
            ternera1.ingredientes.Add("Pepinillos");
            ternera1.ingredientes.Add("Ketchup");
            ternera1.ingredientes.Add("Queso");
      
            ControlBox = false;

            //ternera2
            ternera2.setNombre("Cheese Burger");
            ternera2.setPrecio(3.50);
            
            ternera2.ingredientes.Add("Pepinillos");
            ternera2.ingredientes.Add("Ketchup");
            ternera2.ingredientes.Add("Lechuga");
            ternera2.ingredientes.Add("Cebolla");
            ternera2.ingredientes.Add("Tomate");
   
            ControlBox = false;

            //ternera3
            ternera3.setNombre("Cheese Burger");
            ternera3.setPrecio(8.99);
            
            ternera3.ingredientes.Add("Pepinillos");
            ternera3.ingredientes.Add("Ketchup");
            ternera3.ingredientes.Add("Lechuga");
            ternera3.ingredientes.Add("Cebolla");
            ternera3.ingredientes.Add("Tomate");
    
            ControlBox = false;

            //ternera4
            ternera4.setNombre("Cheese Burger");
            ternera4.setPrecio(4.99);
            
            ternera4.ingredientes.Add("Pepinillos");
            ternera4.ingredientes.Add("Ketchup");
            ternera4.ingredientes.Add("Queso");
      
            ControlBox = false;

            //oferta1
            oferta1.setNombre("Patatas");
            oferta1.setPrecio(0.50);
            oferta1.ingredientes.Add("Patatas");
      
            ControlBox = false;

            //oferta2
            oferta2.setNombre("Crispy Chicken");
            oferta2.setPrecio(1);
            oferta2.ingredientes.Add("Lechuga");
            oferta2.ingredientes.Add("Tomate");
            oferta2.ingredientes.Add("Mayonesa");
   
            ControlBox = false;

            //oferta3
            oferta3.setNombre("Cheese Bacon");
            oferta3.setPrecio(0.99);
            oferta3.ingredientes.Add("Queso");
            oferta3.ingredientes.Add("Bacon");
      
            ControlBox = false;

            //oferta4
            oferta1.setNombre("Croissant");
            oferta1.setPrecio(0.75);
            oferta1.ingredientes.Add("Queso");
  
            ControlBox = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void button11_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label50.Text = numeropedido.ToString();
            label51.Text = tipopedido.ToString();
            label52.Text = preciopedido.ToString();
            tabControl1.SelectedTab = tabPage9;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oferta añadida con éxito");
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido realizado con éxito. Diríjase al mostrador para pagar.");
            numeropedido++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            contadorternera1 = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            productoActual = ternera1;
            for (int i = 0; i < contadorternera1; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label50.Text = numeropedido.ToString();
            label51.Text = tipopedido.ToString();
            label52.Text = preciopedido.ToString();
            tabControl1.SelectedTab = tabPage9;
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            contadorpollo1 = Convert.ToInt32(Math.Round(numericUpDown5.Value, 0));
            productoActual = pollo1;
            for (int i = 0; i < contadorpollo1; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            contadorpollo2 = Convert.ToInt32(Math.Round(numericUpDown6.Value, 0));
            productoActual = pollo2;
            for (int i = 0; i < contadorpollo2; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            contadorternera2 = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            productoActual = ternera2;
            for (int i = 0; i < contadorternera2; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            contadorternera3 = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
            productoActual = ternera3;
            for (int i = 0; i < contadorternera3; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            contadorternera4 = Convert.ToInt32(Math.Round(numericUpDown4.Value, 0));
            productoActual = ternera4;
            for (int i = 0; i < contadorternera4; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            contadoroferta1 = Convert.ToInt32(Math.Round(numericUpDown8.Value, 0));
            productoActual = oferta1;
            for (int i = 0; i < contadoroferta1; i++) {
                carrito.Add(productoActual);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            contadoroferta2 = Convert.ToInt32(Math.Round(numericUpDown9.Value, 0));
            productoActual = oferta2;
            for (int i = 0; i < contadoroferta2; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            contadoroferta3 = Convert.ToInt32(Math.Round(numericUpDown7.Value, 0));
            productoActual = oferta3;
            for (int i = 0; i < contadoroferta3; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            contadoroferta4 = Convert.ToInt32(Math.Round(numericUpDown10.Value, 0));
            productoActual = oferta4;
            for (int i = 0; i < contadoroferta4; i++)
            {
                carrito.Add(productoActual);
            }
        }

        private void label50_Click(object sender, EventArgs e)
        {
            //label50.Text = numeropedido.ToString();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true) {
                tipopedido = "Tomar aquí";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                tipopedido = "Para llevar";
            }
        }

        private void label51_Click(object sender, EventArgs e)
        {
            label51.Text = tipopedido.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            label50.Text = numeropedido.ToString();
            label51.Text = tipopedido;
            tabControl1.SelectedTab = tabPage9;
        }

        private void calcularPrecioTotal(double preciopedido) {
            for (int i = 0; i < carrito.Capacity; i++) {
                preciopedido = preciopedido + carrito[i].getPrecio();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label50.Text = numeropedido.ToString();
            label51.Text = tipopedido.ToString();
            label52.Text = preciopedido.ToString();
            tabControl1.SelectedTab = tabPage9;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
