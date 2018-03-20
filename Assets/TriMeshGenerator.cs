using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriMeshGenerator : Singleton<TriMeshGenerator> {

	//Prefab to add mesh to and instantiate.
	public GameObject TriangleObject;
	//Prefab added to each side of mesh.
	GameObject NodeObject;
	//Prefab added to construct new mesh.
	GameObject ConstructorNodeObject;

	public Material mat;


	// Use this for initialization
	void Start () 
	{
		CreateMesh (new Vector4(0,0,0,0),new Vector4(1,1,0,0),new Vector4(1,0,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CreateMesh(Vector3 vertex1,Vector3 vertex2, Vector3 vertex3)
	{
		Vector3[] vertices = new Vector3[3];
		vertices [0] = vertex1;
		vertices [1] = vertex2;
		vertices [2] = vertex3;

		Color32[] colors = new Color32[3];
		colors [0] = new Color (1, 0.5f, 0, 1);
		colors [1] = new Color (1, 0.5f, 0, 1);
		colors [2] = new Color (1, 0.5f, 0, 1);

		Mesh mesh = new Mesh
		{
			vertices = vertices,
			triangles = new int[] {0,1,2},
			colors32 = colors
		};
				
		TriangleObject.GetComponent<MeshRenderer>().material = mat;
		TriangleObject.GetComponent<MeshFilter> ().mesh = mesh;

		Instantiate (TriangleObject);
	}
}
