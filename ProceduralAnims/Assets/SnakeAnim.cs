using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeAnim : MonoBehaviour 
{
	public List<GameObject> Bones;
	public float waveFreq=1;
	public float waveHeight=1;

	void Start () 
	{
	
	}

	void Update () 
	{
		for (int i = 0; i<Bones.Count;i++)
		{
			float rotY = Mathf.Rad2Deg * Mathf.Atan(waveFreq*waveHeight*Mathf.Cos(waveFreq*i+Time.time));
			Bones[i].transform.eulerAngles = new Vector3(0.0f,rotY,0.0f);
		}
	}
}
