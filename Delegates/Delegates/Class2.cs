using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class2
    {
        private readonly Class1 _class1 = new ();
        private Predicate<int> _resultDelegate;
        private int _calcResult;

        public bool Status { get; set; }
        public Func<int, int, int> PowDelegate { get; set; }

        public Predicate<int> Calc(Func<int, int, int> powDelegate, int x, int y)
        {
            powDelegate = _class1.Pow;
            _calcResult = powDelegate.Invoke(x, y);
            _resultDelegate = Result;
            return _resultDelegate;
        }

        public bool Result(int number)
        {
            Status = false;
            PowDelegate = _class1.Pow;
            if (_calcResult % number == 0)
            {
                Status = true;
            }

            return Status;
        }
    }
}
