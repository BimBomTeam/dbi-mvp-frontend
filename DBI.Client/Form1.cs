namespace DBI.Client
{
    public partial class mainForm : Form
    {

        private string pathPhoto = "";
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Dog Photo (*.png)|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathPhoto = openFileDialog.FileName;
                    txtPathPhoto.Text = pathPhoto;
                }
            }
        }
    }
}