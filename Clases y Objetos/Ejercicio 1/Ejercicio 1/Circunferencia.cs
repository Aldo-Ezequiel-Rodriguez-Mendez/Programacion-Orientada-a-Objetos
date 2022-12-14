using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Circunferencia
    {
		private double _dblRadio;

		public double Radio
		{
			get { return _dblRadio; }
			set { _dblRadio = value; }
		}

		public double CalcularPerimetro()
		{
			double dblPerimetro = Math.Pow(this.Radio, 2);
			return dblPerimetro;
		}

		public double CalcularArea()
		{
			double dblArea = Math.PI * (Math.Pow(this.Radio, 2));
			return dblArea;
		}

		public Circunferencia(double dblRadio)
		{
			this._dblRadio = dblRadio;
		}

	}
}
