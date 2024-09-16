namespace _4M03EntryZdarzenia
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void onEntry1Completed(object sender, EventArgs e)
        {
            lblE1.Text = entE1.Text;
        }
        private void onEntry2TextChanged(object sender, EventArgs e)
        {
            lblE2.Text = entE2.Text;
        }


    }

}
