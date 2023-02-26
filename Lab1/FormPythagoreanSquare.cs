using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormPythagoreanSquare : Form
    {
        public FormPythagoreanSquare(DateTime date)
        { 
            InitializeComponent();

            // https://gadalkindom.ru/kvadrat-pifagora?_d=20&_m=2&_y=2023

            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            int firstWorkNum = GetSumDigits(day) + GetSumDigits(month) + GetSumDigits(year);
            int secondWorkNum = GetSumDigits(firstWorkNum);
            int thirdWorkNum = firstWorkNum - 2 * (day < 10 ? day : day / 10);
            int fourthWorkNum = GetSumDigits(thirdWorkNum);

            string s = day.ToString() + month.ToString() + year.ToString() +
                firstWorkNum.ToString() + secondWorkNum.ToString() + 
                thirdWorkNum.ToString() + fourthWorkNum.ToString();

            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                ['0'] = 0,
                ['1'] = 0,
                ['2'] = 0,
                ['3'] = 0,
                ['4'] = 0,
                ['5'] = 0,
                ['6'] = 0,
                ['7'] = 0,
                ['8'] = 0,
                ['9'] = 0
            };

            foreach (char c in s)
            { 
                map[c]++;
            }
            
            lblCharacter.Text = new string('1', map['1']);
            lblEnergy.Text = new string('2', map['2']);
            lblInterest.Text = new string('3', map['3']);
            lblHealth.Text = new string('4', map['4']);
            lblLogic.Text = new string('5', map['5']);
            lblLabour.Text = new string('6', map['6']);
            lblLuck.Text = new string('7', map['7']);
            lblDuty.Text = new string('8', map['8']);
            lblMind.Text = new string('8', map['9']);

        }

        private int GetSumDigits(int digit)
        {
            int sum = 0;
            while (digit > 0)
            {
                sum += digit % 10;
                digit /= 10;
            }
            return sum;
        }
    }
}
