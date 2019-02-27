using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example02
{
    public partial class Form1 : Form
    {
        public Pokemon pokemon;
        public int UserStarDust;
        public int UserCandy;
        public Form1()
        {
            InitializeComponent();
            UserStarDust = 1000000;
            UserCandy = 1324;
            pokemon = new Pokemon()
            {
                Name = "妙蛙種子",
                CurrentHp = 50,
                Hp = 60,
                Weight = 6.94f,
                Types = new string[] { "草", "毒" },
                Height = 0.67f,
                PowerUpCandy = 27,
                PowerUpStardust = 3000,
                EvolveCandy = 100
            };
            NameLabel.Text = pokemon.Name;
            HpLabel.Text = pokemon.CurrentHp.ToString() + "/" + pokemon.Hp + "HP";
            HeightLabel.Text = pokemon.Height.ToString();
            TypesLabel.Text = pokemon.Types[0] + "/" + pokemon.Types[1];
            WeightLabel.Text = pokemon.Weight.ToString();
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserStardystLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PowerUpCandyLabel.Text = pokemon.PowerUpCandy.ToString();
            PowerUpStardustLabel.Text = pokemon.PowerUpStardust.ToString();
            UserStardystLabel.Text = UserStarDust.ToString();
            UserCandyLabel.Text = UserCandy.ToString();
            
            UserCandy -= pokemon.PowerUpCandy;
            UserStarDust -= pokemon.PowerUpStardust;
            pokemon.Hp += 10;
            pokemon.CurrentHp += 10;
            HpLabel.Text = pokemon.CurrentHp.ToString() + "/" + pokemon.Hp + "HP";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            UserCandyLabel.Text = UserCandy.ToString();
            EvolveCandyLabel.Text = pokemon.EvolveCandy.ToString();
            UserCandy -= pokemon.EvolveCandy;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


    }
}
