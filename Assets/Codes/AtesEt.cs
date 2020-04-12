using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{

    Rigidbody2D MermiBody;
    public float MermiHiz;
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

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        

    }
}
