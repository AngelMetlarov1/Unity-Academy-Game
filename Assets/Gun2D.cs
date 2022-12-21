using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2D : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public GameObject bulletPrefabLeft;
    public GameObject bulletPrefabUp;
    public GameObject bulletPrefabDown;
    public float bulletSpeed = 100;

    void Update(){
        if(Input.GetKeyDown("i")){
        var bullet = Instantiate(bulletPrefabUp, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * (Time.fixedDeltaTime * 100);
    }
    if(Input.GetKeyDown("l")){
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * (Time.fixedDeltaTime * 100);
    }
    if(Input.GetKeyDown("j")){
        var bullet = Instantiate(bulletPrefabLeft, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = -bulletSpawnPoint.right *(Time.fixedDeltaTime * 100);
    }
    if(Input.GetKeyDown("k")){
        var bullet = Instantiate(bulletPrefabDown, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = -bulletSpawnPoint.up * (Time.fixedDeltaTime * 100);
    }
    }
    
}
