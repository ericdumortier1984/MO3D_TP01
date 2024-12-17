using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
	private bool rotateClockwise = false;
	private bool rotateCounterClockwise = false;

	void Update()
	{
		if (rotateClockwise)
		{
			transform.Rotate(Vector3.up * Time.deltaTime * 100);
		}
		else if (rotateCounterClockwise)
		{
			transform.Rotate(Vector3.down * Time.deltaTime * 100);
		}
	}

	public void RotateClockwise()
	{
		rotateClockwise = true;
		rotateCounterClockwise = false;
	}

	public void RotateCounterClockwise()
	{
		rotateClockwise = false;
		rotateCounterClockwise = true;
	}

	public void StopRotation()
	{
		rotateClockwise = false;
		rotateCounterClockwise = false;
	}
}
