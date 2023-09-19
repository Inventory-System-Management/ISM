namespace ISM.WebUI
{
    partial class Orders
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            OrderId = new DataGridViewTextBoxColumn();
            OrderName = new DataGridViewTextBoxColumn();
            OrderAmount = new DataGridViewTextBoxColumn();
            MaterialInOrder = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            vScrollBar1 = new VScrollBar();
            textBox1 = new TextBox();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(79, 378);
            button1.Name = "button1";
            button1.Size = new Size(124, 46);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(209, 380);
            button2.Name = "button2";
            button2.Size = new Size(124, 44);
            button2.TabIndex = 1;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(339, 380);
            button3.Name = "button3";
            button3.Size = new Size(124, 44);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(636, 382);
            button4.Name = "button4";
            button4.Size = new Size(124, 44);
            button4.TabIndex = 3;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderId, OrderName, OrderAmount, MaterialInOrder, OrderDate });
            dataGridView1.Location = new Point(79, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(681, 329);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderId
            // 
            OrderId.HeaderText = "Id";
            OrderId.MinimumWidth = 6;
            OrderId.Name = "OrderId";
            // 
            // OrderName
            // 
            OrderName.HeaderText = "Name";
            OrderName.MinimumWidth = 6;
            OrderName.Name = "OrderName";
            // 
            // OrderAmount
            // 
            OrderAmount.HeaderText = "Amount";
            OrderAmount.MinimumWidth = 6;
            OrderAmount.Name = "OrderAmount";
            // 
            // MaterialInOrder
            // 
            MaterialInOrder.HeaderText = "Material";
            MaterialInOrder.MinimumWidth = 6;
            MaterialInOrder.Name = "MaterialInOrder";
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "OrderDate";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 47);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, -2);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 6;
            label2.Text = "Orders";
            label2.Click += label2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(762, 0);
            button5.Name = "button5";
            button5.Size = new Size(38, 28);
            button5.TabIndex = 7;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(762, 47);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 329);
            vScrollBar1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(412, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 18;
            // 
            // button7
            // 
            button7.Location = new Point(565, 10);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 19;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(vScrollBar1);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Button button5;
        private VScrollBar vScrollBar1;
        private TextBox textBox1;
        private Button button7;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn OrderName;
        private DataGridViewTextBoxColumn OrderAmount;
        private DataGridViewTextBoxColumn MaterialInOrder;
        private DataGridViewTextBoxColumn OrderDate;
    }
}