using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace JaksaMDrzavnaMatura
{
    public partial class Form1 : Form
    {

        //public string izabranPrvi = comboBox3.SelectedItem.ToString();

        public string izabraniTip;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TipDrzavneMature_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TreciPredmet_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetujFormu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = Liste.sveSkole;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }



        public void Form1_Load(object sender, EventArgs e)
        {
            OsveziIzborTemplatea();
            OsveziSveListe();
            comboBox1.DataSource = Liste.sveSkole;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.DataSource = drugiPredmet;
            comboBox3.DataSource = Liste.prviPredmet;
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox5.DataSource = Liste.tipDM;
            comboBox4.DataSource = Liste.jezik;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;



            //public string izabraniTip = comboBox5.SelectedItem.ToString();
            if (comboBox5.SelectedIndex > -1) {
                izabraniTip = comboBox5.SelectedItem.ToString();
            }

            if (izabraniTip == "Opsti")
            {

                comboBox6.DataSource = Liste.opstiPredmeti;

            }
            else if (izabraniTip == "Strucni")
            {
                comboBox6.DataSource = Liste.strucniPredmeti;
            }
            else if (izabraniTip == "Umetnicki")
            {

            }
        }




        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.DataSource = Liste.prviPredmet;
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;


            /*if (comboBox3.SelectedIndex == 0)
            {

                comboBox6.DataSource = opstiPredmeti;


            }
            
            if (comboBox3.SelectedIndex == 0 && comboBox6.SelectedIndex == 7)
            {
                MessageBox.Show("Ne možete izabrati isti predmet dva puta!");

                // KLJUČNA LINIJA: Poništava izbor u trećem polju
                comboBox6.SelectedIndex = -1;
            }

            */

        }






        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<string> drugiPredmet = new List<string>
        {
            "Matematika"
        };

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {

                comboBox6.DataSource = Liste.opstiPredmeti;

            }
            else if (comboBox5.SelectedIndex == 1)
            {
                comboBox6.DataSource = Liste.strucniPredmeti;
            }
            else if (comboBox5.SelectedIndex == 2)
            {
                comboBox6.DataSource = Liste.umetnicka;
            }
        }







        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0 && comboBox6.SelectedIndex == 7)
            {
                MessageBox.Show("Ne možete izabrati Srpski jezik i knjizevnos kao treci predmet zato sto ste ga izabrali za prvi!");


                comboBox6.SelectedIndex = -1;
            }
        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            string putanja = "template_mature.csv";

            // Provera da li je uneto ime template-a
            if (string.IsNullOrWhiteSpace(imetp.Text))
            {
                MessageBox.Show("Molimo vas unesite naziv template-a u polje 'imetp'!");
                return;
            }

            // Izvlačenje podataka iz kontrola u promenljive
            string imeTemplatea = imetp.Text;
            string skola = comboBox1.Text;
            string tipdm = comboBox5.Text;
            string jezika = comboBox4.Text;
            string p1 = comboBox3.Text;
            string p2 = comboBox2.Text;
            string p3 = comboBox6.Text;

            try
            {
                // Ako fajl ne postoji, pravi ga sa zaglavljem
                if (!File.Exists(putanja))
                {
                    string zaglavlje = "Naziv;Skola;Tip;Jezik;P1;P2;P3";
                    File.WriteAllText(putanja, zaglavlje + Environment.NewLine, Encoding.UTF8);
                }

                // Formiranje reda koristeći tvoje promenljive
                string red = $"{imeTemplatea};{skola};{tipdm};{jezika};{p1};{p2};{p3}";

                // Upisivanje u fajl (using automatski zatvara StreamWriter)
                using (StreamWriter sw = new StreamWriter(putanja, true, Encoding.UTF8))
                {
                    sw.WriteLine(red);
                }

                MessageBox.Show("Template '" + imeTemplatea + "' uspešno sačuvan!");

                imetp.Clear(); // Briše tekst iz polja nakon uspešnog čuvanja
                OsveziIzborTemplatea(); // Odmah puni comboBox7 novim podacima
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri čuvanju: " + ex.Message);
            }

            OsveziIzborTemplatea();
        }


        private void OsveziIzborTemplatea()
        {
            string putanja = "template_mature.csv";

            if (File.Exists(putanja))
            {
                try
                {
                    comboBox7.Items.Clear();
                    string[] redovi = File.ReadAllLines(putanja);

                    // i=1 preskače zaglavlje
                    for (int i = 1; i < redovi.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(redovi[i]))
                        {
                            string[] delovi = redovi[i].Split(';');
                            if (delovi.Length > 0)
                            {
                                // Dodajemo samo prvu kolonu (Naziv template-a) u comboBox7
                                comboBox7.Items.Add(delovi[0]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri učitavanju template-a: " + ex.Message);
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox7.SelectedItem == null) return;

            string izabraniNaziv = comboBox7.SelectedItem.ToString();
            string putanja = "template_mature.csv";

            if (File.Exists(putanja))
            {
                try
                {
                    string[] redovi = File.ReadAllLines(putanja);

                    // 2. Tražimo red koji počinje sa tim nazivom
                    foreach (string red in redovi.Skip(1)) // Preskačemo zaglavlje
                    {
                        string[] delovi = red.Split(';');

                        if (delovi.Length >= 7 && delovi[0] == izabraniNaziv)
                        {
                            // 3. Dodela vrednosti kontrolama
                            // PAŽNJA: Redosled mora biti isti kao pri čuvanju (Naziv;Skola;Tip;Jezik;P1;P2;P3)

                            comboBox1.Text = delovi[1]; // Skola
                            comboBox5.Text = delovi[2]; // Tip
                            comboBox4.Text = delovi[3]; // Jezik
                            comboBox3.Text = delovi[4]; // P1
                            comboBox2.Text = delovi[5]; // P2
                            comboBox6.Text = delovi[6]; // P3

                            // Opciono: Pošto promena Tipa (comboBox5) treba da promeni izvor za P3 (comboBox6),
                            // pozivamo ručno tu logiku ako se nije sama aktivirala

                            break; // Našli smo šta nam treba, izlazimo iz petlje
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri učitavanju podataka: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Putanja do fajla gde idu sve prijave (ne template)
            string matura = "matura.csv";

            // 2. Provera da li su osnovna polja popunjena (primer za Ime i Prezime)
            // Zameni 'txtIme' i 'txtPrezime' stvarnim imenima tvojih TextBox-ova
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Morate uneti ime i prezime učenika!");
                return;
            }

            try
            {
                // 3. Ako fajl ne postoji, napravi zaglavlje
                if (!File.Exists(matura))
                {
                    string zaglavlje = "Ime;Prezime;JMBG;Skola;TipDM;Jezik;PrviPredmet;DrugiPredmet;TreciPredmet";
                    File.WriteAllText(matura, zaglavlje + Environment.NewLine, Encoding.UTF8);
                }

                // 4. Prikupljanje podataka iz formi
                string red = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                    textBox1.Text,
                    textBox3.Text,
                    textBox2.Text, // Dodaj TextBox za JMBG ako ga nemaš
                    comboBox1.Text, // Skola
                    comboBox5.Text, // Tip DM
                    comboBox4.Text, // Jezik
                    comboBox3.Text, // P1
                    comboBox2.Text, // P2
                    comboBox6.Text  // P3
                );

                // 5. Upis u fajl (Append mode)
                using (StreamWriter sw = new StreamWriter(matura, true, Encoding.UTF8))
                {
                    sw.WriteLine(red);
                }

                MessageBox.Show("Prijava za učenika " + textBox1.Text + " je uspešno sačuvana!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }


            OsveziSveListe();




        }



        public void ResetujFormu()
        {
            // Čisti sve TextBox-ove
            imetp.Clear(); // Polje za naziv template-a
            textBox1.Clear(); // Zameni sa tvojim imenom za Ime
            textBox2.Clear(); // Zameni sa tvojim imenom za Prezime
            textBox3.Clear(); // Zameni sa tvojim imenom za Odeljenje

            // Vraća sve ComboBox-ove na "ništa nije izabrano"
            comboBox1.SelectedIndex = -1; // Skola
            comboBox2.SelectedIndex = -1; // Drugi predmet
            comboBox3.SelectedIndex = -1; // Prvi predmet
            comboBox4.SelectedIndex = -1; // Jezik
            comboBox5.SelectedIndex = -1; // Tip DM
            comboBox6.SelectedIndex = -1; // Treci predmet
            comboBox7.SelectedIndex = -1; // Izaberi template

            // Opciono: Postavi fokus na prvo polje (Ime) da odmah možeš da kucaš
            textBox1.Focus();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Provera da li je išta izabrano
            if (comboBox8.SelectedItem == null) return;

            string izabraniText = comboBox8.SelectedItem.ToString();
            string putanjaPrijave = "matura.csv";

            if (!File.Exists(putanjaPrijave)) return;

            try
            {
                string[] redovi = File.ReadAllLines(putanjaPrijave, Encoding.UTF8);

                foreach (string red in redovi.Skip(1)) // Preskačemo zaglavlje
                {
                    if (string.IsNullOrWhiteSpace(red)) continue;

                    string[] d = red.Split(';');

                    // PROVERA: Moramo napraviti ISTI format kao u OsveziSveListe()
                    // Proveri da li su d[0], d[1] i d[2] kod tebe Ime, Prezime i Odeljenje
                    if (d.Length >= 3)
                    {
                        string formatZaProveru = $"{d[0].Trim()} {d[1].Trim()} ({d[2].Trim()})";

                        if (formatZaProveru == izabraniText)
                        {
                            // 2. POPUNJAVANJE FORME
                            // TextBox-ovi
                            textBox1.Text = d[0].Trim();
                            textBox3.Text = d[1].Trim();
                            textBox2.Text = d[2].Trim();

                            // ComboBox-ovi (Pazi na redosled kolona u tvom CSV fajlu!)
                            // Ako ti se npr. škola nalazi u 4. koloni, to je d[3]
                            if (d.Length >= 9)
                            {
                                comboBox1.Text = d[3]; // Skola
                                comboBox5.Text = d[4]; // Tip DM
                                comboBox4.Text = d[5]; // Jezik
                                comboBox3.Text = d[6]; // Prvi predmet
                                comboBox2.Text = d[7]; // Drugi predmet (Matematika)
                                comboBox6.Text = d[8]; // Treci predmet
                            }

                            break; // Našli smo učenika, prekidamo petlju
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju: " + ex.Message);
            }
        }


        public void OsveziSveListe()
        {
            try
            {
                // 1. Putanja mora biti ista kao ona u kojoj čuvaš (button1)
                string putanjaPrijave = "matura.csv";

                // 2. Proveri da li se tvoj novi ComboBox zove comboBox8 (vidi u Properties)
                comboBox8.Items.Clear();

                if (File.Exists(putanjaPrijave))
                {
                    string[] redoviP = File.ReadAllLines(putanjaPrijave, Encoding.UTF8);

                    // i=1 preskačemo zaglavlje (Ime;Prezime...)
                    for (int i = 1; i < redoviP.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(redoviP[i]))
                        {
                            string[] delovi = redoviP[i].Split(';');

                            // Proveravamo da li red ima bar 3 dela (Ime, Prezime, Odeljenje)
                            if (delovi.Length >= 3)
                            {
                                // Pravimo format koji će se videti u listi
                                string infoUcenik = $"{delovi[0]} {delovi[1]} ({delovi[2]})";
                                comboBox8.Items.Add(infoUcenik);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri osvežavanju liste učenika: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 1. Provera da li je učenik uopšte izabran za izmenu
            if (comboBox8.SelectedItem == null)
            {
                MessageBox.Show("Molimo vas prvo izaberite učenika iz liste za izmenu!");
                return;
            }

            string izabraniText = comboBox8.SelectedItem.ToString();
            string putanjaPrijave = "matura.csv";

            if (!File.Exists(putanjaPrijave)) return;

            try
            {
                // 2. Učitavamo sve redove iz fajla
                List<string> sviRedovi = File.ReadAllLines(putanjaPrijave, Encoding.UTF8).ToList();
                bool nadjen = false;

                // 3. Prolazimo kroz redove (preskačemo zaglavlje i=1)
                for (int i = 1; i < sviRedovi.Count; i++)
                {
                    string[] d = sviRedovi[i].Split(';');
                    if (d.Length >= 3)
                    {
                        // Formiramo isti ključ po kom smo ga tražili u comboBox8
                        string formatZaProveru = $"{d[0].Trim()} {d[1].Trim()} ({d[2].Trim()})";

                        if (formatZaProveru == izabraniText)
                        {
                            // 4. Formiramo NOVI red sa podacima koji su trenutno u poljima na formi
                            string azuriranRed = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}",
                                textBox1.Text, // Ime
                                textBox3.Text, // Prezime
                                textBox2.Text, // Odeljenje/JMBG
                                comboBox1.Text, // Skola
                                comboBox5.Text, // Tip DM
                                comboBox4.Text, // Jezik
                                comboBox3.Text, // P1
                                comboBox2.Text, // P2
                                comboBox6.Text  // P3
                            );

                            // Zamenjujemo stari red novim
                            sviRedovi[i] = azuriranRed;
                            nadjen = true;
                            break;
                        }
                    }
                }

                if (nadjen)
                {
                    // 5. Upisujemo sve nazad u fajl (File.WriteAllLines prebriše ceo fajl)
                    File.WriteAllLines(putanjaPrijave, sviRedovi, Encoding.UTF8);

                    MessageBox.Show("Podaci o učeniku su uspešno izmenjeni!");

                    // 6. Osvežavamo listu u ComboBox8 jer su se podaci možda promenili
                    OsveziSveListe();
                }
                else
                {
                    MessageBox.Show("Učenik nije pronađen u bazi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri izmeni: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
    }
    


    
            




