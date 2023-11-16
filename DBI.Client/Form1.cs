using System;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DBI.Client
{
    public partial class mainForm : Form
    {

        private string pathPhoto = "";
        public mainForm()
        {
            InitializeComponent();
        }

        private async void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Dog Photo (*.jpg)|*.jpg"; // Ogranicza wybur do plików *jpg
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathPhoto = openFileDialog.FileName; // Otworzy okno dialogowe do wyszukania pliku

                    txtPathPhoto.Text = pathPhoto; // Odczytanie œcie¿ki do zdiêcia 

                    Image imageDog = Image.FromFile(pathPhoto); //Przygotowanie obrazu do wyœwietlenia w oknie

                    phoDogPicture.Image = imageDog; // Wyœwietlenie obrazu w oknie u¿ytkownika

                    byte[] imageArray = File.ReadAllBytes(pathPhoto); // Odczytanie pliku do tablicy bajtów
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray); // Konwersja do Base64


                    /*
                    using (var httpClient = new HttpClient())
                    {
                        var url = "https://adres-twojego-serwera.com/upload"; // Adres URL serwera, gdzie przesy³asz obraz
                        var content = new StringContent(base64ImageRepresentation, Encoding.UTF8, "application/base64");

                        var response = await httpClient.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();
                            txtAnswerDBI.Text = ("OdpowiedŸ z serwera: " + responseContent);
                            // Tutaj mo¿na przetworzyæ odpowiedŸ serwera lub wyœwietliæ w programie.
                        }
                        else
                        {
                            txtAnswerDBI.Text = ("Wyst¹pi³ b³¹d podczas przesy³ania obrazu: " + response.StatusCode);
                        }
                    }
                    */

                }
            }
        }

    }


}
