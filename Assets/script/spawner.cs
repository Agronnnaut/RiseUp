using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public ballon stat;
    public GameObject[] enemy;
    public float minTime;
    public float maxTime;
    public int check = 1;
    
    void Start()
    {
        
       InvokeRepeating("SpawnEnemy", Random.Range(minTime, maxTime), Random.Range(minTime, maxTime));
        check = 1;
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        Instantiate(enemy[Random.Range(0, enemy.Length)], transform.position, transform.rotation);
        check = stat.status;
    }

    void Update ()
    {


        if (check == 0)
        {
            CancelInvoke();
        }
        if (check == 5)
            Start();
    }
}
