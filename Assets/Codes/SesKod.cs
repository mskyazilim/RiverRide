using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKod : MonoBehaviour
{

    public static AudioClip FuelSes, StupidSes;
    static AudioSource sesAl;
    // Start is called before the first frame update
    void Start()
    {
        FuelSes = Resources.Load<AudioClip>("Sesler/Fuel");
        StupidSes = Resources.Load<AudioClip>("Sesler/Stupid");
        sesAl.GetComponent<AudioSource>();
    }

  

    public static void PlaySes(string sesler)
    {

        switch (sesler)
        {
            case "Fuel": 
                sesAl.PlayOneShot(FuelSes); 
                break;

            case "Stupid":
                sesAl.PlayOneShot(StupidSes);
                break;

            default:
                break;
        }




    }


}
