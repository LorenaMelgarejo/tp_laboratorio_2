using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Debe Heredar de Vehiculo
    /// </summary>
    public class Suv : Vehiculo
    {
        #region Constructores

        public Suv(EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {}

        #endregion

        #region Propiedades

        ///// <summary>
        ///// SUV son 'Grande'
        ///// </summary>
        ///Debe ser de tipo ETamanio
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;//debe retornar grande
            }
        }

        #endregion

        #region Metodos

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : " + this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
