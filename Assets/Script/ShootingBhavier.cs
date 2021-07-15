using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBhavier : MonoBehaviour
{
    public Transform shotPos;
    public GameObject projectile;
    private float timeBtwShot;
    public float startTimeBtwShot;

    private void Update()
    {
        if (timeBtwShot <= 0)
        {
            Instantiate(projectile, shotPos.position, Quaternion.identity);
            timeBtwShot = startTimeBtwShot;
        }
        else
        {
            timeBtwShot -= Time.deltaTime;
        }

    }
}
    
