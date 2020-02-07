using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dima.Tests
{
    class JsonTest
    {
        public void CorrectJson(string source, string dest)
        {
            string jsonString = File.ReadAllText(source);
            char[] fakeJsonString = jsonString.ToCharArray();
            foreach (char item in fakeJsonString)
            {
                if (item == '(') { fakeJsonString[item] = '['; }
                else if (item == ')') { fakeJsonString[item] = ']'; }
            }
            jsonString = new string(fakeJsonString);
            File.WriteAllText(dest, jsonString);
        }
    }
}
