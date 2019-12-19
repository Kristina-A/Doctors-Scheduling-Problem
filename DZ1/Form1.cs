using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Terminations;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain;

namespace DZ1
{
    public partial class Form1 : Form
    {
        private List<Models.Doctor> doctors;
        private Random r;
        public Form1()
        {
            r = new Random();
            doctors = new List<Models.Doctor>();
            SetDoctors();
            InitializeComponent();
            lblFitness.Text = "";
        }

        private void SetDoctors()
        {
            List<int> notLike = new List<int>();
            for (int i = 1; i < 9; i++)
                doctors.Add(new Models.Doctor(i, "dr" + i, notLike));

            doctors[0].NotLike.AddRange(new int[] { 3, 7 });
            doctors[1].NotLike.Add(5);
            doctors[2].NotLike.Add(1);
            doctors[4].NotLike.AddRange(new int[] { 1, 4 });
            doctors[6].NotLike.Add(2);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Models.Instance i = new Models.Instance();
            i.Days = 7;
            i.Doctors = doctors;

            int min = (int)numMin.Value;
            int max = (int)numMax.Value;

            var chromosome = new Models.Chromosome(21, i, r);
            var population = new Population(min, max, chromosome);
            var fitness = new Models.Fitness();
            IMutation mutation = new TworsMutation();
            ISelection selection = new RouletteWheelSelection();
            ICrossover crossover = new OnePointCrossover(r.Next(20));

            if (cbxMutation.SelectedItem.ToString() == "Insertion")
                mutation = new InsertionMutation();
            else if (cbxMutation.SelectedItem.ToString() == "Partial Shuffle")
                mutation = new PartialShuffleMutation();
            else if (cbxMutation.SelectedItem.ToString() == "Reverse Sequence")
                mutation = new ReverseSequenceMutation();

            if (cbxSelection.SelectedItem.ToString() == "Elitizam")
                selection = new EliteSelection();

            if (cbxCrossover.SelectedItem.ToString() == "Two-point")
            {
                int p1 = r.Next(19);
                int p2 = r.Next(p1 + 1, 20);
                crossover = new TwoPointCrossover(p1, p2);
            }      
            else if (cbxCrossover.SelectedItem.ToString() == "Uniform")
                crossover = new UniformCrossover();

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);

            ITermination termination = new FitnessStagnationTermination(50);

            if (cbxTermination.SelectedItem.ToString() == "Generation number")
                termination = new GenerationNumberTermination(200);

            ga.Termination = termination;

            ga.MutationProbability = (float)numProbability.Value;

            ga.Start();

            Gene[] g = ga.BestChromosome.GetGenes();

            dataView.Rows.Clear();
            for(int j=0;j<7;j++)
            {
                string[] row = new string[] { ((List<int>)g[j*3].Value)[0].ToString()+ "   "+ ((List<int>)g[j*3].Value)[1].ToString() ,
                    ((List<int>)g[j * 3 + 1].Value)[0].ToString()+ "   "+ ((List<int>)g[j * 3 + 1].Value)[1].ToString()  ,
                    ((List<int>)g[j * 3 + 2].Value)[0].ToString()+ "   "+ ((List<int>)g[j * 3 + 2].Value)[1].ToString() };

                dataView.Rows.Add(row);
                dataView.Rows[j].HeaderCell.Value = (j+1).ToString();
            }

            lblFitness.Text = ga.BestChromosome.Fitness.ToString() + "  , generacija broj "+ga.GenerationsNumber.ToString();
        }
    }
}
