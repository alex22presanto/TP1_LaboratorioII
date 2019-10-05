using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2018
{
    public class Leche : Producto
    {
        private ETipo tipo;

        public enum ETipo 
        { 
            Entera, 
            Descremada 
        }

        #region Constructor

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca">Marca de la leche</param>
        /// <param name="codigo">Codigo de barras de la leche</param>
        /// <param name="color">Color del producto</param>
        public Leche(EMarca marca, string codigo, ConsoleColor color): base(codigo, marca, color)
        {
            this.tipo = ETipo.Entera;
        }

        /// <summary>
        /// Constructor compelto
        /// </summary>
        /// <param name="marca">Marca de la leche</param>
        /// <param name="patente">Codigo de barras de la leche</param>
        /// <param name="color">Color del producto</param>
        /// <param name="tipo">Tipo de leche</param>
        public Leche(EMarca marca, string patente, ConsoleColor color,ETipo tipo) : base(patente, marca, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Getter
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Publica todos los datos de la leche.
        /// </summary>
        /// <returns>Retorna un stirng con todos los datos de la leche</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.
            sb.AppendLine("LECHE");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Numero de calorias: {0}\n", this.CantidadCalorias);
            sb.AppendLine("-------------------");
            return sb.ToString();
        }

        #endregion
    }
}
