namespace VetoresND
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form FormRandom = new FormRandom();
            FormRandom.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
