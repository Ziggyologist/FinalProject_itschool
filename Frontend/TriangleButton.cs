using System;
using System.Drawing;
using System.Windows.Forms;
using Backend;

namespace Frontend
{
    public class TriangleButton : Button
    {
        public bool isGray { get; set; }
        public Activity AssociatedActivity { get; set; }
        ToolTip markAsDoneToolTip = new ToolTip();


        public TriangleButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Transparent;
            this.FlatAppearance.BorderSize = 0;
        }

        public void InitializeState()
        {
            isGray = !AssociatedActivity.Done;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;

            Point[] trianglePoints = new Point[]
            {
                new Point(this.Width / 2, 0),
                new Point(0, this.Height),
                new Point(this.Width, this.Height)
            };
            Color greenColor = ColorTranslator.FromHtml("#70a089");
            Color grayColor = ColorTranslator.FromHtml("#c2c2c2");
            using (Brush brush = new SolidBrush(isGray ? grayColor : greenColor))
            {
                g.FillPolygon(brush, trianglePoints);
            }
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(this.Text, this.Font, Brushes.Black, new RectangleF(0, 0, this.Width, this.Height), stringFormat);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            isGray = !isGray;

            if (AssociatedActivity != null)
            {
                AssociatedActivity.MarkAsDone(!isGray);
            }
            this.Invalidate();
        string doneStatus = isGray ? "NOT DONE" : "DONE";
        MessageBox.Show($"Activity \"{AssociatedActivity?.Name}\" was marked as {doneStatus}!");

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            markAsDoneToolTip.SetToolTip(this, "Click here to mark an activity as done.");
        }
    }
}