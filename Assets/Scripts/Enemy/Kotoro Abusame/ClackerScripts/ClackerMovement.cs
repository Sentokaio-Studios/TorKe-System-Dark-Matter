using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClackerMovement : MonoBehaviour
{
    public GameObject object1, object2;

    public float speed;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        // Calculate direction vector.
        Vector3 dirction = object1.transform.position - object2.transform.position;

        // Normalize resultant vector to unit Vector.
        dirction = -dirction.normalized;

        // Move in the direction of the direction vector every frame.
        object1.transform.position += dirction * Time.deltaTime * speed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
