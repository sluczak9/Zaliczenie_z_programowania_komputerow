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

namespace Sebastian_Luczak
{
    public partial class Form1 : Form
    {
        double rabat = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

            double cena = (double)numericUpDownKwota.Value;
            double ilosc = (double)numericUpDownIlosc.Value;
            string nazwa = textBox1.Text;

            bool brakNazwy = string.IsNullOrWhiteSpace(nazwa);
            if (brakNazwy)
            {
                MessageBox.Show("Pole nazwa nie może być puste!");
            }
            else
            {
                if (cena > 0 && ilosc>0)
                {
                    if (radioButtonTak.Checked)
                    {
                        double rabat = liczRabaty(cena);
                        double razem = ilosc * (cena-rabat);
                        rabat = rabat * ilosc;
                        listBox1.Items.Add(nazwa + ", " + razem.ToString("F2").Replace(',', '.') + ", " + ilosc+ ", " + rabat.ToString("F2").Replace(',', '.') + ", " + "tak");
                    }
                    else if (radioButtonNie.Checked)
                    {
                        double razem = ilosc * cena;
                        double rabat = 0;
                        listBox1.Items.Add(nazwa + ", " + razem.ToString("F2").Replace(',', '.') + ", " + ilosc + ", " + rabat  + ", " + "nie");
                    }
                    else
                    {
                        MessageBox.Show("Musisz zaznaczyć rabat");
                    }
                }
                else
                {
                    MessageBox.Show("Cena oraz ilosc nie mogą być puste");
                }
                
            }
        }

        private double liczRabaty(double cena)
        {
            rabat = cena * 0.10;
            return rabat;
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            int pozycja = listBox1.SelectedIndex;
            if (pozycja > -1 && listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(pozycja);
            }
        }

        

        private void buttonNaliczRabat_Click(object sender, EventArgs e)
        {

            double sumaRabatow = naliczonyRabat();
            MessageBox.Show("Suma rabatów wynosi " + sumaRabatow);

        }

        private double naliczonyRabat()
        {
            double sumaRabatow = 0;

            int i = 0;
            foreach(object item in listBox1.Items)
            {

                string[] linijka = ((string)listBox1.Items[i]).Split(',');
                string rab = linijka[3];
                double rabaty = Double.Parse(rab.Replace(".",","));
                sumaRabatow = sumaRabatow + rabaty;
                i++;
            }
            return sumaRabatow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(najdrozszaPozycja());
        }

        private string najdrozszaPozycja()
        {
            string nazwa = "";
            string komunikat;
            double max = 0;
            int pozycja = -1;
            int i = 0;
            foreach(object item in listBox1.Items)
            {
                string[] linijka = ((string)listBox1.Items[i]).Split(',');
                string najd = linijka[1];
                
                double najdrozsza = Double.Parse(najd.Replace(".", ","));
                if (najdrozsza>max)
                {
                    max = najdrozsza;
                    nazwa = linijka[0];
                    
                }
                i++;
                pozycja++;
            }
            komunikat = pozycja + ", " + nazwa + ", " + max ;
            return komunikat;
        }

        private double CalkowitaKwotaBezRabatu()
        {
            double kwota = 0;
            int i = 0;
            foreach(object item in listBox1.Items)
            {
                string[] linijka = ((string)listBox1.Items[i]).Split(',');
                string cen = linijka[1];
                string rab = linijka[3];
                double cena = Double.Parse(cen.Replace(".", ","));
                double rabat = Double.Parse(rab.Replace(".", ","));
                kwota = kwota + cena + rabat;

                i++;
            }
            return kwota;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double kwota = CalkowitaKwotaBezRabatu();
            MessageBox.Show("całkowita kwota wynosi " + kwota);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double kwotaPoOdjeciuRabatu = CaklkowitaKwotaPoOdjeciuRabatu();
            MessageBox.Show("Całkowita kwota po odjęciu rabatu wynosi " + kwotaPoOdjeciuRabatu);
        }

        private double CaklkowitaKwotaPoOdjeciuRabatu()
        {
            double calkKwotPoOdjRabatu = 0;
            double sumaRab = naliczonyRabat();
            double calkowitaKwotaBezRab = CalkowitaKwotaBezRabatu();
            calkKwotPoOdjRabatu = calkowitaKwotaBezRab - sumaRab;

            return calkKwotPoOdjRabatu;
        }

        private string podsumowanie()
        {
            string nazwa;
            string komunikat = "";
            double cena;
            double ilosc;
            double sumaRabatow = naliczonyRabat();
            double kwota = CalkowitaKwotaBezRabatu();
            double kwotaPoOdjeciuRabatu = CaklkowitaKwotaPoOdjeciuRabatu();
            int i = 0;
            int j = 1;
            foreach (object item in listBox1.Items)
            {
                string[] linijka = ((string)listBox1.Items[i]).Split(',');
                nazwa = linijka[0];
                string cen = linijka[1];
                string ilo = linijka[2];
                cena = Double.Parse(cen.Replace(".", ","));
                ilosc = Double.Parse(ilo);

                komunikat = komunikat + j + ", " + nazwa + ", " + cena + ", " + ilosc + Environment.NewLine;
                i++;
                j++;
            }
            komunikat=komunikat + Environment.NewLine + Environment.NewLine + "Podsumowanie"  + Environment.NewLine + "Suma rabatów: " + sumaRabatow + ", "
                + Environment.NewLine + "Całkowita kwota zamówienia przed rabatem: " + kwota + Environment.NewLine
                + "Całkowita kwota po odjęciu rabatu: " + kwotaPoOdjeciuRabatu;
            return komunikat;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string komunikat = podsumowanie();
            SaveFileDialog plik = new SaveFileDialog();
            DialogResult czyWybranoPlik = plik.ShowDialog();
            if (czyWybranoPlik == DialogResult.OK)
            {
                string nazwaPliku = plik.FileName;
                nazwaPliku = nazwaPliku + ".txt";
                string zapisz = komunikat;
                File.WriteAllText(nazwaPliku, komunikat);
            }
        }
    }
}
