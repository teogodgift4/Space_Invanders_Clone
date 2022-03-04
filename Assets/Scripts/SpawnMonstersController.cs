using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersController : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float interval = 3;

    private void SpawnMonster()
    {
        float myRan = Random.value;

        if(myRan < 0.2)
        {
            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if(myRan < 0.4)
        {
            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);
        }
        else
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
