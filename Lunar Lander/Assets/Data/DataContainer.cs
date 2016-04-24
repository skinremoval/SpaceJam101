using System;
using System.IO;
using UnityEngine;

using System.Collections.Generic;
namespace Assets.Data {
    public class DataContainer : IDataContainer {
        private readonly Config<object> _config = new Config<object>();
        private readonly History<object> _history = new History<object>();
        private readonly Dictionary<string, string> _paths = new Dictionary<string, string>() {
            { "config", string.Format("{0}/config.dat", Application.persistentDataPath) },
            { "history", string.Format("{0}/history.dat", Application.persistentDataPath) }
        };

        protected void DoLoad() {
            StreamReader sr = null;
            double latitude, longitude;
            try {
                sr = new StreamReader(this._paths["config"]);
                latitude = double.Parse(sr.ReadLine());
                longitude = double.Parse(sr.ReadLine());
                sr.Close();
            } catch (Exception) {
                latitude = 14.0;
                longitude = 121.0;
            }
            this._config.SetConfig("latitude", latitude);
            this._config.SetConfig("longitude", longitude);

            System.Diagnostics.Debug.Assert(sr != null, "sr != null");
            sr.Close();
            this.Save();
        }

        protected void DoSave() {
            var sw = new StreamWriter(this._paths["config"]);

            sw.WriteLine(this._config.GetConfig("latitude"));
            sw.WriteLine(this._config.GetConfig("longitude"));

            sw.Close();
        }

        public Config<object> Config { get { return this._config; } }
        public History<object> History { get { return this._history; } }  

        public void Load() { this.DoLoad(); }

        public void Save() { this.DoSave(); }
    }

    public static class GlobalData {
        public static readonly DataContainer Container = new DataContainer();
    }
}
