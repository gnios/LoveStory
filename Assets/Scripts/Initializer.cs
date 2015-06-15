using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Initializer : MonoBehaviour
{
    void Start()
    {
        if (Camera.main.gameObject.GetComponent<ResolutionCameraPixelPerfect>() == null)
        {
            Camera.main.gameObject.AddComponent<ResolutionCameraPixelPerfect>();
        }
    }
}
