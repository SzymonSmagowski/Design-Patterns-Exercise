using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX22
{
    class Spacing : ITextPattern
    {
        public string TextKey { get; set; }

        public string TextAction(string s)
        {
            string tmp = "";
            for(int i=0; i < s.Length; i++)
            {
                if (i==s.Length-1)
                {
                    tmp += s[i];
                    break;
                }
                tmp += s[i];
                tmp += " ";
            }
            return tmp;
        }
        public Spacing()
        {
            TextKey = "spacing";
        }
    }
    class Uppercase : ITextPattern
    {
        public string TextKey { get; set; }

        public string TextAction(String s)
        {
            if (s == string.Empty)
            {
                return s;
            }
            if (s==null)
            {
                return "";
            }

            var tmp = s.ToUpper();
            
            return tmp;
        }
        public Uppercase()
        {
            TextKey = "uppercase";
        }
    }
}
