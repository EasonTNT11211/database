

namespace WinFormsApp1
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        private void Formmain_Load(object sender, EventArgs e)
        {

        }

        private void 類別管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();

            
        }

        private void 資料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.Show();
        }
    }
}
