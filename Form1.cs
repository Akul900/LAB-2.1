﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            try // оборачиваем кусок кода склонный к падению
            {
                value = int.Parse(this.copeiky.Text);
            }
            catch (FormatException) // тип ошибки, которую перехватываем
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // прерываем обработчик клика, если ввели какую-то ерунду
            }
            /* if (String.IsNullOrEmpty(txt))
             {
                 MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }*/
            Program.Input(value);

        }

        class Program
        {
            static void Rub_1(int rub, int kop)
            {
                if (rub % 10 == 1 && rub != 11)
                {
                    if (kop % 10 == 1 && kop != 11)
                    {
                        MessageBox.Show($"{rub} рубль {kop} копейка");
                        // return $"{rub} рубль {kop} копейка";
                    }
                    if (kop % 10 == 2 || kop % 10 == 3 || kop % 10 == 4 || kop == 11 || kop == 10 || kop == 0 || kop % 10 == 0)
                    {
                        if (kop >= 10 && kop <= 20 || kop == 0 || kop % 10 == 0)
                            MessageBox.Show($"{rub} рубль {kop} копеек");
                        // return $"{rub} рубль {kop} копеек";
                        else
                                    MessageBox.Show($"{rub} рубль {kop} копейки");
                          //  return $"{rub} рубль {kop} копейки";
                    }

                    if (kop % 10 >= 5 && kop % 10 <= 9)
                    {
                        MessageBox.Show($"{rub} рубль {kop} копеек");
                        // return $"{rub} рубль {kop} копеек";
                    }
                }
                //return "lol";
            }
            static void Rub_2(int rub, int kop)
            {
                if (rub % 10 == 2 || rub % 10 == 3 || rub % 10 == 4 || rub >= 10 && rub <= 20 || rub == 0 || rub % 10 == 0)
                {
                    if (rub >= 10 && rub <= 20 || rub == 0 || rub % 10 == 0)
                    {
                        if (kop % 10 == 1 && kop != 11)
                        {
                            MessageBox.Show($"{rub} рублей {kop} копейка");
                            // return ($"{rub} рублей {kop} копейка");
                        }
                        if (kop % 10 == 2 || kop % 10 == 3 || kop % 10 == 4 || kop == 11 || kop == 10 || kop == 0)
                        {
                            if (kop >= 10 && kop <= 20 || kop == 0)
                                MessageBox.Show($"{rub} рублей {kop} копеек");
                            // return ($"{rub} рублей {kop} копеек");
                            else
                                MessageBox.Show($"{rub} рублей {kop} копейки");
                            // return ($"{rub} рублей {kop} копейки");
                        }

                        if (kop % 10 >= 5 && kop % 10 <= 9)
                        {
                            MessageBox.Show($"{rub} рублей {kop} копеек");
                            // return  ($"{rub} рублей {kop} копеек");
                        }
                    }
                    else
                    {
                        if (kop % 10 == 1 && kop != 11)
                        {
                            MessageBox.Show($"{rub} рубля {kop} копейка");
                            //return ($"{rub} рубля {kop} копейка");
                        }
                        if (kop % 10 == 2 || kop % 10 == 3 || kop % 10 == 4 || kop == 11 || kop == 10 || kop == 0 || kop % 10 == 0)
                        {
                            if (kop >= 10 && kop <= 20 || kop == 0 || kop % 10 == 0)
                                MessageBox.Show($"{rub} рубля {kop} копеек");
                            // return ($"{rub} рубля {kop} копеек");
                            else
                                MessageBox.Show($"{rub} рубля {kop} копейки");
                            // return ($"{rub} рубля {kop} копейки");
                        }

                        if (kop % 10 >= 5 && kop % 10 <= 9)
                        {
                            MessageBox.Show($"{rub} рубля {kop} копеек");
                            //return ($"{rub} рубля {kop} копеек");
                        }
                    }
                }
                //return "lol";
            }
            static void Rub_3(int rub, int kop)
            {
                if (rub % 10 >= 5 && rub % 10 <= 9)
                {
                    if (kop % 10 == 1 && kop != 11)
                    {
                        MessageBox.Show($"{rub} рублей {kop} копейка");
                        // return ($"{rub} рублей {kop} копейка");
                    }
                    if (kop % 10 == 2 || kop % 10 == 3 || kop % 10 == 4 || kop == 11 || kop == 10 || kop == 0 || kop % 10 == 0)
                    {
                        if (kop >= 10 && kop <= 20 || kop == 0 || kop % 10 == 0)
                            MessageBox.Show($"{rub} рублей {kop} копеек");
                        // return ($"{rub} рублей {kop} копеек");
                        else
                            MessageBox.Show($"{rub} рублей {kop} копейки");
                        // return ($"{rub} рублей {kop} копейки");
                    }

                    if (kop % 10 >= 5 && kop % 10 <= 9)
                    {
                        MessageBox.Show($"{rub} рублей {kop} копеек");
                        //return ($"{rub} рублей {kop} копеек");
                    }
                }
                //return "lol";
            }
            public static void Input (int value)
            {
                int rub;
                int kop;
                if (value < 1 || value > 9999)
                {
                    MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // прерываем обработчик клика, если ввели какую-то ерунду
                }
                /*Console.Write("Введите число копеек в диапазоне 1 <= n <= 9999 : ");
                string check = txt;
                bool proverka = int.TryParse(check, out int value);
                while (!proverka || (value < 1 || value > 9999))
                {
                    Console.WriteLine("Ошибка ввода, введите число копеек в диапазоне 1 <= n <= 9999");
                    check = Console.ReadLine();
                    proverka = int.TryParse(check, out value);
                }*/

                rub = value / 100;
                kop = value % 100;

                Rub_1(rub, kop);
                Rub_2(rub, kop);
                Rub_3(rub, kop);
            }
        }

    }
}
