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
            DateTime dataiczas = DateTime.Now;
            string tresc = InputEditor.Text;
            string sciezka = Path.Combine(FileSystem.Current.AppDataDirectory, "Dziennik.txt");
            string text =  tresc + dataiczas.ToString("yyyy-MM-dd HH:mm:ss");
            File.ReadAllText(sciezka, text);
            
            if(File.Exists(sciezka))
            {
                Label1.Text = $"Zapisano: {text}";
            }
            else
            {
                Label1.Text = $"Plik nie istnieje";
            }
        }
    }
}
