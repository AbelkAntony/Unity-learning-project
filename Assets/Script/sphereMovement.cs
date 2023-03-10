using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += direction * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position -= direction * speed * Time.deltaTime;
        }
    }
}
