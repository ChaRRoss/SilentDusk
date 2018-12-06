using UnityEngine;
using System.Collections;

public class Daylight : MonoBehaviour 
{
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.Rotate (Vector3.up * Time.deltaTime * .5);
	}
}
