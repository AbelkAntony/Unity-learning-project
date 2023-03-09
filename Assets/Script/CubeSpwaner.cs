using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpwaner : MonoBehaviour
{
    public GameObject cube;
    public void CreateCube()
    {
        Instantiate(cube, transform.position, Quaternion.identity);
        //Debug.Log(gameObject.name);
        //Destroy(object);
    }
}
