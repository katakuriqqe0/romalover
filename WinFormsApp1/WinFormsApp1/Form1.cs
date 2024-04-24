namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // �������� ������� ������� �������� � ���������� ����
                    double sideLength = double.Parse(textBox1.Text);

                    // ���������� ����� ��������
                    double area = sideLength * 4;

                    // �������� ��������� � �������� ���� ��� ������
                    textBox1.Text = "����� ��������: " + area.ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("���� �����, ������ ������� �������� ��� ������� �������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}