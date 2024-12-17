using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
	public CubeBehaviour cubeBehaviour;

	void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			cubeBehaviour.RotateClockwise();
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			cubeBehaviour.RotateCounterClockwise();
		}
		else if (Input.GetKey(KeyCode.Space))
		{
			cubeBehaviour.StopRotation();
		}
	}


}
