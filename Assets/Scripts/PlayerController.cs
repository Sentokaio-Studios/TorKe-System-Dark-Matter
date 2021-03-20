using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float fwd, bwd, right, left;

    public GameObject bullet;

    public GameObject Player;

    private float cooldown = 5, runningPos = 0.2f, runningNeg = -0.2f;


    private float stealthPos = 0.1f, stealthNeg = -0.1f;

    public bool canShoot;



    public float Life = 250;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;

        fwd = runningPos;
        bwd = runningNeg;
        right = runningPos;
        left = runningNeg;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Forward"))
        {
            this.transform.Translate(0, fwd, 0 * Time.fixedDeltaTime);
        }

        if (Input.GetButton("Backward"))
        {
            this.transform.Translate(0, bwd, 0 * Time.fixedDeltaTime);
        }

        if (Input.GetButton("Right"))
        {
            this.transform.Translate(right, 0, 0 * Time.fixedDeltaTime);
        }

        if (Input.GetButton("Left"))
        {
            this.transform.Translate(left, 0, 0 * Time.fixedDeltaTime);
        }


        if (Input.GetButton("Shoot!") && canShoot == true)
        {
            StartCoroutine("Shoot");
        }




        if (Input.GetButton("Stealth"))
        {
            fwd = stealthPos;
            bwd = stealthNeg;
            right = stealthPos;
            left = stealthNeg;
        }
        else
        {
            fwd = runningPos;
            bwd = runningNeg;
            right = runningPos;
            left = runningNeg;
        }







    }




    IEnumerator Shoot()
    {
        canShoot = false;
        Instantiate(bullet, Player.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(cooldown * Time.deltaTime);
        canShoot = true;
    }



}
