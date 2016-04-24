using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Data {
    interface IConfig<T> {
        void SetConfig(string key, T value);

        T GetConfig(string key);
    }
}
