using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomJokeWebsite
{
    public partial class FrmFunnyJokes : Form
    {
        public FrmFunnyJokes()
        {
            InitializeComponent();
            PopCats();
        }

        private async void BtnRandJoke_ClickAsync(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            TxtJoke.Text = joke.JokeText;
        }

        private async void PopCats()
        {
            IEnumerable<string> catagoryList = await ChuckNorrisClient.GetCategories();
            foreach (var cata in catagoryList)
            {
                CmbxCategories.Items.Add(cata);
            }
        }
    }
}
