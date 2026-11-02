using System.CodeDom.Compiler;
using UnityEngine;

public class MeshGeneration : MonoBehaviour
{

    Mesh mesh;
    

    private void Awake() {
        mesh = new Mesh();
        mesh.name = "MyQuad";
        GetComponent<MeshFilter>().sharedMesh = mesh;
        Generate();
    }

    void Generate() {
       Vector3[] vertices = new Vector3[] {

        ////bottom
        //new Vector3(1,0,1),
        //new Vector3(1,1,0),
        //new Vector3(0,1,1),

        //new Vector3(-1,0,1),
        //new Vector3(-1,1,0),
        //new Vector3(0,1,1),

        //new Vector3(1,0,-1),
        //new Vector3(1,1,0),
        //new Vector3(0,1,-1),

        //new Vector3(-1,0,-1),
        //new Vector3(-1,1,0),
        //new Vector3(0,1,-1),
        //.....................


        //top
        new Vector3(1,0,1),
        new Vector3(-1,0,1),
        new Vector3(1,0,-1),
        new Vector3(-1,0,-1),
        //front
        new Vector3(1,1,0),
        new Vector3(-1,1,0),
        new Vector3(1,1,0),
        new Vector3(-1,1,0),
        //Left
        new Vector3(0,1,1),
        new Vector3(0,1,1),
        new Vector3(0,1,-1),
        new Vector3(0,1,-1),

        // .............................
        //new Vector3(1,0,1),
        //new Vector3(1,-1,0),
        //new Vector3(0,-1,1),

        //new Vector3(-1,0,1),
        //new Vector3(-1,-1,0),
        //new Vector3(0,-1,1),

        //new Vector3(1,0,-1),
        //new Vector3(1,-1,0),
        //new Vector3(0,-1,-1),

        //new Vector3(-1,0,-1),
        //new Vector3(-1,-1,0),
        //new Vector3(0,-1,-1),
   // ........................................
   // bottom
       new Vector3(1,0,1),
       new Vector3(-1,0,1),
       new Vector3(1,0,-1),
       new Vector3(-1,0,-1),
       // back
       new Vector3(1,-1,0),
       new Vector3(-1,-1,0),
       new Vector3(1,-1,0),
       new Vector3(-1,-1,0),
       //right
       new Vector3(0,-1,1),
       new Vector3(0,-1,1),
       new Vector3(0,-1,-1),
       new Vector3(0,-1,-1),
       };

    Vector3[] normals = new Vector3[] {

        //new Vector3(1,0,0),
        //new Vector3(0,1,0),
        //new Vector3(0,0,1),
        //new Vector3(-1,0,0),
        //new Vector3(0,-1,0),
        //new Vector3(0,0,-1),

        //new Vector3(1,0,0),
        //new Vector3(0,1,0),
        //new Vector3(0,0,1),
        //new Vector3(-1,0,0),
        //new Vector3(0,-1,0),
        //new Vector3(0,0,-1),

        //new Vector3(1,0,0),
        //new Vector3(0,1,0),
        //new Vector3(0,0,1),
        //new Vector3(-1,0,0),
        //new Vector3(0,-1,0),
        //new Vector3(0,0,-1),

        //new Vector3(1,0,0),
        //new Vector3(0,1,0),
        //new Vector3(0,0,1),
        //new Vector3(-1,0,0),
        //new Vector3(0,-1,0),
        //new Vector3(0,0,-1),
        // ...................
        
        //top
        new Vector3(0,1,0),
        new Vector3(0,1,0),
        new Vector3(0,1,0),
        new Vector3(0,1,0),

        new Vector3(0,0,1),
        new Vector3(0,0,1),
        new Vector3(0,0,1),
        new Vector3(0,0,1),

        new Vector3(-1,0,0),
        new Vector3(-1,0,0),
        new Vector3(-1,0,0),
        new Vector3(-1,0,0),
        
        new Vector3(0,-1,0),
        new Vector3(0,-1,0),
        new Vector3(0,-1,0),
        new Vector3(0,-1,0),
        
        new Vector3(0,0,-1),
        new Vector3(0,0,-1),
        new Vector3(0,0,-1),
        new Vector3(0,0,-1),

        new Vector3(1,0,0),
        new Vector3(1,0,0),
        new Vector3(1,0,0),
        new Vector3(1,0,0),

        

        
        // .....................................
        

        
    };

    Vector2[] uvs = new Vector2[] {
       // top
        new Vector2(0,1),
        new Vector2(0,0),
        new Vector2(1,1),
        new Vector2(1,0),
       //// bottom
        new Vector2(0,1),
        new Vector2(0,0),
        new Vector2(1,1),
        new Vector2(1,0),

        new Vector2(0,1),
        new Vector2(0,0),
        new Vector2(1,1),
        new Vector2(1,0),
       //// bottom
        new Vector2(0,1),
        new Vector2(0,0),
        new Vector2(1,1),
        new Vector2(1,0),

        new Vector2(0,1),
        new Vector2(0,0),
        new Vector2(1,1),
        new Vector2(1,0),
       //// bottom
        new Vector2(0,1),
        new Vector2(0,0),
        new Vector2(1,1),
        new Vector2(1,0)
    };

    int[] triahngle = new int[] {
        0,1,2, // top
        0,2,3, // top
        0,3,7, // front
        0,7,4, // front
        0,4,5, // left
        0,5,1, // left
        4,6,5, // bottom
        4,7,6, // bottom
        2,1,5, // back
        2,5,6, // back
        3,2,6, // right
        3,6,7  // right
    }; 
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.uv = uvs;
        mesh.triangles = triahngle;
    }

    //vertex colours
    //Color[] colors = new Color[4];
    //float offset = Time.time - speed;
    //colors[0] = ColorFromHue( 0 + offset );
    //colors[1] = ColorFromHue( 90 + offset );
    //colors[2] = ColorFromHue( 180 + offset );
    //colors[2] = ColorFromHue( 270 + offset );

}
