using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMSampleProject.Observable
{
    public class ObservableEventArgs<T>: EventArgs
    {
        public T value;
        
        public ObservableEventArgs(T value)
        {
            this.value = value;
        }
    }
}
