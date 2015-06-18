using Assets.Gnio2D.Tiles.Camera;
using UnityEngine;

namespace Assets.Gnio2D
{
    [ExecuteInEditMode]
    public class Initializer : MonoBehaviour
    {
        void Start()
        {
            if (Camera.main.gameObject.GetComponent<CameraForTiles>() == null)
            {
                Camera.main.gameObject.AddComponent<CameraForTiles>();
            }
        }
    }
}