namespace Lab1
{
    public partial class PythagoreanSquareForm : Form
    {
        public PythagoreanSquareForm()
        {
            InitializeComponent();
        }

        public PythagoreanSquareForm(DateTime date)
        {
            InitializeComponent();

            // https://gadalkindom.ru/kvadrat-pifagora?_d=20&_m=2&_y=2023

            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            int firstWorkNum = GetSumDigits(day) + GetSumDigits(month) + GetSumDigits(year);
            int secondWorkNum = GetSumDigits(firstWorkNum);
            int thirdWorkNum = Math.Abs(firstWorkNum - 2 * (day < 10 ? day : day / 10));
            int fourthWorkNum = GetSumDigits(thirdWorkNum);

            string resultString =
                $"{date.ToString("ddMMyyyy")}{firstWorkNum}{secondWorkNum}{thirdWorkNum}{fourthWorkNum}";

            // Подсчет вхождения каждой цифры из resultString
            Dictionary<char, int> charFrequency = new Dictionary<char, int>()
            {
                ['0'] = 0, ['1'] = 0, ['2'] = 0, ['3'] = 0, ['4'] = 0,
                ['5'] = 0, ['6'] = 0, ['7'] = 0, ['8'] = 0, ['9'] = 0
            };

            foreach (char c in resultString)
            {
                charFrequency[c]++;
            }

            Label[] labels =
                { lblCharacter, lblEnergy, lblInterest, lblHealth, lblLogic, lblLabour, lblLuck, lblDuty, lblMind };

            for (int i = 1; i <= 9; i++)
            {
                char digit = (char)(i + '0');
                int count = charFrequency[digit];
                labels[i - 1].Text = new string(digit, count);
            }
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