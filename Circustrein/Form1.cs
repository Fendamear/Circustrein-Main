using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {

        private List<Animal> Animals = new List<Animal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TBname.Text != "") AddAnimalToList();
        }

        private void BtDeleteAnimal_Click(object sender, EventArgs e)
        {
            
        }

        private void AddAnimalToList()
        {
            
            //Bepalen van grootte Animal
            Animal.Sizes size = RBsmall.Checked ? Animal.Sizes.Small : RBmedium.Checked ? Animal.Sizes.Medium : Animal.Sizes.Big;

            //Aanmaken van een nieuwe listViewItem voor display dieren
            ListViewItem lvi = new ListViewItem { Text = TBname.Text };

            //aanmaken subitems voor display van dier en toevoegen aan animal list
            lvi.SubItems.Add(size.ToString());
            bool carnivore = CBCarn.Checked;
            lvi.SubItems.Add(carnivore.ToString());

            //nieuw object van dier aanmaken voor de list dieren die uiteindelijk naar de logica laag gaat
            Animal newAnimal = new Animal(Text = TBname.Text, carnivore, size);
            Animals.Add(newAnimal);

            //dier toevoegen aan de listviewItem
            lvAnimals.Items.Add(lvi);
            TBname.Clear();
        }

        //Zorgt ervoor dat de list van animals gestuurd gaat worden naar de logica laag en verdeeld worden onder wagons
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           // LvTrain.Items.Clear();
           // LvTrain.Columns.Clear();

            Train train = new Train();

            IEnumerable<Wagon> Wagons =  train.CalculateTrain(Animals);

            //int wagonnummer = 1;

            //LbTrain.Items.Add("Locomotief");
            //foreach (var wagon in Wagons)
            //{
            //    LbTrain.Items.Add("Wagon" + wagonnummer);
            //    foreach()
            //}

            Console.WriteLine(Wagons);

            //List<Wagon> Wagons = train.TestFunctie(Animals);
            //AddtoListView(Wagons);

            //Console.WriteLine(Wagons);
            //train.TestFunctie(Animals);
        }


    }
}

