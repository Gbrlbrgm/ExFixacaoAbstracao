using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Tax();
    }
}
