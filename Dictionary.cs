using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Dictionary<S,V>
    {
       S[] keys;   // stringleri tutan keys dizisi 
       V[] values;  //  degerleri(int) tutan values dizisi

    public Dictionary()
        {
            keys = new S[0]; // burda keys ve values dizilerine bellekte adres verdik ve elemanlarini
            values = new V[0];  //  0 olarak atadik

        }

        public void Add(S key, V value)
        {
            S[] tempKeys = keys;  // tempKeys ve tempValues , keys ve values ikinci defa new'lendigi icin eski adresteki bilgileri tutacak.
            V[] tempValues = values;


            keys = new S[keys.Length + 1]; // burda ikinci defa new'ledigimiz icin adresteki yer degisecek 
            values = new V[values.Length + 1];

            // bu kisimda keys ve values in eski adresteki verilerini yeni adrese aktaricaz for dongusuyle

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i <tempValues.Length; i++)
            {
                values[i] = tempValues[i];

            }


            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            }
        public int Lenght
        {
            get { return keys.Length; }
        }


        }





    }

