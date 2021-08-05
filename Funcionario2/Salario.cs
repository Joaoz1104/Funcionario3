using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario2
{
    class Salario
    {
        public string Nome1 { get; set; }
        private int Salario1 { get; set; }
        public string Nome2 { get; set; }
        private int Salario2 { get; set; }

        public int MediaSalario()
        {
            int Media = (Salario1 + Salario2) / 2;
            return Media;
        }
        public override string ToString()
        {
            return $"Salário médio : {MediaSalario():F2}";
        }
    }
}
