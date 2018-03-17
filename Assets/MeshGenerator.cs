using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour {

	public Material mat;

	private float length = 1;
	public int type = 1;

	// Use this for initialization
	void Start ()
	{
		Vector3[] vertices = new Vector3[3];

		if (type == 0)
		{
			vertices [0] = new Vector3 (-length / 2, 0);
			vertices [1] = new Vector3 (-length / 2, length);
			vertices [2] = new Vector3 (length / 2, 0);
		} 
		else if (type == 1) 
		{
			vertices [0] = new Vector3 (-length / 2, 0);
			vertices [1] = new Vector3 (-length / 2, length*Mathf.Tan(30*Mathf.Deg2Rad));
			vertices [2] = new Vector3 (length / 2, 0);
		} 
		else if (type == 2) 
		{
			vertices [0] = new Vector3 (-length / 2, 0);
			vertices [1] = new Vector3 (-length / 2, length*Mathf.Tan(36*Mathf.Deg2Rad));
			vertices [2] = new Vector3 (length / 2, 0);
		}

		Color[] colors = new Color[3];
		for(int i = 0; i < 3 ;i++)
		{
			colors [i] = Color.Lerp (Color.red, Color.green, vertices [i].y);
		}

		Mesh mesh = new Mesh
		{
			vertices = vertices,
			triangles = new int[] {0,1,2},
			colors = colors
		};

		GetComponent<MeshRenderer> ().material = mat;

		GetComponent<MeshFilter> ().mesh = mesh;
	}
}
