using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampleProject.Observable
{

    public class ObservableData<T>
    {
        public event EventHandler<ObservableEventArgs<T>> Observers;

        private T value;

        public void SetValue(T value)
        {
            this.value = value;
            Observers?.Invoke(this, new ObservableEventArgs<T>(value));
        }

        public T GetValue()
        {
            return this.value;
        }

    }
}
