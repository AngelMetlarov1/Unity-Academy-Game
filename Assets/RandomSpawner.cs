using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
private float MinX, MinY, MaxX, MaxY;
private Vector2 pos;
public GameObject[] myGameObjectToRespawn;

    // Start is called before the first frame update
    void Start()
    {
        SetMinAndMax();
        SpawnObj();
    }

    private void SetMinAndMax(){
        Vector2 Bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        MinX = -Bounds.x ;
        MaxX = Bounds.x ;
        MinY = -Bounds.y;
        MaxY = Bounds.y;
    }

    private void SpawnObj(){
        int NumberOfObj = Random.Range(0, myGameObjectToRespawn.Length);
        pos = new Vector2(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
        GameObject obj = Instantiate(myGameObjectToRespawn[NumberOfObj] , pos , Quaternion.identity);
        obj.transform.parent = transform;
    }
}
