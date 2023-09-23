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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            vScrollBar1 = new VScrollBar();
            textBox1 = new TextBox();
            button7 = new Button();
            txbDate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txbTotalAmount = new TextBox();
            label5 = new Label();
            txbUserId = new TextBox();
            label6 = new Label();
            txbQuantityOrdered = new TextBox();
            label7 = new Label();
            txbStorageId = new TextBox();
            pictureBox1 = new PictureBox();
            txbId = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(69, 284);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(108, 34);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(183, 285);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(108, 33);
            button2.TabIndex = 1;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(297, 285);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(108, 33);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(556, 286);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(108, 33);
            button4.TabIndex = 3;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 35);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(664, 197);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1, -2);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 6;
            label2.Text = "Orders";
            label2.Click += label2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Location = new Point(679, -2);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(33, 21);
            button5.TabIndex = 7;
            button5.Text = "x";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(667, 38);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 247);
            vScrollBar1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 9);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaption;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(494, 8);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(82, 22);
            button7.TabIndex = 19;
            button7.Text = "Search";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // txbDate
            // 
            txbDate.Location = new Point(25, 262);
            txbDate.Margin = new Padding(3, 2, 3, 2);
            txbDate.Name = "txbDate";
            txbDate.Size = new Size(129, 23);
            txbDate.TabIndex = 20;
            txbDate.KeyDown += txbDate_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(25, 244);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 21;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(159, 244);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 23;
            label4.Text = "TotalAmount";
            // 
            // txbTotalAmount
            // 
            txbTotalAmount.Location = new Point(159, 262);
            txbTotalAmount.Margin = new Padding(3, 2, 3, 2);
            txbTotalAmount.Name = "txbTotalAmount";
            txbTotalAmount.Size = new Size(129, 23);
            txbTotalAmount.TabIndex = 22;
            txbTotalAmount.KeyDown += txbTotalAmount_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(293, 244);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 25;
            label5.Text = "UserId";
            // 
            // txbUserId
            // 
            txbUserId.Location = new Point(293, 262);
            txbUserId.Margin = new Padding(3, 2, 3, 2);
            txbUserId.Name = "txbUserId";
            txbUserId.Size = new Size(129, 23);
            txbUserId.TabIndex = 24;
            txbUserId.KeyDown += txbUserId_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(427, 244);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 27;
            label6.Text = "QuantityOrdered";
            // 
            // txbQuantityOrdered
            // 
            txbQuantityOrdered.Location = new Point(427, 262);
            txbQuantityOrdered.Margin = new Padding(3, 2, 3, 2);
            txbQuantityOrdered.Name = "txbQuantityOrdered";
            txbQuantityOrdered.Size = new Size(129, 23);
            txbQuantityOrdered.TabIndex = 26;
            txbQuantityOrdered.KeyDown += txbQuantityOrdered_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(561, 244);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 29;
            label7.Text = "StorageId";
            // 
            // txbStorageId
            // 
            txbStorageId.Location = new Point(561, 262);
            txbStorageId.Margin = new Padding(3, 2, 3, 2);
            txbStorageId.Name = "txbStorageId";
            txbStorageId.Size = new Size(129, 23);
            txbStorageId.TabIndex = 28;
            txbStorageId.KeyDown += txbStorageId_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(332, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // txbId
            // 
            txbId.Location = new Point(435, 292);
            txbId.Margin = new Padding(3, 2, 3, 2);
            txbId.Name = "txbId";
            txbId.Size = new Size(92, 23);
            txbId.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(410, 296);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 32;
            label8.Text = "Id";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(307, 12);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 33;
            label9.Text = "Id";
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 333);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txbId);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(txbStorageId);
            Controls.Add(label6);
            Controls.Add(txbQuantityOrdered);
            Controls.Add(label5);
            Controls.Add(txbUserId);
            Controls.Add(label4);
            Controls.Add(txbTotalAmount);
            Controls.Add(label3);
            Controls.Add(txbDate);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Orders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txbDate;
        private Label label3;
        private Label label4;
        private TextBox txbTotalAmount;
        private Label label5;
        private TextBox txbUserId;
        private Label label6;
        private TextBox txbQuantityOrdered;
        private Label label7;
        private TextBox txbStorageId;
        private PictureBox pictureBox1;
        private TextBox txbId;
        private Label label8;
        private Label label9;
    }
}