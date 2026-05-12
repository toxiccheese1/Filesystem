namespace zapis
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public string sciezkaDanych = FileSystem.Current.AppDataDirectory;
        
        private void Zapisz(object sender, EventArgs e)
        {
            string sciezka = Path.Combine(FileSystem.Current.AppDataDirectory, "dane.txt");
            string text = InputEntry.Text;
            File.WriteAllText(sciezka, text);
        }

        private void Odczyt(object sender, EventArgs e)
        {
            string sciezka = Path.Combine(FileSystem.Current.AppDataDirectory, "dane.txt");
            if(File.Exists(sciezka))
            {
                string tresc = File.ReadAllText(sciezka);
                Label1.Text = tresc;
            }
            else
            {
                Label1.Text = "Plik nie istnieje.";
            }
        }
    }
}
