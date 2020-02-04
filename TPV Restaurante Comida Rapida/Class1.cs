using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPV_Restaurante_Comida_Rapida
{
    class producto
    {
        public String nombre;
        public double precio;
        public String definicion;
        public String imagen;
        public List<String> ingredientes = new List<string>();
        public String tamaño;

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public double getPrecio()
        {
            return this.precio;
        }

        public void setDefinicion(String definicion)
        {
            this.definicion = definicion;
        }

        public String getDefinicion()
        {
            return this.definicion;
        }

        public void setImagen(String imagen)
        {
            this.imagen = imagen;
        }

        public String getImagen()
        {
            return this.imagen;
        }

        public void setIngredientes(String ingrediente)
        {
            this.ingredientes.Add(ingrediente);
        }

        public void setTamaño(String tamaño)
        {
            this.tamaño = tamaño;
        }

        public String getTamaño()
        {
            return this.tamaño;
        }

        public void aumentarPrecio(double precio)
        {
            this.precio = this.precio + precio;
        }
    }
}
