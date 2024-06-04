using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;

    private float fireCooldown = 0f;

    void Update()
    {
        if (fireCooldown > 0)
        {
            fireCooldown -= Time.deltaTime;
        }

        if (fireCooldown <= 0f)
        {
            fireCooldown = fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
