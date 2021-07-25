using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballon : MonoBehaviour
{
    public int status = 1;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            status = 0;
            Debug.Log("You Lose");
        }
    }

    private float score, record = 0;
    public Text scoretext, recordtext;


    void FixedUpdate()
    {
        if (status == 1)
        {
            score++;
            scoretext.text = (score).ToString();

        }
        if (status == 0)
        {
            if (score > record)
            {
                recordtext.text = (score).ToString();
            }
            PlayerLose();
        }
        

    }
    public GameObject panel;
    public GameObject balon;
    void PlayerLose()
    {
        score = 0;
        panel.SetActive(true);
        balon.SetActive(false);

    }



    
}

