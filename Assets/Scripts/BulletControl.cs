﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1, 0 * Time.deltaTime);

        StartCoroutine("teste");






    }


    IEnumerator teste()
    {
        yield return new WaitForSeconds(10f * Time.deltaTime);
        Destroy(this.gameObject);
    }
}
