﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    ///<summary>
    ///Список
    /// </summary>
    class SimpleList<T> : IEnumerable<T> where T : IComparable
    {
        ///<summary>
        ///Первый элемент списка
        /// </summary>
        protected SimpleListItem<T> first = null;

        ///<summary>
        ///Послдений элемент списка
        /// </summary>
        protected SimpleListItem<T> last = null;

        ///<summary>
        ///Количество элементов
        /// </summary>
        public int Count
        {
            get { return _count; }
            protected set { _count = value; }
        }
        int _count;


        ///<summary>
        ///Добавление элемента
        ///</summary>
        public void Add(T element)
        {
            SimpleListItem<T> newItem = new SimpleListItem<T>(element);
            this.Count++;

            //добавление первого элемента
            if (last == null)
            {
                this.first = newItem;
                this.last = newItem;
            }
            //добавление следующих элементов
            else
            {
                //присоединение элемента к цепочке
                this.last.next = newItem;
                //присоединенный элемент считается последним
                this.last = newItem;
            }
        }

        /// <summary> 
        /// Чтение контейнера с заданным номером 
        /// </summary> 
        public SimpleListItem<T> GetItem(int number)
        {
            if ((number < 0) || (number >= this.Count))
            {
                //Можно создать собственный класс исключения 
                throw new Exception("Выход за границу индекса");
            }
            SimpleListItem<T> current = this.first; int i = 0;
            //Пропускаем нужное количество элементов 
            while (i < number)
            {
                //Переход к следующему элементу 
                current = current.next;
                //Увеличение счетчика 
                i++;
            }
            return current;
        }
        /// <summary> 
        /// Чтение элемента с заданным номером 
        /// </summary> 
        public T Get(int number)
        {
            return GetItem(number).data;
        }
        /// <summary> 
        /// Для перебора коллекции
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            SimpleListItem<T> current = this.first;
            //Перебор элементов 
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
        //Реализация обобщенного IEnumerator<T> требует реализации необобщенного интерфейса
        //Данный метод добавляется автоматически при реализации интерфейса 
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            Sort(0, this.Count - 1);
        }
        /// <summary> 
        /// Алгоритм быстрой сортировки
        /// </summary>
        private void Sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0)
                    ++i;
                while (Get(j).CompareTo(x) > 0)
                    --j;
                if (i <= j)
                {
                    Swap(i, j);
                    i++;
                    j--;
                }
            }
            while (i <= j);

            if (low < j)
                Sort(low, j);
            if (i < high)
                Sort(i, high);
        }

        private void Swap(int i, int j)
        {
            SimpleListItem<T> ci = GetItem(i);
            SimpleListItem<T> cj = GetItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }
}

