using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public  Vector3 moveForward;
    public  float speed ;
    public Vector3 moveDirection;
    public float monementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveForward * speed *Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
		{
            transform.position += moveDirection * monementSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= moveDirection * monementSpeed;
        }
    }
}
