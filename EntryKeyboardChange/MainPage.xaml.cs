namespace EntryKeyboardChange
{
    public partial class MainPage : ContentPage
    {      
        public MainPage()
        {
            InitializeComponent();
        }
     
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(e.NewTextValue == "12345")
            {
                entry.Text = "123";
            }          
        }
    }

}
