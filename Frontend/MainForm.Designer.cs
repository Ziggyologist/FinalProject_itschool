using System.Windows.Forms;

namespace Frontend
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddActivityBtn = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 49);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 361);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // AddActivityBtn
            // 
            AddActivityBtn.Anchor = AnchorStyles.Top;
            AddActivityBtn.BackColor = Color.LightGreen;
            AddActivityBtn.Font = new Font("Arial", 20F, FontStyle.Bold);
            AddActivityBtn.ForeColor = Color.WhiteSmoke;
            AddActivityBtn.Location = new Point(342, 0);
            AddActivityBtn.Margin = new Padding(0);
            AddActivityBtn.MaximumSize = new Size(100, 100);
            AddActivityBtn.MinimumSize = new Size(50, 50);
            AddActivityBtn.Name = "AddActivityBtn";
            AddActivityBtn.RightToLeft = RightToLeft.Yes;
            AddActivityBtn.Size = new Size(100, 50);
            AddActivityBtn.TabIndex = 5;
            AddActivityBtn.Text = "+";
            AddActivityBtn.TextAlign = ContentAlignment.MiddleCenter;
            AddActivityBtn.Cursor = Cursors.Hand;
            AddActivityBtn.Click += AddActivityBtn_Click;

            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(308, 9);
            label2.Name = "label2";
            label2.Size = new Size(165, 22);
            label2.TabIndex = 0;
            label2.Text = "HABIT TRACKER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(362, 16);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "HABITS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(AddActivityBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Organizeaza-ti ziua cu un cerb!";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        //private Panel CenteringPanel;
        private Label AddActivityBtn;
        private Label label1;
        private Label label2;
    }

}
