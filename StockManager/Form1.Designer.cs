namespace StockManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtQuantity = new TextBox();
            button1 = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            button2 = new Button();
            listView1 = new ListView();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            label7 = new Label();
            txtNewQuantity = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 0;
            label1.Text = "CREATE ITEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 1;
            label2.Text = "Item name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 23);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 3;
            label3.Text = "Item quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(12, 107);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(182, 23);
            txtQuantity.TabIndex = 4;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(119, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 5;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(273, 9);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 6;
            label4.Text = "SEARCH ITEMS";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(273, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(398, 23);
            txtSearch.TabIndex = 8;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(677, 42);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 9;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 10F);
            listView1.Location = new Point(273, 71);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.Size = new Size(515, 49);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(273, 136);
            label5.Name = "label5";
            label5.Size = new Size(154, 28);
            label5.TabIndex = 11;
            label5.Text = "MANAGE ITEMS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(273, 164);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 12;
            label6.Text = "Item id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(273, 186);
            txtId.Name = "txtId";
            txtId.Size = new Size(143, 23);
            txtId.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(433, 164);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 14;
            label7.Text = "New quantity:";
            // 
            // txtNewQuantity
            // 
            txtNewQuantity.Location = new Point(433, 186);
            txtNewQuantity.Name = "txtNewQuantity";
            txtNewQuantity.Size = new Size(238, 23);
            txtNewQuantity.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(677, 186);
            button3.Name = "button3";
            button3.Size = new Size(111, 23);
            button3.TabIndex = 16;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 221);
            Controls.Add(button3);
            Controls.Add(txtNewQuantity);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtQuantity);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "StockManager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtQuantity;
        private Button button1;
        private Label label4;
        private TextBox txtSearch;
        private Button button2;
        private ListView listView1;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private Label label7;
        private TextBox txtNewQuantity;
        private Button button3;
    }
}
