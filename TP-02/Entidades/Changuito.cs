using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    sealed public class Changuito
    {
        List<Producto> productos;
        int espacioDisponible;
        public enum ETipo
        {
            Dulce, Leche, Snacks, Todos
        }

        #region Constructores
        private Changuito()
        {
            this.productos = new List<Producto>();
        }
        public Changuito(int espacioDisponible): this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Muestro el Changuito y TODOS los Productos
        /// </summary>
        /// <returns>String con todos los productos</returns>
        public string ToString()
        {
            return Changuito.Mostrar(this, ETipo.Todos);
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="c">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Un string con todos los elementos</returns>
        public static string Mostrar(Changuito c, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", c.productos.Count, c.espacioDisponible);
            sb.AppendLine("");
            foreach (Producto producto in c.productos)
            {
                switch (tipo)
                {
                    case ETipo.Snacks:
                        if (producto is Snacks)
                        {
                            sb.AppendLine(producto.Mostrar());
                        }
                        break;
                    case ETipo.Dulce:
                        if (producto is Dulce)
                        {
                            sb.AppendLine(producto.Mostrar());
                        }
                        break;
                    case ETipo.Leche:
                        if (producto is Leche)
                        {
                            sb.AppendLine(producto.Mostrar());
                        }
                        break;
                    case ETipo.Todos:
                        sb.AppendLine(producto.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Agregará un producto a la lista a la lista
        /// </summary>
        /// <param name="c">Objeto donde se agregará el elemento</param>
        /// <param name="p">Objeto a agregar</param>
        /// <returns>Changuito con el producto agregado</returns>
        public static Changuito operator +(Changuito c, Producto p)
        {
            if(c.productos.Count >= c.espacioDisponible)
            {
                return c;
            }

            foreach (Producto v in c.productos)
            {
                if (v == p)
                {
                    return c;
                }
            }

            c.productos.Add(p);
            return c;
        }
        /// <summary>
        /// Quitará un producto de la lista
        /// </summary>
        /// <param name="c">Objeto donde se quitará el elemento</param>
        /// <param name="p">Objeto a quitar</param>
        /// <returns>Changuito con el producto quitado</returns>
        public static Changuito operator -(Changuito c, Producto p)
        {
            c.productos.Remove(p);

            return c;
        }
        #endregion
    }
}
