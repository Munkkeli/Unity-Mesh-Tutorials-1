using UnityEngine;
using System.Collections;

public class Mesher : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3[] vertices = new Vector3[] {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(1, 1, 0),
            new Vector3(0, 1, 0),
        };

        int[] triangles = new int[] {
            2, 1, 0,
            0, 3, 2,
        };

        Vector2[] uv = new Vector2[] { };

        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;

        GetComponent<MeshFilter>().sharedMesh = mesh;
	}
}
