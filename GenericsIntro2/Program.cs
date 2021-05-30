using System;

namespace GenericsIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary1 = new MyDictionary<string, int>();
            myDictionary1.Add2("C#", 1);
            Console.WriteLine(myDictionary1.KeyCount);
            myDictionary1.Add2("Python", 2);
            Console.WriteLine(myDictionary1.KeyCount);
            myDictionary1.Add2("Java", 3);
            Console.WriteLine(myDictionary1.KeyCount);
            myDictionary1.Add2("C++", 4);
            Console.WriteLine(myDictionary1.KeyCount);
            

            myDictionary1.Show();
        }
    }


    class MyDictionary<Tkey, Tval>
    {
        Tkey[] key;
        Tval[] value;
        Tkey[] temp_key;
        Tval[] temp_val;
        public MyDictionary()
        {
            key = new Tkey[0];
            value = new Tval[0];

        }

        

        public void Add2(Tkey _tkey, Tval _tval)
        {
            temp_key = key;
            temp_val = value;

            key = new Tkey[key.Length + 1];
            value = new Tval[value.Length + 1];

            for (int i = 0; i < temp_key.Length; i++)
            {
                key[i] = temp_key[i];
            }
            for (int i = 0; i < temp_val.Length; i++)
            {
                value[i] = temp_val[i];
            }
            key[key.Length - 1] = _tkey;
            value[value.Length - 1] = _tval;
        }


        public int KeyCount
        {
            get { return key.Length; }
        }
        public int ValueCount
        {
            get { return value.Length; }
        }

        public void Show()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("Programming Languages: "+key[i]+" -->  "+value[i]);
            }

        }

    }
    
   
}
