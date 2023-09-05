using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public int Count 
        {
            get 
            { 
                return count; 
            } 
        }
        public int Capacity 
        {
            get
            {
                return capacity; 
            } 
        }
        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array


            //if items array is at capacity, doublejjj capacity and create new array

            //transfer all items to new array
            if (count < capacity)
            {
                items[count] = item;
                count++;
            }
            else
            {
                capacity *= 2;
                T[] temporaryArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = items[i];
                }
                temporaryArray[count] = item;
                items = temporaryArray;

            }
           

        }

        public bool Remove(T item)
        {
            bool valueRemoved = false;
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            if (count == 1)
            {
                items[0] = default(T);
                valueRemoved = true;
            }
            else
            {

                T[] temporaryArray = new T[capacity];
                for (int i = 0, j = 0; i < count; i++, j++)
                {

                    if (items[i].Equals(item) && valueRemoved == false)
                    {
                        j--;
                        valueRemoved = true;
                      
                    }
                    else
                    {
                        temporaryArray[j] = items[i];

                    }
                }
                if (valueRemoved == true)
                {
                    count--;
                }
                items = temporaryArray;

            }

            
            return valueRemoved;
            
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array

            string returnValue = null;

            foreach (T item in items)
            {

                if (item is int)
                {
                    returnValue += item.ToString();
                }
                else if (item is string)
                {
                    returnValue += item;
                }
                else if (item == null)
                {
                    return returnValue;

                }
                
            }
            return returnValue;
        }

            
           
        

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
