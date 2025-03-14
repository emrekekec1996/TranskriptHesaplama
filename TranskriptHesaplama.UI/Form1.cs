using TranskriptHesaplama.UI.Data;

namespace TranskriptHesaplama.UI
{
    public partial class Form1 : Form
    {

        Ders secilenDers;
        List<Ders> secilenDersler = new List<Ders>()
        {
           new Ders{ Ad="Matematik", Kredi=10, Kod="MAT101" },
            new Ders{ Ad="Türkçe", Kredi=1, Kod="TÜR101" },
             new Ders{ Ad="Ýnkýlap Tarihi", Kredi=2, Kod="TAR101" },
        };


        public void NotlariEkle()
        {

            cmbAraSinav.Items.Add("Seçiniz");
            cmbFinal.Items.Add("Seçiniz");
            for (int i = 0; i <= 100; i++)
            {
                cmbAraSinav.Items.Add(i);
                cmbFinal.Items.Add(i);
            }
            //Program açýldýðýnda 
            cmbAraSinav.SelectedIndex = cmbFinal.SelectedIndex = 0;
        }
        public void DersleriGetir()
        {
            dgvDersler.DataSource = null;
            dgvDersler.DataSource = secilenDersler;

            if (dgvDersler.Columns["Ad"] == null)
            {
                dgvDersler.Columns.Add("Ad", "Ad");
            }
            if (dgvDersler.Columns["Kod"] == null)
            {
                dgvDersler.Columns.Add("Kod", "Kod");
            }
            if (dgvDersler.Columns["Kredi"] == null)
            {
                dgvDersler.Columns.Add("Kredi", "Kredi");
            }
            if (dgvDersler.Columns["Vize"] == null)
            {
                dgvDersler.Columns.Add("Vize", "Vize");
            }
            if (dgvDersler.Columns["Final"] == null)
            {
                dgvDersler.Columns.Add("Final", "Final");
            }
            if (dgvDersler.Columns["HarfNotu"] == null)
            {
                dgvDersler.Columns.Add("HarfNotu", "HarfNotu");
            }
        }

        public Form1()
        {
            InitializeComponent();
            DersleriGetir();
            NotlariEkle();

        }

        public void HarfNotunuAta(Ders ders)
        {
            double sonNot = ders.Vize * 0.4 + ders.Final * 0.6;
            switch (sonNot)
            {
                case <= 100 and >= 90:
                    ders.HarfNotu = Enums.HarfNotu.AA;
                    break;
                case < 90 and >= 80:
                    ders.HarfNotu = Enums.HarfNotu.BA;
                    break;
                case < 80 and >= 70:
                    ders.HarfNotu = Enums.HarfNotu.BB;
                    break;
                case < 70 and >= 60:
                    ders.HarfNotu = Enums.HarfNotu.CB;
                    break;
                case < 60 and >= 55:
                    ders.HarfNotu = Enums.HarfNotu.CC;
                    break;
                case < 55 and >= 50:
                    ders.HarfNotu = Enums.HarfNotu.DC;
                    break;
                case < 50 and > 45:
                    ders.HarfNotu = Enums.HarfNotu.DD;
                    break;
                default:
                    ders.HarfNotu = Enums.HarfNotu.FF;
                    break;
            }
        }

        //Griddeki her bir satýra týklandýðýnda çalýþacak olan metot. Dolayýsýyla hangi derse týklanýrsa o ders seçilmiþ olacak ve ona göre not girilmiþ olacak. Seçilen dersi önce tanýmlamak gerekir.
        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Satýrlarda hücreye basýnca çökmesin diye grid'in selectionmode'unu FullRowSelect yaparýz.
            lblSecilen.Text = "SEÇÝLEN DERS:";
            secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            lblSecilen.Text += " " + secilenDers.Kod + " " + secilenDers.Ad + " " + secilenDers.Kredi;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {


            //Sonnot = Vize X 0.4 + Final X 0.6
            //Eðer Sonnot [90,100] aralýðýnda ise AA, ......

            //GNO = (Ders1Kredisi X HarfNotuKredisi + Ders2Kredisi X HarfNotuKredisi + .......) / ToplamKredi


            //butona týklandýðý zaman çalýþacak olan metot.
            double toplam = 0;
            uint toplamKredi = 0;
            foreach (var ders in secilenDersler)
            {


                toplam += (((int)ders.HarfNotu) / 10.0) * ders.Kredi;
                toplamKredi += (ders.Kredi);
            }
            toplam /= toplamKredi;
            lblGNO.Text = "GNO: " + toplam;

        }

        private void cmbAraSinav_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDersiDuzenle_Click(object sender, EventArgs e)
        {
            if (secilenDers != null)
            {
                if (cmbAraSinav.SelectedIndex == 0 || cmbFinal.SelectedIndex == 0)
                {
                    MessageBox.Show("Lütfen arasýnav/finali seçiniz");
                    return;
                }
                secilenDers.Vize = Convert.ToUInt32(cmbAraSinav.SelectedItem);
                secilenDers.Final = Convert.ToUInt32(cmbFinal.SelectedItem);
                HarfNotunuAta(secilenDers);
                DersleriGetir();
            }
            else
                MessageBox.Show("Lütfen ders seçiniz");

        }
    }
}
