namespace Clinic_Queue_Management_System_Activity
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            lblQueueNumber = new Label();
            lblPatientTypeOutput = new Label();
            lblPriority = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 18);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 0;
            label1.Text = "Barangay Apokon Clinic Queue System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 54);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 85);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 115);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Reason:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(213, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 148);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 7;
            label5.Text = "Patient Type:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Regular", "Senior", "Pregnant", "Emergency" });
            comboBox1.Location = new Point(260, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(260, 188);
            button1.Name = "button1";
            button1.Size = new Size(110, 24);
            button1.TabIndex = 9;
            button1.Text = "ADD TO QUEUE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(376, 188);
            button2.Name = "button2";
            button2.Size = new Size(97, 24);
            button2.TabIndex = 10;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblQueueNumber
            // 
            lblQueueNumber.AutoSize = true;
            lblQueueNumber.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQueueNumber.Location = new Point(190, 230);
            lblQueueNumber.Name = "lblQueueNumber";
            lblQueueNumber.Size = new Size(44, 32);
            lblQueueNumber.TabIndex = 13;
            lblQueueNumber.Text = "---";
            // 
            // lblPatientTypeOutput
            // 
            lblPatientTypeOutput.AutoSize = true;
            lblPatientTypeOutput.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatientTypeOutput.Location = new Point(190, 282);
            lblPatientTypeOutput.Name = "lblPatientTypeOutput";
            lblPatientTypeOutput.Size = new Size(44, 32);
            lblPatientTypeOutput.TabIndex = 14;
            lblPatientTypeOutput.Text = "---";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(190, 346);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(44, 32);
            lblPriority.TabIndex = 15;
            lblPriority.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 235);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 16;
            label6.Text = "Queue Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 296);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 17;
            label7.Text = "Patient Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(136, 360);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 18;
            label8.Text = "Priority:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblPriority);
            Controls.Add(lblPatientTypeOutput);
            Controls.Add(lblQueueNumber);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Clinic Queue Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label lblQueueNumber;
        private Label lblPatientTypeOutput;
        private Label lblPriority;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}