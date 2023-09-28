namespace gptbac1
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
            components = new System.ComponentModel.Container();
            btnsolve = new Button();
            lbresult = new Label();
            textA = new TextBox();
            textB = new TextBox();
            btnclear = new Button();
            btnexit = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnsolve
            // 
            btnsolve.Location = new Point(158, 189);
            btnsolve.Name = "btnsolve";
            btnsolve.Size = new Size(51, 29);
            btnsolve.TabIndex = 0;
            btnsolve.Text = "giải ";
            btnsolve.UseVisualStyleBackColor = true;
            btnsolve.Click += btnsolve_Click;
            // 
            // lbresult
            // 
            lbresult.AutoSize = true;
            lbresult.Location = new Point(5, 140);
            lbresult.Name = "lbresult";
            lbresult.Size = new Size(152, 20);
            lbresult.TabIndex = 1;
            lbresult.Text = "nghiệm phương trình:";
            lbresult.Click += label1_Click;
            // 
            // textA
            // 
            textA.Location = new Point(158, 55);
            textA.Name = "textA";
            textA.Size = new Size(224, 27);
            textA.TabIndex = 2;
            textA.TextChanged += textA_TextChanged;
            // 
            // textB
            // 
            textB.Location = new Point(158, 99);
            textB.Name = "textB";
            textB.Size = new Size(224, 27);
            textB.TabIndex = 3;
            textB.TextChanged += textB_TextChanged;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(239, 189);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(53, 29);
            btnclear.TabIndex = 4;
            btnclear.Text = "xóa";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(322, 189);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(60, 29);
            btnexit.TabIndex = 5;
            btnexit.Text = "thoát";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 106);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Nhập B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(104, 9);
            label3.Name = "label3";
            label3.Size = new Size(251, 29);
            label3.TabIndex = 8;
            label3.Text = "Giải phương trình bậc 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 246);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(textB);
            Controls.Add(textA);
            Controls.Add(lbresult);
            Controls.Add(btnsolve);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            TransparencyKey = Color.FromArgb(192, 192, 0);
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsolve;
        private Label lbresult;
        private TextBox textA;
        private TextBox textB;
        private Button btnclear;
        private Button btnexit;
        private ErrorProvider errorProvider1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}