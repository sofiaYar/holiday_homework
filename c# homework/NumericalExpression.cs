using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumericalExpression
    {
        public long inputNumber;
        private string[]  numbersFromOneToTwenty = 
            {"","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
            "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty"};
        private string[] tens = 
            { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private string[] thousands = 
            { "", "Thousand", "Million", "Billion" };

        public NumericalExpression(long inputNumber)
        {
            this.inputNumber = inputNumber;
        }

        public string ToString()
        {
            return ConvertToExpression(inputNumber);
        }

        public long GetValue()
        {
            return inputNumber;
        }

        public long SumLetters(long number)
        {
            long answer = 0;
            while (number > 0)
            {
                string expression = ConvertToExpression(number);
                number--;
                expression = expression.Replace(" ", "");
                answer += expression.LongCount();
            }
            return answer;

        }
        //The feature of object-oriented programming (OOP) that I use here is called "overloading method"
        //overloading method is when multiple methods can have the same name but different parameters.
        public static long SumLetters(NumericalExpression numberToExpress)
        {
            long number = numberToExpress.GetValue();
            return numberToExpress.SumLetters(numberToExpress.GetValue());

        }

        private string ConvertToExpression(long number)
        {
            if (inputNumber == 0)
            {
                return "zero";
            }
            
            int thousnd = 0;
            string answer = "";
            while (number > 0)
            {
                int threeNumbers = (int)(number % 1000);
                number /= 1000;
                answer = $"{ConvertThreeDigitsToWords(threeNumbers)} {thousands[thousnd]} {answer}";
                thousnd++;
            }
            return answer;
        }

        private string ConvertThreeDigitsToWords(int num)
            {
                if (num == 0)
                    return "";

                string answer = "";

                int hundreds = num / 100; 
                int left = num % 100;

                if (hundreds > 0)
                {
                    answer += numbersFromOneToTwenty[hundreds] + " Hundred ";
                }

                if (left < 10)
                {
                    answer += numbersFromOneToTwenty[left];
                }
                else if (left < 20)
                {
                    answer += numbersFromOneToTwenty[left];
                }
                else
                {
                    answer += tens[left / 10] + " " + numbersFromOneToTwenty[left % 10];
                }

                return answer;
            }
        

    }
}
