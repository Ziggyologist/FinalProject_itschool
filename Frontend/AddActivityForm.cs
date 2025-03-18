using Backend;

namespace Frontend
{
    public partial class AddActivityForm : Form
    {
        internal string ActivityName = string.Empty;
        internal string Description = string.Empty;
        internal int Priority = 0;
        //internal bool Done = false;
        private readonly Activity? _targetActivity = null;

        public AddActivityForm()
        {
            InitializeComponent();
            Text = "Create New Activity";
            TitleLabel.Text = Text;
        }

        public AddActivityForm(Activity activity) : this()
        {
            _targetActivity = activity;
            textBox1.Text = _targetActivity.Name;
            richTextBox1.Text = _targetActivity.Description;
            numericUpDown1.Value = _targetActivity.Priority;
            //checkBox1.Checked = _targetActivity.Done;

            Text = "Edit Activity Form";
            TitleLabel.Text = Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                return;
            }

            ActivityName = textBox1.Text;
            Description = richTextBox1.Text;
            Priority = (Int32)numericUpDown1.Value;
            //Done = checkBox1.Checked;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
