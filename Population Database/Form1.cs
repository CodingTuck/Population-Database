using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDataSet.City);

        }

        private void popAsc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationAsc(this.populationDataSet.City);
        }

        private void popDesc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByPopulationDesc(this.populationDataSet.City);
        }

        private void citySort_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.FillByCityName(this.populationDataSet.City);
        }

        private void calcPopulation_Click(object sender, EventArgs e)
        {
            //declare float to hold avg population
            float avgPopulation;

            //get total population
            avgPopulation = (float)this.cityTableAdapter.AvgPopulation();

            //declare float to hold total population
            float totalPopulation;

            //get total population
            totalPopulation = (float)this.cityTableAdapter.TotalPopulation();

            //declare float to hold highest population
            float highestPopulation;

            //get highest population
            highestPopulation = (float)this.cityTableAdapter.HighestPopulation();

            //declare float to hold highest population
            float lowestPopulation;

            //get highest population
            lowestPopulation = (float)this.cityTableAdapter.LowestPopulation();

            //display total population
            MessageBox.Show("Average population is: " + avgPopulation.ToString("0,##0.#\n\n")
               + "Total Population is: " + totalPopulation.ToString("0,##0.#\n\n") + 
               "Highest Population is: " + highestPopulation.ToString("0,##0.#\n\n") +
               "Lowest Population is: " + lowestPopulation.ToString("0,##0.#"));
        }
    }
}
