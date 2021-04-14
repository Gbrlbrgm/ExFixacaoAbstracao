using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double income, double healthExpeditures)
            : base(name, income)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            if (Income < 20000.0)
            {
                return Income * 0.15 - HealthExpeditures * 0.5;
            }
            else
            {
                return Income * 0.25 - HealthExpeditures * 0.5;
            }
        }
    }
}
