using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silahlar : MonoBehaviour
{
    public Transform Fp;
    public GameObject mermiPre;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("Fire1"))
        {


            Shoot();

            Invoke("AtesYokolsun", 5);


        }
    }
    void AtesYokolsun()
    {

        Destroy(gameObject);
    }
    void Shoot()

    {
        Instantiate(mermiPre, Fp.position, Fp.rotation);


    }
}
