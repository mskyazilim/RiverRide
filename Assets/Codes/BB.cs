using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BB : MonoBehaviour
{

   
    public float MermiHiz = 20F;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.up * MermiHiz;
      //   rb.velocity = new Vector2(Vec.x,Vec.y  * MermiHiz);
       //rb.AddForce(new Vector2(0,0 * MermiHiz), ForceMode2D.Impulse);
      //  rb.AddForce(Vector3.forward * MermiHiz, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collider2D other)
    {
       Destroy(gameObject);
    }

}
