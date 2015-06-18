using UnityEngine;

namespace Assets.Gnio2D.Tiles.Camera
{
    using Camera = UnityEngine.Camera;

    [ExecuteInEditMode]
    public class CameraForTiles : MonoBehaviour
    {

        public int width = 640;
        public int height = 480;
        public float unitsPerPixel = 1;
        public PositionPivot positionPivot = PositionPivot.Bottom_Left;
        public int SizeTile = 32;
        void Update()
        {
            this.ConfigurationCamera();
        }

        private void ConfigurationCamera()
        {
            var camera = this.GetComponent<Camera>();
            camera.orthographicSize = this.CalculateOrthograficSize(this.height);
            camera.gameObject.transform.position = new Vector3(this.CalculatePositionX(), this.CalculatePositionY(), -10);
        }

        public float CalculateOrthograficSize(int height)
        {
            float orthograficSize = (float)height / this.unitsPerPixel;
            orthograficSize = orthograficSize / 2;
            return orthograficSize;
        }

        public float CalculatePositionX()
        {
            return (float)this.width / 2;
        }

        public float CalculatePositionY()
        {
            float positionX = (float)this.height / 2;
            if (this.positionPivot == PositionPivot.Top_Left)
            {
                positionX = positionX * -1;
            }
            return positionX;
        }


        public int CalculateAmountVerticalColumns()
        {
            return this.width / this.SizeTile;
        }

        public int CalculateAmountHorizontalColumns()
        {
            return this.height / this.SizeTile;
        }
    }
}