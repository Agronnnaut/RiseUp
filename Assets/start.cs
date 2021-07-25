using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public spawner star, star2;
    public ballon stat;
    public GameObject panel, balon;
    void OnMouseDown()
    {
        panel.SetActive(false);
        stat.status = 1;
        star.check = 5;
        star2.check = 5;

        balon.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
