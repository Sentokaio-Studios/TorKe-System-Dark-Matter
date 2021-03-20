using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float Life;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "bullet")
        {
            Life = Life - 1;
        }

    }




    private void FixedUpdate()
    {
        Life = Mathf.Clamp(Life, 0, 100);

        

    }
}