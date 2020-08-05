using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._06
{
    public class PlacasDeCarro : ICollection<string>
    {
        private IList<string> lista = new List<string>();
        public int Count => lista.Count;
        public bool IsReadOnly => false;
        public IEnumerator<string> GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lista.GetEnumerator();
        }

        public void Add(string item)
        {
            if(!EhPlacaValida(item))
                throw new ArgumentException("Placa não é válida: " + item);
            
            lista.Add(item);
        }

        public void Clear()
        {
            lista.Clear();
        }

        public bool Contains(string item)
        {
            return lista.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            lista.CopyTo(array, arrayIndex);
        }

        public bool Remove(string item)
        {
            return lista.Remove(item);
        }
        
        private bool EhPlacaValida(string value)
        {
            Regex regex = new Regex(@"^[A-Z]{3}\-\d{4}$");

            if (regex.IsMatch(value))
            {
                return true;
            }

            return false;
        }
    }
}