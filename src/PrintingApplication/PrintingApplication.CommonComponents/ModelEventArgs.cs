using System;

namespace PrintingApplication.CommonComponents
{
    public class ModelEventArgs<T> : EventArgs
    {
        public T Value { get; set; }

        public ModelEventArgs(T value)
        {
            Value = value;
        }
    }
}
