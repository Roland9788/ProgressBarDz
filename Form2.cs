using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarDz
{
    public partial class Form2 : Form
    {
        int i = 0;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 4)
            {
                btNext.Text = "Завершить";
            }
            if (i == 5)
            {
                MessageBox.Show("Благодарю за прохождение анкеты");
                this.Close();
            }
            switch(i)
            {
                case 1:
                    {
                        Answer1.Checked = false;
                        Answer2.Checked = false;
                        Answer3.Checked = false;
                        Answer4.Checked = false;
                        tBAnswer4.Visible = false;
                        tBAnswer4.Text = "";

                        Question.Text = "Вопрос 2:  На каком языке вы прогрмаммируете ? ";
                        Answer1.Text = "С#";
                        Answer2.Text = "C++";
                        Answer3.Text = "Java";
                        Answer4.Visible = true;
                        if (Answer4.Checked == true)
                        {
                            tBAnswer4.Visible=true;
                        }
                        break;
                    }

                case 2:
                    {
                        Answer1.Checked = false;
                        Answer2.Checked = false;
                        Answer3.Checked = false;
                        Answer4.Checked = false;
                        tBAnswer4.Visible = false;
                        tBAnswer4.Text = "";

                        Question.Text = "Вопрос 3:  Сколько в среднем вы проводите времени за написанием какого либо кода ? ";
                        Answer1.Text = "1 час";
                        Answer2.Text = "2 часа";
                        Answer3.Text = "4 часа";
                        Answer4.Visible = true;
                        if (Answer4.Checked == true)
                        {
                            tBAnswer4.Visible = true;
                        }
                        break;
                    }

                case 3:
                    {
                        Answer1.Checked = false;
                        Answer2.Checked = false;
                        Answer3.Checked = false;
                        Answer4.Checked = false;
                        tBAnswer4.Visible = false;
                        tBAnswer4.Text = "";

                        Question.Text = "Вопрос 4:  Активно ли вы ведете свой гитхаб и кодите ? ";
                        Answer1.Text = "Да";
                        Answer2.Text = "Нет";
                        Answer3.Text = "Когда как";
                        Answer4.Visible = false;
                        if (Answer4.Checked == true)
                        {
                            tBAnswer4.Visible = true;
                        }
                        break;
                    }

                case 4:
                    {
                        Answer1.Checked = false;
                        Answer2.Checked = false;
                        Answer3.Checked = false;
                        Answer4.Checked = false;
                        Answer1.Visible = false;
                        Answer2.Visible = false;
                        Answer3.Visible = false;
                        Answer4.Visible = false;

                        tBAnswer4.Visible = true;
                        tBAnswer4.Text = "";

                        Question.Text = "Вопрос 5:  Какую должность вы бы хотели занимать ? (Введите ответ ниже) ";


                        break;
                    }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Answer4.Visible)
            {
                if (Answer4.Checked)
                {
                    tBAnswer4.Visible = true;
                }
                else
                {
                    tBAnswer4.Visible = false;
                    tBAnswer4.Text = "";
                }
            }
        }
    }
}
