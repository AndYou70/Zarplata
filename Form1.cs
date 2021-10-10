using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarplata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Naryad_TextChanged(object sender, EventArgs e)
        {
            string NumNaryad;
            NumNaryad = NevNaryad.Text;
        }

        private void Otdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NumOtdel;
            NumOtdel = NevOtdel.Text;
        }

        private void Ispolnitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NevLNIspolnitel;
            NevLNIspolnitel = NevIspolnitel.Text;
        }

        private void Korector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NevLNKorector;
            NevLNKorector = NevKorector.Text;
        }

        private void KategorieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NevZnahKategorieList;
            NevZnahKategorieList = NevKategorieList.Text;
        }

        private void Koefizent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NevNumKoefizent;
            NevNumKoefizent = NevKoeficient.Text;
        }

        private void FileSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Файл данных (*.INF)|*.INF";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.ShowDialog();
            NevDirFile.Text = OpenFileDialog1.FileName; //Путь к файлу *.inf            
        }

        private void PanNaryad_TextChanged(object sender, EventArgs e)
        {
            string NumPanNaryad;
            NumPanNaryad = PanNaryad.Text;
        }

        private void PanOtdel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NumPanOtdel;
            NumPanOtdel = PanOtdel.Text;
        }

        private void PanIspolnitel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PanLNIspolnitel;
            PanLNIspolnitel = PanIspolnitel.Text;
        }

        private void PanKorector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PanLNKorector;
            PanLNKorector = PanKorector.Text;
        }

        private void PanKategorieList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PanZnahKategorieList;
            PanZnahKategorieList = PanKategorieList.Text;
        }

        private void PanKoeficient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NumPanKoeficient;
            NumPanKoeficient = PanKoeficient.Text;
        }

        private void PanFileSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.Filter = "Файл данных (*.txf)|*.txf";
            OpenFileDialog1.FileName = "";
            OpenFileDialog1.ShowDialog();
            PanDirFile.Text = OpenFileDialog1.FileName; //Путь к файлу *.txf
        }
    }
}
