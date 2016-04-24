using UnityEngine;

using Assets.Data;

namespace Assets {
    public class Global : MonoBehaviour {
        void Load() {
            GlobalData.Container.Load();
        }

        // Use this for initialization
        void Start () {
            this.Load();

            print(GlobalData.Container.Config.GetConfig("longitude"));
        }
	
        // Update is called once per frame
        void Update () {
	
        }
    }
}
