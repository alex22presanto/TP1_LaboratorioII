using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Snacks:Producto
    {
        #region Constructor

        /// <summary>
        /// Constructo completo
        /// </summary>
        /// <param name="marca">Marca del snack</param>
        /// <param name="codigo">Codigo de barras del snack</param>
        /// <param name="color">Color de empaque del snack</param>
        public Snacks(EMarca marca, string patente, ConsoleColor color): base(patente, marca, color)
        {
        }

        #endregion

        #region Getter
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        #endregion
        
        #region Metodo

        /// <summary>
        /// Publica todos los datos del snack.
        /// </summary>
        /// <returns>Retorna un stirng con todos los datos del snack</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Numero de calorias: {0}\n", this.CantidadCalorias);
            sb.AppendLine("-------------------");
            return sb.ToString();
        }
        #endregion
    }
}
