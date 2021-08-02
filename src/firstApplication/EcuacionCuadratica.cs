using System;
using System.Collections.Generic;
using System.Text;

namespace firstApplication
{
    class EcuacionCuadratica
    {
        private double _quadraticCoefficient;
        private double _linearCoefficient;
        private double _independentTerm;

        public EcuacionCuadratica(double quadraticCoefficient, double linearCoefficient, double independentTerm)
        {
            this._quadraticCoefficient = quadraticCoefficient;
            this._linearCoefficient = linearCoefficient;
            this._independentTerm = independentTerm;
        }

        public double Discriminating()
        {
            return Math.Pow(this._linearCoefficient, 2) - 4 * this._quadraticCoefficient * this._independentTerm;
        }

        public double[] GetRoots()
        {
            double[] roots;
            double discriminating = Discriminating();
            if (discriminating == 0)
            {
                roots = new double[]
                {
                    - _linearCoefficient / (2 * _quadraticCoefficient)
                };
            }
            else if (discriminating > 0)
            {
                roots = new double[]
                {
                    (- _linearCoefficient - Math.Sqrt(discriminating)) / (2 * _quadraticCoefficient),
                    (- _linearCoefficient + Math.Sqrt(discriminating)) / (2 * _quadraticCoefficient),
                };
            }
            else
            {
                roots = new double[0];
            }
            return roots;
        }
    }
}

