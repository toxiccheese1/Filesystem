namespace zad2
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
            string sciezka = Path.Combine(FileSystem.Current.AppDataDirectory, "Dziennik.txt");
            string text = $"{InputEditor.Text} {System.DateTime.Now.ToString("dd.MM.yyyy HH.mm")}\n\n";
            File.AppendAllText(sciezka, text);
            
            if(File.Exists(sciezka))
            {
                Label1.Text = File.ReadAllText(sciezka);
            }
            else
            {
                Label1.Text = $"Plik nie istnieje";
            }
        }

        private void Usun(object sender, EventArgs e)
        {
            string sciezka = Path.Combine(FileSystem.Current.AppDataDirectory, "Dziennik.txt");
            if (File.Exists(sciezka))
            {
                File.Delete(sciezka);
                DisplayAlertAsync("Dziennik został usunięty", Title, "OK");
                Label1.Text = $"";
            }
            else
            {
                DisplayAlertAsync("Dziennik nie istnieje", Title, "OK");
            }
        }
    }
}
