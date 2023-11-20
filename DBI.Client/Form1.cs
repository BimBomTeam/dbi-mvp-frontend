using System;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Xml.Linq;

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
                openFileDialog.Filter = "Dog Photo (*.jpg)|*.jpg"; // Ogranicza wybur do plik�w *jpg
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathPhoto = openFileDialog.FileName; // Otworzy okno dialogowe do wyszukania pliku

                    txtPathPhoto.Text = pathPhoto; // Odczytanie �cie�ki do zdi�cia 

                    Image imageDog = Image.FromFile(pathPhoto); //Przygotowanie obrazu do wy�wietlenia w oknie

                    phoDogPicture.Image = imageDog; // Wy�wietlenie obrazu w oknie u�ytkownika

                    byte[] imageArray = File.ReadAllBytes(pathPhoto); // Odczytanie pliku do tablicy bajt�w
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray); // Konwersja do Base64



                    using (var httpClient = new HttpClient())
                    {
                        var url = "https://localhost:7219/api/DBI/identify";

                        var values = new Dictionary<string, string>
                        {
                            { "base64", base64ImageRepresentation }
                        };

                        string json = JsonConvert.SerializeObject(values);

                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        var response = await httpClient.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();
                            txtAnswerDBI.Text = ("Request is: " + responseContent);
                        }
                        else
                        {
                            txtAnswerDBI.Text = ("Error: " + response.StatusCode);
                        }
                    }
                }
            }
        }

    }


}
