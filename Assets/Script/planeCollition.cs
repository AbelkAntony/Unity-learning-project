using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class planeCollition : MonoBehaviour
{
    private int  numberOfCube = 0;
    public CubeSpwaner cube;
    private int randomPosition;
    private bool create;
    // public GameObject cube;
    void OnCollisionEnter(Collision collision)
    {
       
        //Debug.Log(collision.gameObject.name);
       
        Destroy(collision.gameObject);
        numberOfCube--;
        //Instantiate(cube, transform.position, Quaternion.identity);  
    }
  /*  void Update()
    {
        
        while (numberOfCube == 0)
        {
            for (int i = 0; i < 5; i++)
            {
                randomPosition = Random.Range(1, 3);
                if (randomPosition == 1)
                {
                    numberOfCube++;
                    cube.CreateCube(i);
                }
            }
        }
    }*/
}
