namespace kiosk
{
    public partial class firstScreen : Form
    {
        screen.mainScreen mainscreen = new screen.mainScreen();

        public bool takeout = false;

        public firstScreen()
        {
            InitializeComponent();
        }
        private void appCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void takeinBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mainscreen);
        }

        private void takeoutBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mainscreen);
        }

        private void simpleTakeInBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mainscreen);
        }

        private void simpleTakeOutBtn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mainscreen);
        }
    }
}