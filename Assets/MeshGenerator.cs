using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshGenerator : MonoBehaviour {

	public Material mat;

	private float length = 1;
	public int type = 1;
	private Vector3[] vertices = new Vector3[3];
	public GameObject node;


	// Use this for initialization
	void Start ()
	{
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

		GetComponent<MeshRenderer>().material = mat;

		GetComponent<MeshFilter>().mesh = mesh;

		GenerateNodes();
	}

	void GenerateNodes()
	{
		Vector3 position = Vector3.Lerp (vertices [0], vertices [1],0.5f);
		Instantiate (node, position + this.transform.position, Quaternion.identity);

		position = Vector3.Lerp (vertices [1], vertices [2],0.5f);
		Instantiate (node, position + this.transform.position, Quaternion.identity);

		position = Vector3.Lerp (vertices [2], vertices [0],0.5f);
		Instantiate (node, position + this.transform.position, Quaternion.identity);
	}
}
