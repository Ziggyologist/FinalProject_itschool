using System.Windows.Forms;

namespace Frontend
{
    partial class AddActivityForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLabel = new Label();
            DescriptionLabel = new Label();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            SubmitButton = new Button();
            CancelButton = new Button();
            panel1 = new Panel();
            TitleLabel = new Label();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(0, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(100, 23);
            NameLabel.TabIndex = 0;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Location = new Point(0, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(100, 23);
            DescriptionLabel.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(0, 0);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 0;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(0, 0);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(100, 23);
            DescriptionTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(0, 0);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(0, 0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(100, 23);
            TitleLabel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 81);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 78);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 110);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(210, 108);
            richTextBox1.MaxLength = 210;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(277, 96);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 220);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Priority";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(209, 218);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(-1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 59);
            panel3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 17);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 0;
            label5.Text = "Add a new activity";
            // 
            // button1
            // 
            button1.Location = new Point(395, 305);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(476, 305);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddActivityForm
            // 
            ClientSize = new Size(551, 387);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddActivityForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button SubmitButton;
        private Button CancelButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label TitleLabel;
        private Panel panel2;


        #endregion

        private Label NameLabel;
        private Label DescriptionLabel;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Panel panel3;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}