using System;
 
 namespace Assignments
 {

 
    public class NumberToWord {
        private static string[] specialNames = {
        "",
        " thousand",
        " million",
        " billion",
        " trillion",
        " quadrillion",
        " quintillion"
        };

        private static string[] tensNames = {
        "",
        " ten",
        " twenty",
        " thirty",
        " forty",
        " fifty",
        " sixty",
        " seventy",
        " eighty",
        " ninety"
        };

        private static string[] numNames = {
        "",
        " one",
        " two",
        " three",
        " four",
        " five",
        " six",
        " seven",
        " eight",
        " nine",
        " ten",
        " eleven",
        " twelve",
        " thirteen",
        " fourteen",
        " fifteen",
        " sixteen",
        " seventeen",
        " eighteen",
        " nineteen"
        };

        private string convertLessThanOneThousand(int number) {
            
            string current;

            if (number % 100 < 20){
                current = numNames[number % 100];
                number /= 100;
            }
            else {
                current = numNames[number % 10];
                number /= 10;
                current = tensNames[number % 10] + current;
                number /= 10;
            }
            if (number == 0) return current;
            return numNames[number] + " hundred" + current;
            }

            public string convert(int number) {
             if (number == 0) { return " zero"; }

            string prefix = "";

            if (number < 0) {
                number = -number;
                prefix = "negative";
            }

            string current = "";
            int place = 0;

            do {
                int n = number % 1000;
                if (n != 0){
                string s = convertLessThanOneThousand(n);
                current = s + specialNames[place] + current;
            }
            place++;
            number /= 1000;
            } while (number > 0);

            return (prefix + current);
        }
    }
 }