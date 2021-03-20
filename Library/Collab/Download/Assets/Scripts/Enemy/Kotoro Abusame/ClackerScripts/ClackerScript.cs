using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClackerScript : MonoBehaviour
{
    public PlayerController player;
    public GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerObject.SetActive(false);
        }
    }
}
