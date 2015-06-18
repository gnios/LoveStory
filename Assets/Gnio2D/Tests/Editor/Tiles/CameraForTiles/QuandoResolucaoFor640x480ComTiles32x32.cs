using UnityEngine;
using System.Collections;
using NUnit.Framework;
using Assets.Gnio2D.Tiles.Camera;

[TestFixture]
public class QuandoResolucaoFor640x480ComTiles32x32
{
    public CameraForTiles resolutionCamera;
    int width = 640;
    int height = 480;
    int sizeTile = 32;
    [TestFixtureSetUp]
    public void Initialize()
    {
        resolutionCamera = new CameraForTiles();
        resolutionCamera.width = width;
        resolutionCamera.height = height;
        resolutionCamera.SizeTile = sizeTile;
    }
    
    [Test]
    public void OrtograficSizeDeveSer240()
    {
        float othograficSizeCorrect = resolutionCamera.CalculateOrthograficSize(height);
        Assert.AreEqual(othograficSizeCorrect, 240f);
    }

    [Test]
    public void PosicaoXCameraDeveSer320()
    {
        float posX = resolutionCamera.CalculatePositionX();
        Assert.AreEqual(posX, 320f);
    }

    [Test]
    public void PosicaoYCameraDeveSer240QuandoPivotIgualBottomLeft()
    {
        resolutionCamera.positionPivot = PositionPivot.Bottom_Left;
        float posY = resolutionCamera.CalculatePositionY();
        Assert.AreEqual(posY, 240f);
    }

    [Test]
    public void PosicaoYCameraDeveSerMenos240QuandoPivotIgualTopLeft()
    {
        resolutionCamera.positionPivot = PositionPivot.Top_Left;
        float posY = resolutionCamera.CalculatePositionY();
        Assert.AreEqual(posY, -240f);
    }

    [Test]
    public void DeveraExistir20ColunasVerticais()
    {
        var colunasVerticais = resolutionCamera.CalculateAmountVerticalColumns();
        Assert.AreEqual(colunasVerticais, 20);
    }

    [Test]
    public void DeveraExistir15ColunasHorizontais()
    {
        var colunasVerticais = resolutionCamera.CalculateAmountHorizontalColumns();
        Assert.AreEqual(colunasVerticais, 15);
    }

}
