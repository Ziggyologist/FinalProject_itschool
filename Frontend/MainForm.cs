using Backend;

namespace Frontend
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            PopulateUI();
        }

        private void PopulateUI()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Helper.ActivityList)
            {
                ActivityCard card = new ActivityCard(item);
                card.Dock = DockStyle.Top;
                card.Height = 100;
                card.DoClick += OnContactCardClick; card.Padding = new Padding(32, 0, 0, 0);
                flowLayoutPanel1.Controls.Add(card);
            }
            flowLayoutPanel1.Controls[0].Dock = DockStyle.None;
            UpdateFlowControlsWidth();
        }

        private void UpdateFlowControlsWidth()
        {
            if (flowLayoutPanel1.Controls.Count == 0) return;

            flowLayoutPanel1.Controls[0].Width = flowLayoutPanel1.Width - 32;
        }

        private void OnContactCardClick(object? sender, EventArgs e)
        {
            AddActivityForm actForm = new((sender as ActivityCard).Activity);

            if (actForm.ShowDialog() == DialogResult.OK)
            {
                PopulateUI();
            }
        }

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);

        //    UpdateFlowControlsWidth();
        //}

        private void AddActivityBtn_Click(object sender, EventArgs e)
        {
            AddActivityForm actForm = new AddActivityForm();
            actForm.ShowDialog();
            if (actForm.DialogResult != DialogResult.OK) return;

            Helper.AddNewActivity(actForm.ActivityName, actForm.Description, actForm.Priority);
            PopulateUI();
        }
    }
}
