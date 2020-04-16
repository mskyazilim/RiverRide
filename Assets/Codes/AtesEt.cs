using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{
    Vector2 Vec;
    Rigidbody2D rb;
   // public GameObject Mermi;
    public float MermiHiz;
    public Transform MermiYeri;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
            // GameObject ins_mermi = Instantiate(Mermi, MermiYeri.position, MermiYeri.rotation) as GameObject;
      //      rb.velocity = new Vector2(Vec.x,Vec.y* MermiHiz*5* Time.deltaTime);



    }


    void Shot()
    {


    }

    /*
    // Start is called before the first frame update
    void Start()
    {
        MermiBody = GetComponent<Rigidbody2D>();
        // MermiBody.AddForce(Vector3.forward * MermiHiz,ForceMode2D.Impulse);
        MermiBody.AddForce(new Vector2(MermiHiz, 0), ForceMode2D.Impulse);
        Invoke("AtesYokolsun", 5);

    }
    void AtesYokolsun()
    {

        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {


    }
    */
}
