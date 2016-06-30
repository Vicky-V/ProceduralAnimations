using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeAnim : MonoBehaviour 
{
	public List<GameObject> Bones;
	public float waveFreq=1;
	public float waveHeight=1;
	[Range (0.01f,3)]
	public float speed = 1;

	void Start () 
	{
	
	}

	void Update () 
	{

		float timeStep = Time.time / (1/speed);

		for (int i = 0; i<Bones.Count;i++)
		{
			float rotY = Mathf.Rad2Deg * Mathf.Atan(waveFreq*waveHeight*Mathf.Cos(waveFreq*i-timeStep));
			Bones[i].transform.eulerAngles = new Vector3(0.0f,rotY,0.0f);
		}
	}
}
