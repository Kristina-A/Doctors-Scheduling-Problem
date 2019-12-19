using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;

namespace DZ1.Models
{
    public class Fitness : IFitness
    {
        public double Evaluate(IChromosome chromosome)
        {
            double total = Rule1((Chromosome)chromosome) + Rule2((Chromosome)chromosome) + 
                Rule3((Chromosome)chromosome) + Rule4((Chromosome)chromosome) + Rule5((Chromosome)chromosome);
            return total*-1;
        }

        private double Rule1(Chromosome chromosome)//u 1 danu samo u 1 smeni moze da bude
        {
            Gene[] genes = chromosome.GetGenes();
            int num = 0;
            foreach(Doctor d in chromosome.Instance.Doctors)
            {
                for (int i = 0; i < chromosome.Instance.Days; i++)
                {
                    int n = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        if (((List<int>)genes[i*3+j].Value).Contains(d.Id))
                            n++;
                    }

                    if (n > 1)
                        num++;
                }
            }
            return num*2;
        }

        private double Rule2(Chromosome chromosome)//ne vise od dva puta uzastopno ista smena ili slobodan dan
        {
            Gene[] genes = chromosome.GetGenes();
            int num = 0;

            foreach (Doctor d in chromosome.Instance.Doctors)
            {
                for (int i = 0; i <= chromosome.Instance.Days-3; i++)
                {
                    List<int> l1 = chromosome.DailyDoctors(i);
                    List<int> l2 = chromosome.DailyDoctors(i+1);
                    List<int> l3 = chromosome.DailyDoctors(i+2);

                    if ((((List<int>)genes[i*3].Value).Contains(d.Id) && 
                        ((List<int>)genes[i*3 + 3].Value).Contains(d.Id) && 
                        ((List<int>)genes[i*3 + 6].Value).Contains(d.Id)))
                        num++;

                    if (((List<int>)genes[i*3 + 1].Value).Contains(d.Id) && 
                        ((List<int>)genes[i*3 + 4].Value).Contains(d.Id) && 
                        ((List<int>)genes[i*3 + 7].Value).Contains(d.Id))
                        num++;

                    if (((List<int>)genes[i*3 + 2].Value).Contains(d.Id) &&
                        ((List<int>)genes[i*3 + 5].Value).Contains(d.Id) &&
                        ((List<int>)genes[i*3 + 8].Value).Contains(d.Id))
                        num++;

                    if (!l1.Contains(d.Id) && !l2.Contains(d.Id) && !l3.Contains(d.Id))
                        num++;
                }
            }
            return num;
        }

        private double Rule3(Chromosome chromosome)//posle nocne smene ne moze jutarnja ili popodnevna
        {
            Gene[] genes = chromosome.GetGenes();
            int num = 0;

            foreach (Doctor d in chromosome.Instance.Doctors)
            {
                for (int i = 0; i < chromosome.Instance.Days-1; i++)
                {
                    if (((List<int>)genes[i * 3+2].Value).Contains(d.Id) && 
                        (((List<int>)genes[(i+1) * 3].Value).Contains(d.Id) || ((List<int>)genes[(i+1) * 3 + 1].Value).Contains(d.Id)))
                        num++;
                }
            }
            return num*2;
        }

        private double Rule4(Chromosome chromosome)//posle 2 nocne smene slobodan dan
        {
            Gene[] genes = chromosome.GetGenes();
            int num = 0;

            foreach (Doctor d in chromosome.Instance.Doctors)
            {
                for (int i = 0; i <= chromosome.Instance.Days - 3; i++)
                {
                    List<int> l = chromosome.DailyDoctors(i+2);

                    if (((List<int>)genes[i * 3 + 2].Value).Contains(d.Id) &&
                        ((List<int>)genes[(i+1) * 3 + 2].Value).Contains(d.Id) &&
                        l.Contains(d.Id))
                        num++;
                }
            }
            return num;
        }

        private double Rule5(Chromosome chromosome)//ko sa kim ne zeli u smeni da radi
        {
            Gene[] genes = chromosome.GetGenes();
            int num = 0;

            for (int i = 0; i < chromosome.Length; i++)
            {
                int dr1 = ((List<int>)genes[i].Value)[0];
                int dr2 = ((List<int>)genes[i].Value)[1];

                if (chromosome.Instance.Doctors[dr1-1].NotLike.Contains(dr2))
                    num++;

                if (chromosome.Instance.Doctors[dr2 - 1].NotLike.Contains(dr1))
                    num++;
            }
            return num*0.5;
        }
    }
}
