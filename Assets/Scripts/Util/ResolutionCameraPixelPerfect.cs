using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ResolutionCameraPixelPerfect : MonoBehaviour
{

    public int width = 640;
    public int height = 480;
    public float unitsPerPixel = 1;
    public PositionPivot positionPivot = PositionPivot.Bottom_Left;
    public int SizeTile = 32;
    void Update()
    {
        ConfigurationCamera();
    }

    private void ConfigurationCamera()
    {
        var camera = this.GetComponent<Camera>();
        camera.orthographicSize = CalculateOrthograficSize(height);
        camera.gameObject.transform.position = new Vector3(CalculatePositionX(), CalculatePositionY(), -10);
    }

    public float CalculateOrthograficSize(int height)
    {
        float orthograficSize = (float)height / unitsPerPixel;
        orthograficSize = orthograficSize / 2;
        return orthograficSize;
    }

    public float CalculatePositionX()
    {
        return (float)width / 2;
    }

    public float CalculatePositionY()
    {
        float positionX = (float)height / 2;
        if (positionPivot == PositionPivot.Top_Left)
        {
            positionX = positionX * -1;
        }
        return positionX;
    }


    public int CalculateAmountVerticalColumns()
    {
        return width / SizeTile;
    }

    public int CalculateAmountHorizontalColumns()
    {
        return height / SizeTile;
    }
}

public enum PositionPivot
{
    Top_Left,
    Bottom_Left
}
