using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Data {
    public class Config<T> : IConfig<T> {
        private readonly Dictionary<string, T> _config = new Dictionary<string, T>();

        public void SetConfig(string key, T value) { this._config[key] = value; }

        public T GetConfig(string key) {
            var value = this._config[key];
            if (value == null) {
                throw new Exception(string.Format("Key \"{0}\" not found in config.", key));                
            }
            return value;
        }
    }
}
