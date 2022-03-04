using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public float invoke = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootBullet", 5.0f, invoke);
    }

    public void shootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
