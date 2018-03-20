using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour 
{
	Color m_MouseOverColor = Color.red;
	Color m_OriginalColor;
	SpriteRenderer m_Renderer;

	private Vector3[] vertices = new Vector3[2];

	// Use this for initialization
	void Start () 
	{
		m_Renderer = GetComponent<SpriteRenderer> ();
		m_OriginalColor = m_Renderer.color;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver()
	{
		m_Renderer.color = m_MouseOverColor;
	}

	void OnMouseExit()
	{
		m_Renderer.color = m_OriginalColor;
	}

	void OnMouseDown()
	{
		Debug.Log ("Node Clicked");
	}
}
