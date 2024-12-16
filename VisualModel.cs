// Copyright Eric Chauvin 2024.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



// This VisualModel is specific to this app.
// It contains 3D objects specific to this app.



using System;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Media.Imaging;


// namespace



class VisualModel
{
private MainData mData;

private SpaceObject[] spaceObjAr;
private int spaceObjLast = 0;
// private const double scale = 300.0;
private Model3DGroup main3DGroup;

// Objects specific to this app.

private Weights3D weights1;



private VisualModel()
{
}



internal VisualModel( MainData useMainData )
{
mData = useMainData;

main3DGroup = null;

spaceObjAr = new SpaceObject[2];
}



internal void set3DGroup(
                    Model3DGroup use3DGroup )
{
main3DGroup = use3DGroup;
}



internal void setupObjects()
{
if( main3DGroup == null )
  {
  throw new Exception(
      "VisualModel.setupObjects main3DGroup" );
  }

try
{
weights1 = new Weights3D( mData );

// Sun.TextureFileName = "C:\\Eric\\

addSpaceObject( weights1 );

makeNewGeomModels();
}
catch( Exception ) // Except )
  {
  mData.showStatus(
    "Exception VisualModel.setupObjects()." );
  }
}



internal void addSpaceObject(
                        SpaceObject toAdd )
{
spaceObjAr[spaceObjLast] = toAdd;
spaceObjLast++;

int length = spaceObjAr.Length;

if( spaceObjLast >= length )
  {
  Array.Resize( ref spaceObjAr, length + 16 );
  }
}




internal void makeNewGeomModels()
{
if( main3DGroup == null )
  {
  throw new Exception(
           "VisualModel main3DGroup is null." );
  }

main3DGroup.Children.Clear();

int last = spaceObjLast;
for( int count = 0; count < last; count++ )
  {
  spaceObjAr[count].makeNewGeomModel();

  GeometryModel3D geomMod = spaceObjAr[
                    count].getGeometryModel();

  if( geomMod == null )
    continue;

  main3DGroup.Children.Add( geomMod );
  }

// Lights are objects added to the model.
setupAmbientLight();
setupMainLight();
}




/*
  internal void ResetGeometryModels()
    {
    Main3DGroup.Children.Clear();

    for( int Count = 0; Count < SpaceObjectArrayLast; Count++ )
      {
      GeometryModel3D GeoMod = SpaceObjectArray[Count].GetGeometryModel();
      if( GeoMod == null )
        continue;

      Main3DGroup.Children.Add( GeoMod );
      }

    setupAmbientLight();
    setupMainLight();
    }
*/



private void setupMainLight()
{
// Lights are Model3D objects.
// System.Windows.Media.Media3D.Model3D
// System.Windows.Media.Media3D.Light

setupPointLight( 0, // X
                 10, // Y
                 50 ); // Z

}



private void setupPointLight( double X,
                              double Y,
                              double Z )
{
PointLight pLight1 = new PointLight();
pLight1.Color = System.Windows.Media.
                               Colors.White;

Point3D location = new  Point3D( X, Y, Z );
pLight1.Position = location;
pLight1.Range = 10000000.0;

// Attenuation with distance D is like:
// Attenuation = C + L*D + Q*D^2

pLight1.ConstantAttenuation = 1;

    // PLight.LinearAttenuation = 1;
    // PLight.QuadraticAttenuation = 1;

main3DGroup.Children.Add( pLight1 );
}



private void setupAmbientLight()
{
byte RGB = 0x0F;
setupAmbientLightColors( RGB, RGB, RGB );
}



private void setupAmbientLightColors(
                                  byte red,
                                  byte green,
                                  byte blue )
{
try
{
AmbientLight ambiLight = new AmbientLight();
// AmbiLight.Color = System.Windows.
//         Media.Colors.Gray; // AliceBlue

Color ambiColor = new Color();
ambiColor.R = red;
ambiColor.G = green;
ambiColor.B = blue;

ambiLight.Color = ambiColor;

main3DGroup.Children.Add( ambiLight );
}
catch( Exception ) //  Except )
  {
  mData.showStatus(
    "Exception: ThreeDScene.setupAmbientLight()"
    );
  }
}



} // Class


