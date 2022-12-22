using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float life = 3;
    public int rnd = 0;

    void Awake(){
        Destroy(gameObject, life);
    }

    void OnCollisionEnter2D(Collision2D collision){
        Destroy(collision.gameObject);
        Destroy(gameObject);
        
}}
