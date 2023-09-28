namespace gptbac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsolve_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textA.Text);
            double b = double.Parse(textB.Text);

            if (a != 0)
            {
                double x = -b / a;
                lbresult.Text = $"Nghiệm: {x}";
            }
            else if (b == 0)
            {
                lbresult.Text = "Vô số nghiệm.";
            }
            else
            {
                lbresult.Text = "Phương trình vô nghiệm.";
            }

            btnsolve.Enabled = false;
            btnclear.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnclear.Enabled = false;
            btnsolve.Enabled = false;
            errorProvider1.Clear();
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }
        private void ValidateInput()
        {
            if (double.TryParse(textA.Text, out _) && double.TryParse(textB.Text, out _))
            {
                btnsolve.Enabled = true;
                btnclear.Enabled = true;
                errorProvider1.Clear();
            }
            else
            {
                btnsolve.Enabled = false;
                btnclear.Enabled = false;
                errorProvider1.SetError(lbresult, "Hãy nhập các hệ số hợp lệ.");
            }
        }

        private void textB_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textB.Clear();
            lbresult.Text = "";
            textA.Focus();
            btnsolve.Enabled = false;
            btnclear.Enabled = false;
            errorProvider1.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}