using Backend;
using System.Text;
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
            Activity = activity;
            UpdateUI();

            // Attach the MouseDown event for right-click detection on label1
            label1.MouseDown += label1_MouseDown;  // Attach MouseDown event for label1
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
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                StringBuilder activitiesList = new StringBuilder();

                foreach (var activity in Helper.ActivityList)
                {
                    activitiesList.AppendLine(activity.Name);
                }
                string message = $"These are the current activities in the list:\n{activitiesList.ToString()}\n\n" +
                         $"Are you sure you want to delete \"{Activity.Name}\"? If yes, press OK. Otherwise, press Cancel.";
                DialogResult result = MessageBox.Show(message, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    // Delete the activity
                    Helper.DeleteActivity(Activity.Name);

                    // Refresh the UI to reflect the updated list
                    var mainForm = this.FindForm() as MainForm;
                    if (mainForm != null)
                    {
                        mainForm.PopulateUI(); 
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}
