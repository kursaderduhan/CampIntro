﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add (T item)
        {
            T[] tempArray = items; //önceki değerleri korumak için yazdık
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
