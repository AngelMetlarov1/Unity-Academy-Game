using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positions
{

    public static float TreeZPosition { get; set; }
}

public class TreeMovement : MonoBehaviour
{

    //Start is called before the first frame update
    void Start()
    {
        Positions.TreeZPosition = transform.position.z;
    }

    //Update is called once per frame
    void Update()
    {
        float keithYPosition = GameObject.Find("Keith").transform.position.y;
        float treeYPosition = (transform.position.y)/10;
        float treeZPosition = Positions.TreeZPosition;
        //print(treeYPosition + " " + treeYPosition / 2);
        if (keithYPosition < treeYPosition/2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, treeZPosition + 1);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,treeZPosition);
        }
    }
}


