using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {
        #region Constructor

        /// <summary>
        /// Constructo completo
        /// </summary>
        /// <param name="marca">Marca del dulce</param>
        /// <param name="codigo">Codigo de barras del dulce</param>
        /// <param name="color">Color de empaque del dulce</param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color):base (codigo,marca,color)
        {
        }

        #endregion

        #region Getter

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Publica todos los datos del dulce.
        /// </summary>
        /// <returns>Retorna un stirng con todos los datos del dulce</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DULCE");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Numero de calorias: {0}\n", this.CantidadCalorias);
            sb.AppendLine("-------------------");
            return sb.ToString();
        }

        #endregion
    }
}
