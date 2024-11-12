using System;
using System.Text;
using System.Collections.Generic;
namespace C_sharp
{
    public class StringHandler
    {
        public string CheckString(string str)
        {
            if (str == null)
            {
                var message = Error.NullString;
                return message;
            }
            else if (str.Length == 0)
            {
                var message = Error.EmptyString;
                return message;
            }
            else if (string.IsNullOrWhiteSpace(str))
            {
                var message = Error.WhiteSpaceString;
                return message;
            }
            else
            {
                return str;
            }
        }
        public string RemoveTrimChar(string str)
        {
            var validString = CheckString(str);
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                return validString.Trim();
            }
            return validString;
        }
        public string RemoveWhiteSpace(string str)
        {
            var validString = CheckString(str);
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                return validString.Replace(" ", "");
            }
            return validString;
        }

        public string ConvertToUpperCase(string str)
        {
            var validString = CheckString(str);
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                for (int i = 0; i < validString.Length; i++)
                {
                    if (validString[i] == ' ' && char.IsLower(validString[i + 1]) && i + 1 < validString.Length)
                    {
                        validString = validString.Replace(validString[i + 1], char.ToUpper(validString[i + 1]));
                    }
                }
            }
            return validString;
        }

        public int SpaceCount(string str)
        {
            var validString = CheckString(str);
            var strSize = validString.Length;
            var spaceCount = 0;
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                for (int i = 0; i < strSize; i++)
                {
                    if (validString[i] == ' ')
                    {
                        spaceCount++;
                    }
                }
            }
            return spaceCount;
        }

        public int NotSpaceCount(string str)
        {
            var validString = CheckString(str);
            var strSize = validString.Length;
            var spaceCount = 0;
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                for (int i = 0; i < strSize; i++)
                {
                    if (validString[i] != ' ')
                    {
                        spaceCount++;
                    }
                }
            }
            return spaceCount;
        }

        public bool CompareStringsIgonorCase(string str1, string str2)
        {
            var str1Length = str1.Length;
            var str2Length = str2.Length;
            if (str1Length != str2Length)
            {
                return false;
            }
            for (int i = 0; i < str1Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
            }
            return true;
        }

        public bool CompareStrings(string str1, string str2)
        {
            var str1Length = str1.Length;
            var str2Length = str2.Length;
            var lowerStr1 = str1.ToLower();
            var lowerStr2 = str2.ToLower();
            if (str1Length != str2Length)
            {
                return false;
            }
            for (int i = 0; i < str1Length; i++)
            {
                if (lowerStr1[i] != lowerStr2[i])
                {
                    return false;
                }
            }
            return true;
        }

        //get list index of a substring in string 

        public List<int> GetAllIndexSubString(string subStr, string str)
        {
            List<int> list = new List<int>();
            var subStrLength = subStr.Length;
            var strLength = str.Length;
            for (int i = 0; i < strLength; i++)
            {
                if (str[i] == subStr[0])
                {
                    var j = 0;
                    while (j < subStrLength && i + j < strLength && str[i + j] == subStr[j])
                    {
                        j++;
                    }
                    if (j == subStrLength)
                    {
                        list.Add(i);
                    }
                }

            }
            return list;
        }

        public string TransformString(string str)
        {
            var lowerString = str.ToLower();
            var listIndex = GetAllIndexSubString("abc", lowerString);
            for (int i = 0; i < str.Length; i++)
            {
                if (listIndex.Contains(i))
                {
                    str = str.Remove(i, 3).Insert(i, ((char)(str[i] + 3)).ToString() + ((char)(str[i + 1] + 3)).ToString() + ((char)(str[i + 2] + 3)).ToString());
                }
            }
            return str;
        }

        public string PrintString(string str)
        {
            var newString = $"Hiển thị chuỗi: Kính chào ông {str}. Chúc ngon miệng.";
            return newString;
        }

        public string ReverseString(string str)
        {
            var validString = CheckString(str);
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                var strLength = validString.Length;
                var reverseString = string.Empty;
                for (int i = strLength - 1; i >= 0; i--)
                {
                    reverseString = reverseString + validString[i];
                }
                return reverseString.ToString();
            }
            return validString;
        }

        public string SplitFirstString(string str, int count)
        {
            if (count < 0)
            {
                return Error.InvalidCount;
            }
            var validString = CheckString(str);
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                var newStr = RemoveTrimChar(validString);
                newStr = validString.Substring(0, count + 1);
                return newStr;
            }
            return validString;
        }

        public string SplitLastString(string str, int count)
        {
            if (count < 0)
            {
                return Error.InvalidCount;
            }
            var validString = CheckString(str);
            if (validString != Error.EmptyString && validString != Error.NullString && validString != Error.WhiteSpaceString)
            {
                var newStr = RemoveTrimChar(validString);
                newStr = validString.Substring(validString.Length - count, count);
                return newStr;
            }
            return validString;
        }

        // static void Main(string[] args)
        // {
        //     var stringHandler = new StringHandler();
        //     Console.WriteLine(stringHandler.SplitLastString("ABCdef", 3));
        // }

    }
}

