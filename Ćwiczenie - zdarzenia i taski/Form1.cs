using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ćwiczenie___zdarzenia_i_taski
{
    //TODO: praca zespołowa - założyć repozytorium na github-ie

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOblicz_Click(object sender, EventArgs e)
        {
            Obliczenia obliczenia = new Obliczenia();
            //TODO: zaimplementować obsługę zdarzeń "rozpoczecieObliczen", "progresObliczen", "zakonczenieObliczen"
            //TODO: rozpoczecieObliczen ustawia progressBar na 0%
            //TODO: zakonczenieObliczen ustawia progressBar na 100%
            //TODO: progresObliczen ustawia progressBar na % taki jak wartość zmiennej wynik w atrybucie zdarzenia

            //TODO: wykonać metodę Obliczaj() asynchronicznie (async - await) 
            int wynik = obliczenia.Obliczaj();

            MessageBox.Show($"wynik: {wynik}");
        }
    }
}
