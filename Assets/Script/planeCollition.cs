using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class planeCollition : MonoBehaviour
{
    public CubeSpwaner cube;
    // public GameObject cube;
    void OnCollisionEnter(Collision collision)
    {
       
        //Debug.Log(collision.gameObject.name);
        cube.CreateCube();
        Destroy(collision.gameObject);
        //Instantiate(cube, transform.position, Quaternion.identity);  
    }
}
