using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticSharp.Domain.Chromosomes;

namespace DZ1.Models
{
    public class Chromosome : ChromosomeBase
    {
        public Instance Instance { get; set; }
        private Random r;
        public Chromosome(int n, Instance i, Random rand) : base(n)
        {
            Instance = i;
            r = rand;
            CreateGenes();
        }
        public override IChromosome CreateNew()
        {
            int num = 3 * Instance.Days;
            Chromosome c = new Chromosome(num, Instance, r);

            return c;
        }

        public override Gene GenerateGene(int geneIndex)
        {
            int num = Instance.Doctors.Count;
            List<int> l = new List<int>();
            int d1 = r.Next(1, num+1);
            l.Add(d1);
            int d2 = r.Next(1, num+1);
            while (d1 == d2)
                d2 = r.Next(1, num+1);
            l.Add(d2);

            return new Gene(l);
        }

        public List<int> DailyDoctors(int day)
        {
            List<int> doctors = new List<int>();
            Gene[] genes = GetGenes();

            doctors.AddRange((List<int>)genes[day * 3].Value);
            doctors.AddRange((List<int>)genes[day * 3+1].Value);
            doctors.AddRange((List<int>)genes[day * 3+2].Value);

            return doctors;
        }
    }
}
