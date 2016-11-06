using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proch
{
    public class Cheque
    {
        

        #region Atributos
        private double _importe;
        private double _interes;
        private double _gastos;
        private double _iva;
        private double _resultado;
        #endregion
        #region Constructores
        public Cheque():this(0,0,0)
        {
        }

                    // LOS VALIDO ANTES CON STATIC VALIDAR CHEQUE
        public Cheque( double importe, double interes, double gastos)
        {
            this._importe = importe;
            this._interes = interes;
            this._gastos = gastos;
            
        }


        #endregion


        #region Propiedades
        public double importe
        {
            get
            {
                return _importe;
            }
            set
            {
                this._importe = value;
            }
        }

        public double interes
        {
            get
            {
                return _interes;
            }
            set
            {
                this._interes = value;
            }
        }

        public double gastos
        {
            get
            {
                return _gastos;
            }
            set
            {
                this._gastos = value;
            }
        }

        public double iva
        {
            get
            {
                return _iva;
            }
            set
            {
                this._iva = value;
            }
        }

        public double resultado
        {
            get
            {
                return _resultado;
            }
            set
            {
                this._resultado = value;
            }
        }
        #endregion
        #region Sobrecarga Operadores
        public static Boolean operator +(Cheque[] cheques, Cheque cheque2)
        {
            Boolean retorno = false;
            for (int i = 0; i < cheques.Length; i++)
            {
                if(object.Equals(cheques[i], null))
                {
                    cheques[i] = cheque2;
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static Cheque operator +(Cheque cheque1, Cheque cheque2)
        {
            cheque1.importe = cheque1.importe + cheque2.importe;
            cheque1.gastos = cheque1.gastos + cheque2.gastos;
            cheque1.interes = cheque1.interes + cheque2.interes;
            cheque1.iva = cheque1.iva + cheque2.iva;
            cheque1.resultado = cheque1.resultado + cheque2.resultado;
            return cheque1;
        }
        #endregion
        public static Cheque calcular(Cheque Cheque)
        {
            Cheque miCheque = new Cheque(Cheque.importe, Cheque.interes, Cheque.gastos);
            miCheque.iva = (miCheque.interes + miCheque.gastos) * 0.21;
            miCheque.resultado = miCheque.importe - miCheque.interes - miCheque.gastos - miCheque.iva;
            return miCheque;
        }

    }
}
