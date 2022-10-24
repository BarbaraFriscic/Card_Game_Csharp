using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Exercise_24_10_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PodijeliKarte(spilKarata, racunaloSpil, igracSpil); //dijelim karte prije prvog poteza
        }
        Random shuffle = new Random();
        int[] spilKarata = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };
        int[] racunaloSpil = new int[26];
        int[] igracSpil = new int[26];
        

        void PodijeliKarte(int[] spil, int[] racunaloSpil, int[] igracSpil) //špil karata ima 52 karte, od njega 26 dijelim racunalu,a ostalih 26 igracu
        {
            var shuffledcards = spil.OrderBy(a => Guid.NewGuid()).ToList(); // miješaju se cijeli brojevi iz gore definiranog niza spilKarata

            for (int i = 0; i < 26; i++)            //prvih 26 elemenata se dodjeljuje Računalu, a posljednjih 26 Igraču
            {
                racunaloSpil[i] = shuffledcards[i];
            }
            for (int i = 0; i < 26; i++)
            {
                igracSpil[i] = shuffledcards[i + 26];
            }


        }

        int brojacPoteza = 0; //ujedno mi služi i za odabiranje karte u metodi OdaberiKartu
        int rezultatRacunalo = 0;
        int rezultatIgrac = 0;

        private void btnPlay_Click(object sender, EventArgs e)

        {
            string odabranaKartaRacunalo;
            string odabranaKartaIgrac;
            OdaberiKartu(racunaloSpil, brojacPoteza, out odabranaKartaRacunalo); //
            OdaberiKartu(igracSpil, brojacPoteza, out odabranaKartaIgrac);
            int jacinaKarteRacunalo;
            int jacinaKarteIgrac;
            OdrediJacinuKarte(odabranaKartaRacunalo, out jacinaKarteRacunalo);
            OdrediJacinuKarte(odabranaKartaIgrac, out jacinaKarteIgrac);

            if (jacinaKarteRacunalo == jacinaKarteIgrac)
            {
                rezultatRacunalo++;
                rezultatIgrac++;
            }
            else if (jacinaKarteRacunalo > jacinaKarteIgrac)
            {
                rezultatRacunalo += 2;

            }
            else
                rezultatIgrac += 2;
            

            lblGameRez.Text += String.Format("\nDijeljenje #{0}: Računalo: {1}    ---    Igrač: {2}"      , brojacPoteza +1, odabranaKartaRacunalo, odabranaKartaIgrac);
           lblGameRez.Text += String.Format("           Rezultat:     Računalo {0}  Igrač {1}", rezultatRacunalo, rezultatIgrac);

            brojacPoteza++;
            if (brojacPoteza == 26)
            {
                if(rezultatRacunalo > rezultatIgrac)
                
                    MessageBox.Show("Igra je završena" + "\n" + "Pobjednik je Računalo");
                
                else if (rezultatRacunalo < rezultatIgrac)
                    MessageBox.Show("Igra je završena" + "\n" + "Pobjednik je Igrač");
                else
                    MessageBox.Show("Igra je završena" + "\n" + "Neriješeno");
            }
        }

        

        void OdaberiKartu(int[] spilKarata, int brojacPoteza, out string odabranaKarta)
        {
             odabranaKarta = "";
            

            if (spilKarata[brojacPoteza] == 1 || spilKarata[brojacPoteza] == 1 + 13 || spilKarata[brojacPoteza] == 1 + 2 * 13 || spilKarata[brojacPoteza] == 1 + 3 * 13)
                odabranaKarta += "As";
            else if (spilKarata[brojacPoteza] == 2 || spilKarata[brojacPoteza] == 3 || spilKarata[brojacPoteza] == 4 || spilKarata[brojacPoteza] == 5 || spilKarata[brojacPoteza] == 6 || spilKarata[brojacPoteza] == 7 || spilKarata[brojacPoteza] == 8 || spilKarata[brojacPoteza] == 9 || spilKarata[brojacPoteza] == 10)
                odabranaKarta += spilKarata[brojacPoteza].ToString();
            else if (spilKarata[brojacPoteza] == 2 + 13 || spilKarata[brojacPoteza] == 3 + 13 || spilKarata[brojacPoteza] == 4 + 13 || spilKarata[brojacPoteza] == 5 + 13 || spilKarata[brojacPoteza] == 6 + 13 || spilKarata[brojacPoteza] == 7 + 13 || spilKarata[brojacPoteza] == 8 + 13 || spilKarata[brojacPoteza] == 9 + 13 || spilKarata[brojacPoteza] == 10 + 13)
                odabranaKarta += Convert.ToString(spilKarata[brojacPoteza] - 13);
            else if (spilKarata[brojacPoteza] == 2 + 2 * 13 || spilKarata[brojacPoteza] == 3 + 2 * 13 || spilKarata[brojacPoteza] == 4 + 2 * 13 || spilKarata[brojacPoteza] == 5 + 2 * 13 || spilKarata[brojacPoteza] == 6 + 2 * 13 || spilKarata[brojacPoteza] == 7 + 2 * 13 || spilKarata[brojacPoteza] == 8 + 2 * 13 || spilKarata[brojacPoteza] == 9 + 2 * 13 || spilKarata[brojacPoteza] == 10 + 2 * 13)
                odabranaKarta += Convert.ToString(spilKarata[brojacPoteza] - 2 * 13);
            else if (spilKarata[brojacPoteza] == 2 + 3 * 13 || spilKarata[brojacPoteza] == 3 + 3 * 13 || spilKarata[brojacPoteza] == 4 + 3 * 13 || spilKarata[brojacPoteza] == 5 + 3 * 13 || spilKarata[brojacPoteza] == 6 + 3 * 13 || spilKarata[brojacPoteza] == 7 + 3 * 13 || spilKarata[brojacPoteza] == 8 + 3 * 13 || spilKarata[brojacPoteza] == 9 + 3 * 13 || spilKarata[brojacPoteza] == 10 + 3 * 13)
                odabranaKarta += Convert.ToString(spilKarata[brojacPoteza] - 3 * 13);
            else if (spilKarata[brojacPoteza] == 11 || spilKarata[brojacPoteza] == 11 + 13 || spilKarata[brojacPoteza] == 11 + 2 * 13 || spilKarata[brojacPoteza] == 11 + 3 * 13)
                odabranaKarta += "Dečko";
            else if (spilKarata[brojacPoteza] == 12 || spilKarata[brojacPoteza] == 12 + 13 || spilKarata[brojacPoteza] == 12 + 2 * 13 || spilKarata[brojacPoteza] == 12 + 3 * 13)
                odabranaKarta += "Dama";
            else if (spilKarata[brojacPoteza] == 13 || spilKarata[brojacPoteza] == 13 + 13 || spilKarata[brojacPoteza] == 13 + 2 * 13 || spilKarata[brojacPoteza] == 13 + 3 * 13)
                odabranaKarta += "Kralj";
            else
                odabranaKarta = String.Empty; 

            if (spilKarata[brojacPoteza] == 1 || spilKarata[brojacPoteza] == 2 || spilKarata[brojacPoteza] == 3 || spilKarata[brojacPoteza] == 4 || spilKarata[brojacPoteza] == 5 || spilKarata[brojacPoteza] == 6 || spilKarata[brojacPoteza] == 7 || spilKarata[brojacPoteza] == 8 || spilKarata[brojacPoteza] == 9 || spilKarata[brojacPoteza] == 10 || spilKarata[brojacPoteza] == 11 || spilKarata[brojacPoteza] == 12 || spilKarata[brojacPoteza] == 13)
            odabranaKarta += " tref";
            else if (spilKarata[brojacPoteza] == 1 + 13 || spilKarata[brojacPoteza] == 2 + 13 || spilKarata[brojacPoteza] == 3 + 13 || spilKarata[brojacPoteza] == 4 + 13 || spilKarata[brojacPoteza] == 5 + 13 || spilKarata[brojacPoteza] == 6 + 13 || spilKarata[brojacPoteza] == 7 + 13 || spilKarata[brojacPoteza] == 8 + 13 || spilKarata[brojacPoteza] == 9 + 13 || spilKarata[brojacPoteza] == 10 + 13 || spilKarata[brojacPoteza] == 11 + 13 || spilKarata[brojacPoteza] == 12 + 13 || spilKarata[brojacPoteza] == 13 + 13)
                odabranaKarta += " karo";
            else if (spilKarata[brojacPoteza] == 1 + 2 * 13 || spilKarata[brojacPoteza] == 2 + 2 * 13 || spilKarata[brojacPoteza] == 3 + 2 * 13 || spilKarata[brojacPoteza] == 4 + 2 * 13 || spilKarata[brojacPoteza] == 5 + 2 * 13 || spilKarata[brojacPoteza] == 6 + 2 * 13 || spilKarata[brojacPoteza] == 7 + 2 * 13 || spilKarata[brojacPoteza] == 8 + 2 * 13 || spilKarata[brojacPoteza] == 9 + 2 * 13 || spilKarata[brojacPoteza] == 10 + 2 * 13 || spilKarata[brojacPoteza] == 11 + 2 * 13 || spilKarata[brojacPoteza] == 12 + 2 * 13 || spilKarata[brojacPoteza] == 13 + 2 * 13)
                odabranaKarta += " srce";
            else if (spilKarata[brojacPoteza] == 1 + 3 * 13 || spilKarata[brojacPoteza] == 2 + 3 * 13 || spilKarata[brojacPoteza] == 3 + 3 * 13 || spilKarata[brojacPoteza] == 4 + 3 * 13 || spilKarata[brojacPoteza] == 5 + 3 * 13 || spilKarata[brojacPoteza] == 6 + 3 * 13 || spilKarata[brojacPoteza] == 7 + 3 * 13 || spilKarata[brojacPoteza] == 8 + 3 * 13 || spilKarata[brojacPoteza] == 9 + 3 * 13 || spilKarata[brojacPoteza] == 10 + 3 * 13 || spilKarata[brojacPoteza] == 11 + 3 * 13 || spilKarata[brojacPoteza] == 12 + 3 * 13 || spilKarata[brojacPoteza] == 13 + 3 * 13)
                odabranaKarta += " pik";
            else
                odabranaKarta = String.Empty;

        }
        void OdrediJacinuKarte(string odabranaKarta, out int jacinaKarte)
        {
            jacinaKarte = 0;
            if (odabranaKarta == "As tref" || odabranaKarta == "As karo" || odabranaKarta == "As srce" || odabranaKarta == "As pik")
                jacinaKarte = 14;
            else if (odabranaKarta == "2 tref" || odabranaKarta == "2 karo" || odabranaKarta == "2 srce" || odabranaKarta == "2 pik")
                jacinaKarte = 2;
            else if (odabranaKarta == "3 tref" || odabranaKarta == "3 karo" || odabranaKarta == "3 srce" || odabranaKarta == "3 pik")
                jacinaKarte = 3;
            else if (odabranaKarta == "4 tref" || odabranaKarta == "4 karo" || odabranaKarta == "4 srce" || odabranaKarta == "4 pik")
                jacinaKarte = 4;
            else if (odabranaKarta == "5 tref" || odabranaKarta == "5 karo" || odabranaKarta == "5 srce" || odabranaKarta == "5 pik")
                jacinaKarte = 5;
            else if (odabranaKarta == "6 tref" || odabranaKarta == "6 karo" || odabranaKarta == "6 srce" || odabranaKarta == "6 pik")
                jacinaKarte = 6;
            else if (odabranaKarta == "7 tref" || odabranaKarta == "7 karo" || odabranaKarta == "7 srce" || odabranaKarta == "7 pik")
                jacinaKarte = 7;
            else if (odabranaKarta == "8 tref" || odabranaKarta == "8 karo" || odabranaKarta == "8 srce" || odabranaKarta == "8 pik")
                jacinaKarte = 8;
            else if (odabranaKarta == "9 tref" || odabranaKarta == "9 karo" || odabranaKarta == "9 srce" || odabranaKarta == "9 pik")
                jacinaKarte = 9;
            else if (odabranaKarta == "10 tref" || odabranaKarta == "10 karo" || odabranaKarta == "10 srce" || odabranaKarta == "10 pik")
                jacinaKarte = 10;
            else if (odabranaKarta == "Dečko tref" || odabranaKarta == "Dečko karo" || odabranaKarta == "Dečko srce" || odabranaKarta == "Dečko pik")
                jacinaKarte = 11;
            else if (odabranaKarta == "Dama tref" || odabranaKarta == "Dama karo" || odabranaKarta == "Dama srce" || odabranaKarta == "Dama pik")
                jacinaKarte = 12;
            
            else if (odabranaKarta == "Kralj tref" || odabranaKarta == "Kralj karo" || odabranaKarta == "Kralj srce" || odabranaKarta == "Kralj pik")
                jacinaKarte = 13;
            else
                jacinaKarte = 0;

        }
         
    }
}
