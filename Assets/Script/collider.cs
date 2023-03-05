using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public objectSpwaner ball;

	private void OnCollisionEnter(Collision collision)
	{
		ball.CreacteObject();
		Destroy(collision.gameObject);
	}
}
