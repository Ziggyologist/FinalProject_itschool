using System;
using System.Drawing;
using System.Windows.Forms;
using Backend;

namespace Frontend
{
    public class TriangleButton : Button
    {
        public bool isGray = true;  // Track the current state of the color (Gray or Green)

        public TriangleButton()
        {
            // Set the button's default style (optional)
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Transparent;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Create a Graphics object for custom drawing
            Graphics g = pevent.Graphics;

            // Define the points for the triangle
            Point[] trianglePoints = new Point[]
            {
                new Point(this.Width / 2, 0), // Top of the triangle
                new Point(0, this.Height),    // Bottom left
                new Point(this.Width, this.Height) // Bottom right
            };

            // Choose the color based on the current state (Gray or Green)
            using (Brush brush = new SolidBrush(isGray ? Color.LightGray : Color.Green))
            {
                g.FillPolygon(brush, trianglePoints);
            }

            // Optionally, you can draw the button text (centered) inside the triangle
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

            // Toggle the color between gray and green
            isGray = !isGray;


            // Redraw the button after the color change
            this.Invalidate();  // Invalidate forces the button to be repainted

            MessageBox.Show("The activity was marked as DONE!");
        }

    }
}
