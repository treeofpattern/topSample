using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestExample
{
    public class BaseResult
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public BaseResult()
        {
            this.IsSuccess = false;
            this.ErrorMessage = "";
        }
    }

    public class ArrayResult<T> : BaseResult
    {
        public List<T> LstResult { get; set; }

        public ArrayResult() : base()
        {
            LstResult = new List<T>();
        }
    }

    public class SingleResult<T> : BaseResult
    {
        public T Result { get; set; }
        public SingleResult() : base()
        {
            if (typeof(T) != typeof(String))
            {
                Result = (T)Activator.CreateInstance(typeof(T));
            }

        }
    }
}
