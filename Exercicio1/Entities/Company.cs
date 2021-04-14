using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class Company : TaxPayer
    {
        public double NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double income, double numberOfEmployees) 
            : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return Income * 0.14;
            }

            else
            {
                return Income * 0.15; 
            }
        }
    }
}
