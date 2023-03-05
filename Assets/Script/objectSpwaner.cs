using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpwaner : MonoBehaviour
{
    public GameObject ball;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(ball, transform.position, Quaternion.identity);
		}
	}

	public void CreacteObject()
    {
        Instantiate(ball, transform.position, Quaternion.identity);
    }
    

}
