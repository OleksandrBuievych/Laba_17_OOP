using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_17_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) // Кнопка "Варіант завдання"
        {
            MessageBox.Show("Створити абстрактний базовий клас Triangle для представлення трикутника з віртуальними функціями обчислення площі й периметра.Поля даних повинні включати дві сторони й кут між ними.Визначити класи - спадкоємці: прямокутний трикутник, рівнобедрений трикутник, рівносторонній трикутник зі своїми функціями обчислення площі й периметра.");
        }

        private void button1_Click(object sender, EventArgs e) // Площа і периметр прямокутного трикутника
        {
            try  // Обробка виключення, при пустих полях вводу
            {
                double s1 = double.Parse(textBox1.Text);    // Зчитуємо дані з рядка
                double s2 = double.Parse(textBox2.Text);
                RightTriangle rt = new RightTriangle(s1, s2);   // Створюємо об"єкт правильного трикутника, для обчислення площі і периметра
                MessageBox.Show($" Площа трикутника = {rt.Area().ToString()}\n Периметр трикутника = {rt.Perimeter().ToString()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Площа і периметр рівнобедреного трикутника
        {
            try
            {
                double s = double.Parse(textBox1.Text);
                double a = double.Parse(textBox3.Text);
                IsoscelesTriangle it = new IsoscelesTriangle(s, a);
                MessageBox.Show($" Площа трикутника = {it.Area().ToString()}\n Периметр трикутника = {it.Perimeter().ToString()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Площа і периметр рівностороннього трикутника
        {
            try
            {
                double s = double.Parse(textBox1.Text);
                EquilateralTriangle et = new EquilateralTriangle(s);
                MessageBox.Show($" Площа трикутника = {et.Area().ToString()}\n Периметр трикутника = {et.Perimeter().ToString()}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
