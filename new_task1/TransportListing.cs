using System;
using System.Collections.Generic;

namespace new_task1
{
    class TransportList
    {
        internal List<Transport> transportListing = new List<Transport>(); //Использую структру List, является ли это композицией?
                                                         //Могу ли я унаследоваться от List, это плохо или хорошо? 
    
        public void AddToListing(Transport element) //Создал свой метод добавления
        {
            transportListing.Add(element);
        }

        public void DeleteFromListing(Transport element) //Создал свой метод удаления
        {
            transportListing.Remove(element);
        }

        public void ClearListing() //Создал свой метод сброса листа 
        {
            transportListing.Clear();
        }

        public IEnumerator<Transport> GetEnumerator()
        {
            foreach (Transport item in transportListing)
            {
                yield return item;
            }
        }
    }
}
