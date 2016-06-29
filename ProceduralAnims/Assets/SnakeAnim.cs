using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeAnim : MonoBehaviour 
{
	public List<GameObject> Bones;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i<Bones.Count;i++)
		{
			float rotY = Mathf.Atan(Mathf.Cos(i*(Mathf.PI/16)+Time.time));
			Bones[i].transform.localRotation = Quaternion.Euler(0.0f,rotY,0.0f);
		}
	}
}
