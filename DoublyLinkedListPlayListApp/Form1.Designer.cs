namespace DoublyLinkedListPlayListApp
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
            Previous = new Button();
            Next = new Button();
            DeleteCurrent = new Button();
            AddTrack = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            Shuffle = new Button();
            SuspendLayout();
            // 
            // Previous
            // 
            Previous.Location = new Point(12, 287);
            Previous.Name = "Previous";
            Previous.Size = new Size(112, 34);
            Previous.TabIndex = 0;
            Previous.Text = "Previous";
            Previous.UseVisualStyleBackColor = true;
            Previous.Click += Previous_Click;
            // 
            // Next
            // 
            Next.Location = new Point(397, 287);
            Next.Name = "Next";
            Next.Size = new Size(112, 34);
            Next.TabIndex = 1;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // DeleteCurrent
            // 
            DeleteCurrent.Location = new Point(205, 287);
            DeleteCurrent.Name = "DeleteCurrent";
            DeleteCurrent.Size = new Size(112, 34);
            DeleteCurrent.TabIndex = 2;
            DeleteCurrent.Text = "Delete Current";
            DeleteCurrent.UseVisualStyleBackColor = true;
            DeleteCurrent.Click += DeleteCurrent_Click;
            // 
            // AddTrack
            // 
            AddTrack.Location = new Point(397, 29);
            AddTrack.Name = "AddTrack";
            AddTrack.Size = new Size(112, 34);
            AddTrack.TabIndex = 3;
            AddTrack.Text = "Add Track";
            AddTrack.UseVisualStyleBackColor = true;
            AddTrack.Click += AddTrack_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 31);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(529, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 404);
            listBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 160);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 6;
            // 
            // Shuffle
            // 
            Shuffle.Location = new Point(205, 360);
            Shuffle.Name = "Shuffle";
            Shuffle.Size = new Size(112, 34);
            Shuffle.TabIndex = 7;
            Shuffle.Text = "Shuffle";
            Shuffle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Shuffle);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(AddTrack);
            Controls.Add(DeleteCurrent);
            Controls.Add(Next);
            Controls.Add(Previous);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Previous;
        private Button Next;
        private Button DeleteCurrent;
        private Button AddTrack;
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private Button Shuffle;
    }
}
