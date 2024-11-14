﻿namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length : ");
            var length = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < length; i++)
            {
                var element = int.Parse(Console.ReadLine());
                numbers.Add(element);
            }

            var counter = 0;
            foreach (var element in numbers)
            {
                if(10 <= element && element <= 99)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
            
            

        }
        //1-misol
        public static string HelloName(string name)
        {
            Console.WriteLine($"Hello {name}");
            return name;
        }
        //2-misol
        public static string MakeAbba(string abba, string secondbba)


        {
            return abba + secondbba + secondbba + abba;
        }
        //3-misol
        public static string MakeOutWord(string word, string secondword)
        {
            return word.Insert(word.Length / 2, secondword);

        }
        //4-misol
        public static string ExtraEnd(string simba)
        {
            return simba.Substring(simba.Length - 2) + simba.Substring(simba.Length - 2) + simba.Substring(simba.Length - 2);
        }
        //5-misol
        public static string FirstTwo(string mufassa)
        {
            return mufassa.Substring(0, 2);
        }
        //6-misol
        public static string FirstHalf(string skar)
        {
            return skar.Substring(0, skar.Length / 2);
        }
        //7-misol
        public static string WithoutEnd(string timon)
        {

            return timon.Substring(1, timon.Length - 2);
        }
        //8-misol
        public static string ComboString(string text, string pumba)
        {
            return text + pumba + text;
        }
        //9-misol
        public static string Nonstart(string text, string alex)
        {
            return text.Substring(1) + alex.Substring(1);
        }
        //10-misol
        public static string Left2(string text)
        {



            return text.Substring(2) + text.Substring(0, 2);
        }
        //11-misol
        public static string TheEnd(string text, bool front)
        {
            if (front)
            {
                return text.Substring(0, 1);
            }
            else
            {
                return text.Substring(text.Length - 1);
            }

        }
        //12-misol
        public static string NTwich(string text)
        {
            return text.Substring(0, 3) + text.Substring(text.Length - 3);
        }
        //13-misol
        public static string MiddleThere(string text)
        {
            var middle = text.Length / 2;
            return text.Substring(middle - 1, 1) + text.Substring(middle, 1) + text.Substring(middle + 1, 1);
        }
        //14-misol
        public static string ConCat(string text, string opiy)
        {
            if (text[text.Length - 1] == opiy[0])
            {
                opiy = opiy.Remove(0, 1);
                return text + opiy;
            }
            else
            {
                return text + opiy;
            }
        }
        //15-misol
        public static string LastTwo(string text)
        {
            var last = text[text.Length - 2];
            return text.Substring(0, text.Length - 2) + text.Substring(text.Length - 1) + last;
        }
        //16-misol
        public static string SeeColor(string text)
        {
            if (text.StartsWith("red") is true)
            {
                return "red";
            }
            if (text.StartsWith("blue") is true)
            {
                return "blue";
            }

            return string.Empty;
        }
        //17-misol
        public static string FrontAgain(string text)
        {
            if (text.StartsWith(text[text.Length - 2]))
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        //18-misol
        public static string MinCat(string text, string nala)
        {
            if (text.Length > nala.Length)
            {
                text = text.Substring(text.Length - nala.Length);

            }
            else if (text.Length < nala.Length)
            {
                nala = nala.Substring(nala.Length - text.Length);
            }
            return text + nala;
        }
        //19-misol
        public static string DeFront(string text)
        {
            if (text.Length >= 2)
            {
                if (text[0] == 'a' && text[1] == 'b')
                {
                    return text;
                }
                else if (text[0] == 'a')
                {
                    return text.Substring(1);
                }
                else if (text[1] == 'b')
                {
                    return text[0] + text.Substring(2);
                }
                else
                {
                    return text.Substring(2);
                }

            }
            else
            {
                return text;

            }
        }
        //20-misol
        public static string WithoutX(string text)
        {
            if (text[0] == 'x' && text[text.Length - 1] == 'x')
            {
                text = text.Remove(text.Length - 1, 1);
                text = text.Remove(0, 1);
                return text;
            }
            else
            {
                return text;
            }
        }
        //21-misol
        public static bool CatDog(string text)
        {

            var simba = 0;
            var nala = 0;
            for (var i = 0; i <= text.Length - 3; i++)
            {
                if (text.Substring(i, 3) == "cat")
                {
                    simba++;
                }
                else if (text.Substring(i, 3) == "dog")
                {
                    nala++;
                }

            }
            return simba == nala;
        }
        //22-misol
        public static int CountCode(string text)
        {
            var timon = 0;
            for (var i = 0; i <= text.Length - 4; i++)
            {
                if (text[i] == 'c' && text[i + 1] == 'o' && text[i + 3] == 'e')
                {
                    timon++;
                }
            }
            return timon;
        }
        //23-misol
        public static bool EndOther(string text, string pumba)
        {
            text = text.ToUpper();
            pumba = pumba.ToUpper();
            if (text.EndsWith(pumba) || pumba.EndsWith(text))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        //24-misol
        public static bool StrXyz(string text)
        {
            for (var i = 0; i <= text.Length - 3; i++)
            {
                var nick = false;
                if (text[i] == '.')
                {
                    nick = true;
                    continue;
                }
                if (text.Substring(i, 3) == "xyz")
                {
                    if (!nick)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        //25-misol
        public static string MixString(string text, string nala)
        {
            var result = string.Empty;
            int minText = Math.Min(text.Length, nala.Length);
            for (var i = 0; i < minText; i++)
            {
                result += text[i];
                result += nala[i];
                if (text.Length > nala.Length)
                {
                    result += text.Substring(minText);
                }
                else if (nala.Length > text.Length)
                {
                    result += nala.Substring(minText);
                }
            }

            return result;
        }
        //26-misol
        public static string RepeatEnd(string text, int n)
        {
            var result = String.Empty;
            text = text.Substring(text.Length - n);

            for (var i = 0; i < n; i++)
            {
                result += text;


            }

            return result;
        }
        //27-misol
        public static string RepeatFront(string text, int n)
        {
            var result = String.Empty;
            text = text.Substring(0, n);
            for (var i = 0; i < n; i++) result += text.Substring(0, n - i);
            return result;
        }
        //28-misol
        public static string RepeatSeparator(string text, string timon, int n)
        {
            if (n == 0)
            {
                return String.Empty;
            }
            var result = text;
            for (var i = 1; i < n; i++)
            {
                result += timon + text;
            }
            return result;
        }
        //29-misol
        public static bool PrefixAgain(string text, int n)
        {   if (text.Length > n) {  false; }
            var result = text.Substring(0, n);
            var front = false;
            for (var i = n; i <= text.Length-n; i++)
            {

                if (text.Substring(i, n) == result) front = true;


            }
            return front;
        }
        
        
    }
}