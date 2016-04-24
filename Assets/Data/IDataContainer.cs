using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Data {
    public interface IDataContainer {
        void Load();
        void Save();
    }
}
