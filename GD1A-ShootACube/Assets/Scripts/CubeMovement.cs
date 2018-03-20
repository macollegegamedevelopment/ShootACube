using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour 
{
    public float movementSpeed = 1;

	private void Update()
	{
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
	}
}
