using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerLevel : MonoBehaviour
{
    public int sceneValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene(sceneValue);
            }
        }
    }
}
