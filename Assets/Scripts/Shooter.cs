using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; //close line ;
    public float bulletForce; //close line ;
    public Transform bulletSpawnPosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);

            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletForce); //changed transform.up to transform.forward

            Destroy(bullet, 3f); //changed .25f to 3f
        }
    }
}
