using UnityEngine;
using UnityEngine.UI;

namespace Assets {
    public class CameraController : MonoBehaviour {
        private WebCamTexture _mCamera = null;
        private RawImage _image;
        private GameObject _canvas;

        // Use this for initialization
        void Start() {
            Debug.Log("Script has been started");
            this._canvas = GameObject.FindWithTag("Canvas");

            this._image = this._canvas.GetComponentInChildren<RawImage>();

            this._mCamera = new WebCamTexture();
            
            this._image.texture = this._mCamera;
            this._mCamera.Play();
        }

        // Update is called once per frame
        void Update() {
            this._image.texture = this._mCamera;
        }
    }
}