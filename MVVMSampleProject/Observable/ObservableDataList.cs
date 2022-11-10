using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampleProject.Observable
{
    public class ObservableDataList<T>: ObservableData<List<T>>
    {
        public ObservableDataList()
        {
            SetValue(new List<T>());
        }

        public void Add(T item)
        {
            List<T> items = GetValue();
            items.Add(item);
            SetValue(items);
        }

        public void AddAll(List<T> list)
        {
            List<T> items = GetValue();
            items.AddRange(list);
            SetValue(items);
        }

        public void Clear()
        {
            List<T> items = GetValue();
            items.Clear();
            SetValue(items);
        }

        public void Remove(T item)
        {
            List<T> items = GetValue();
            items.Remove(item);
            SetValue(items);
        }

        public void NotifyChange()
        {
            List<T> items = GetValue();
            SetValue(items);
        }
    }
}
