
namespace dotnet_winforms_examples
{
    partial class NavigationBarExampleUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            view3Button = new Button();
            view2Button = new Button();
            view1Button = new Button();
            homeButton = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Cursor = Cursors.VSplit;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = SystemColors.ControlDark;
            splitContainer1.Panel1.Controls.Add(view3Button);
            splitContainer1.Panel1.Controls.Add(view2Button);
            splitContainer1.Panel1.Controls.Add(view1Button);
            splitContainer1.Panel1.Controls.Add(homeButton);
            splitContainer1.Panel1.Cursor = Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Cursor = Cursors.Arrow;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(743, 565);
            splitContainer1.SplitterDistance = 246;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // view3Button
            // 
            view3Button.BackColor = SystemColors.ControlLight;
            view3Button.Dock = DockStyle.Top;
            view3Button.FlatAppearance.BorderSize = 0;
            view3Button.FlatStyle = FlatStyle.Flat;
            view3Button.Location = new Point(0, 279);
            view3Button.Margin = new Padding(0);
            view3Button.Name = "view3Button";
            view3Button.Size = new Size(246, 105);
            view3Button.TabIndex = 3;
            view3Button.Text = "Update";
            view3Button.UseVisualStyleBackColor = false;
            view3Button.Click += Button_Click;
            // 
            // view2Button
            // 
            view2Button.BackColor = SystemColors.ControlLight;
            view2Button.Dock = DockStyle.Top;
            view2Button.FlatAppearance.BorderSize = 0;
            view2Button.FlatStyle = FlatStyle.Flat;
            view2Button.Location = new Point(0, 186);
            view2Button.Margin = new Padding(0);
            view2Button.Name = "view2Button";
            view2Button.Size = new Size(246, 93);
            view2Button.TabIndex = 2;
            view2Button.Text = "Read";
            view2Button.UseVisualStyleBackColor = false;
            view2Button.Click += Button_Click;
            // 
            // view1Button
            // 
            view1Button.BackColor = SystemColors.ControlLight;
            view1Button.Dock = DockStyle.Top;
            view1Button.FlatAppearance.BorderSize = 0;
            view1Button.FlatStyle = FlatStyle.Flat;
            view1Button.Location = new Point(0, 93);
            view1Button.Margin = new Padding(0);
            view1Button.Name = "view1Button";
            view1Button.Size = new Size(246, 93);
            view1Button.TabIndex = 1;
            view1Button.Text = "Create";
            view1Button.UseVisualStyleBackColor = false;
            view1Button.Click += Button_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = SystemColors.ControlLight;
            homeButton.Dock = DockStyle.Top;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Location = new Point(0, 0);
            homeButton.Margin = new Padding(0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(246, 93);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += Button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(450, 0);
            button1.Name = "button1";
            button1.Size = new Size(42, 31);
            button1.TabIndex = 1;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(198, 280);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Home Screen";
            // 
            // NavigationBarExampleUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NavigationBarExampleUserControl";
            Size = new Size(743, 565);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button view3Button;
        private Button view2Button;
        private Button view1Button;
        private Button homeButton;
        private Label label1;
        private Button button1;
    }
}
