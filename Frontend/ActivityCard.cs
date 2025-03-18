using Backend;
using System.Xml;

namespace Frontend
{
    public partial class ActivityCard : UserControl
    {
        public readonly Activity Activity;

        public event EventHandler DoClick;
        public ActivityCard()
        {
            InitializeComponent();
        }

        public ActivityCard(Activity activity)
        {
            InitializeComponent();

            //label1.Click += (s, e) => OnClick(e);

            Activity = activity;

            UpdateUI();
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            DoClick?.Invoke(this, e);
        }
        private void OnDoClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void UpdateUI()
        {
            if (Activity == null)
            {
                throw new ArgumentNullException(nameof(Activity));
            }

            label1.Text = Activity.Name;
            label3.Text = Activity.Description;
            label2.Text = Activity.Priority.ToString();

        }

        private void triangleButton1_Click(object sender, EventArgs e)
        {
            if (sender is TriangleButton button)
            {
                Helper.SetDone(Activity, !button.isGray);
            }
        }

        private void triangleButton1_MouseEnter(object sender, EventArgs e)
        {
            //triangleButton1.ForeColor = Color.LightGreen;
            triangleButton1.Cursor = Cursors.Hand;
        }
    }
}
