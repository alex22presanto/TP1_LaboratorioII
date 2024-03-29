﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {

        private string codigoDeBarras;
        private ConsoleColor colorPrimarioEmpaque;
        private EMarca marca;
 
        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }

        #region Getter

        /// <summary>
        /// ReadOnly: Retornará la cantidad de calorias
        /// </summary>
        protected abstract short CantidadCalorias 
        { 
            get;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Construcyor completo
        /// </summary>
        /// <param name="codigo">Codigo de barras del producto</param>
        /// <param name="marca">Marca del producto</param>
        /// <param name="color">Color del empaque del producto</param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.marca = marca;
            this.colorPrimarioEmpaque = color;
        }

        #endregion

        #region Metodo

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns>Retrona un string con todos sus datos</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Convierte a string un producto
        /// </summary>
        /// <param name="p">Produco a convertir</param>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\r\n", p.codigoDeBarras);
            sb.AppendFormat("MARCA          : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\r\n", p.colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------\n\n");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1">Primer producto a comparar</param>
        /// <param name="v2">Segundo producto a comparar</param>
        /// <returns>True si son diferentes False si son iguales</returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            if(v1.codigoDeBarras == v2.codigoDeBarras)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1">Primer producto a comparar</param>
        /// <param name="v2">Segundo producto a comparar</param>
        /// <returns>True si son diferentes False si son iguales</returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            if (v1.codigoDeBarras != v2.codigoDeBarras)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
