using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpwaner : MonoBehaviour
{
    public Vector3 location;
    public GameObject cube;
    public int dropTime;
    private float timePeriod;
    private int randomPosition;
    void ResetTimeToDrop()
    {
        timePeriod = Time.time + dropTime;
    }
    public void CreateCube()
    {
       // for(int i=1;i<=5;i++)
      //  {
            //Instantiate(cube, location *(i* 10) , Quaternion.identity);
      //  }
        //Instantiate(cube, transform.position, Quaternion.identity);
        //Debug.Log(gameObject.name);
        //Destroy(object);

    }
    void Start()
    {
        ResetTimeToDrop();
    }
    void Update()
    {
        if(Time.time > timePeriod)
        {
            for (int i = 1; i <= 5; i++)
            {
                randomPosition = Random.Range(1, 3);
                if (randomPosition == 1)
                {
                    Instantiate(cube, location * (i * 10), Quaternion.identity);
                }
                
            }
                ResetTimeToDrop();
        }
    }
};
