using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_DecodeTheMorseCode
{
	class Kata
	{
		public string Decode(string morseCode)
		{
            var dicc = new Dictionary<string, string>()
            {
                {"a", ".-"},
                {"b", "-..."},
                {"c", "-.-."},
                {"d", "-.."},
                {"e", "."},
                {"f", "..-."},
                {"g", "--."},
                {"h", "...."},
                {"i", ".."},
                {"j", ".---"},
                {"k", "-.-"},
                {"l", ".-.."},
                {"m", "--"},
                {"n", "-."},
                {"o", "---"},
                {"p", ".--."},
                {"q", "--.-"},
                {"r", ".-."},
                {"s", "..."},
                {"t", "-"},
                {"u", "..-"},
                {"v", "...-"},
                {"w", ".--"},
                {"x", "-..-"},
                {"y", "-.--"},
                {"z", "--.."},
                {"0", "-----"},
                {"1", ".----"},
                {"2", "..---"},
                {"3", "...--"},
                {"4", "....-"},
                {"5", "....."},
                {"6", "-...."},
                {"7", "--..."},
                {"8", "---.."},
                {"9", "----."},
                {"!", "-.-.--"},
                {"?", "..--.." },
                {"SOS", "...---..." }
            };

            var newString1 = "";
            char[] charsToTrim = { ' ' };
            var res = morseCode.Trim(charsToTrim);
            var list = res.Split("   ");
            
            foreach (var k in list)
            {
                if (k != " ")
                {
                    var list1 = k.Split(" ");
                    foreach (var j in list1)
                    {
                        if (j != " " && dicc.ContainsValue(j))
                        {
                            var a = dicc.Where(x => x.Value == j).FirstOrDefault();
                            newString1 += a.Key;
                        }
                    }
                }
                newString1 += " ";
            }
            var result = newString1.Remove(newString1.Length - 1, 1);
            return result.ToUpperInvariant();
        }
	}
}
