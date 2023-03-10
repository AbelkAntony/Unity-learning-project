using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planeCollition : MonoBehaviour
{
    private int  numberOfCube = 0;
    public CubeSpwaner cube;
    GameObject cubeObject;
    private int randomPosition;
    private bool create;
    public Text text;
    
    private void Start()
    {
        //to get component of 
        cubeObject.GetComponent<CubeSpwaner>();
        //convert 20 to string 
        text.text = $"{20}Game Start";
        //convert int to string and display
        text.text = numberOfCube.ToString();
        //fuction to active and disable game object
        cubeObject.SetActive(true);
    }

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
