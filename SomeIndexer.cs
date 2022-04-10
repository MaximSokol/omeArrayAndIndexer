using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndIndexers
{
    class SomeIndexer
    {
        string[] key = new string[5];
        string[] eng = new string[5];
        string[] ua = new string[5];

       public SomeIndexer()
        {
            key[0] = "природа";
            key[1] = "глаза";
            key[2] = "крик";
            key[3] = "необходимо";
            key[4] = "оружие";
            //------------------------

            eng[0] = "nature";
            eng[1] = "eyes";
            eng[2] = "crying";
            eng[3] = "necessary";
            eng[4] = "gun";
            //------------------------

            ua[0] = "природа";
            ua[1] = "очі";
            ua[2] = "крик";
            ua[3] = "необхідно";
            ua[4] = "зброя";
            //------------------------
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return $"{key[index]}\t" + " - " + $"{eng[index]}" + " - " + $"{ua[index]}";
                return "Index out of range exception!";
            }
        }
        //------------------------------------------------

        public string this[string index]
        {
            get
            {
                for(int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return $"{key[i]}" + " - " + $"{eng[i]}" + " - " + $"{ua[i]}";
                    if (eng[i] == index)
                        return $"{eng[i]}" + " - " + $"{key[i]}" + " - " + $"{ua[i]}";
                    if (ua[i] == index)
                        return $"{ua[i]}" + " - " + $"{key[i]}" + " - " + $"{eng[i]}";
                }
                return $"{index}" + "There is no translating for this word!";
            }
        }
        //------------------------------------------------
    }
}
