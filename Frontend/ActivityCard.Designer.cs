namespace Frontend
{
    partial class ActivityCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            triangleButton1 = new TriangleButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(triangleButton1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 151);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(124, 45);
            label3.MaximumSize = new Size(400, 50);
            label3.Name = "label3";
            label3.Size = new Size(400, 45);
            label3.TabIndex = 3;
            label3.Text = "description";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 30);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "priority";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "name";
            // 
            // triangleButton1
            // 
            triangleButton1.BackColor = Color.Transparent;
            triangleButton1.FlatAppearance.BorderSize = 0;
            triangleButton1.FlatStyle = FlatStyle.Flat;
            triangleButton1.Location = new Point(11, 3);
            triangleButton1.Name = "triangleButton1";
            triangleButton1.Size = new Size(107, 89);
            triangleButton1.TabIndex = 0;
            triangleButton1.UseVisualStyleBackColor = false;
            triangleButton1.Click += triangleButton1_Click;
            // 
            // ActivityCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ActivityCard";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TriangleButton triangleButton1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}