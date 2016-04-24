using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Data {
    interface IHistory<T> {
        void AddHistory(T item);

        void ClearHistory();
    }
}
