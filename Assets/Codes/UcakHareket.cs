using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UcakHareket : MonoBehaviour
{
    // Start is called before the first frame update
    float Dikey;
    float Yatay;
    Rigidbody2D Rigi;
    AudioSource Ses;
    float UcakHiz=0;
    Vector3 fark;
    Vector3 UcakY;
    float Yatis;
    public GameObject KameraAl;
    public GameObject Puan;

    bool PauseGame = false;
    int Puans=0;
    //public static AudioClip FuelSes, StupidSes;
    public AudioClip[] Sesler;  //Array kullanımı ilginççç

   // private readonly Text RRPuan = GameObject.Find("Canvas/Text").GetComponent<Text>();
    //Ateş etmek için
    Transform FirePoint;
    GameObject Mermi;
    public float MermiHiz;

    void Start()
    {
       
        Rigi = GetComponent<Rigidbody2D>();
      //  Ses = GetComponent<AudioSource>();
        fark = KameraAl.transform.position - transform.position;
     //   FuelSes = Resources.Load<AudioClip>("Fuel");
        FirePoint = transform.Find("FirePoint");
        Mermi = Resources.Load("Mermi") as GameObject;
      
    }

    // Update is called once per frame
    void Update()
    {  
        //Text başıma bela oldu
        Text RRPuan = GameObject.Find("Canvas/Text").GetComponent<Text>(); 

        // Kamera Takip
        UcakY = transform.position + fark;
        KameraAl.transform.position = new Vector3(KameraAl.transform.position.x, UcakY.y,KameraAl.transform.position.z);
        UcakMove();
        
         RRPuan.text = "Puan : " + Puans.ToString();
       
        
       if (Input.GetKeyUp(KeyCode.P))
        {
            
            GetComponent<AudioSource>().PlayOneShot(Sesler[1]);
            if (PauseGame)
            {
                Time.timeScale = 0f; // Pause
                PauseGame = false;
            }
            else
            {
                Time.timeScale = 1f; // Pause
                PauseGame = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }



        if (Input.GetButtonDown("Fire1"))
        {

            //  Debug.Log("ATEŞŞŞŞŞ");
            //  
            GetComponent<AudioSource>().pitch =1;
            GetComponent<AudioSource>().PlayOneShot(Sesler[2]);
                AtesEtmek();
        }
    }

    /// <summary>
    ///  Çarpışma alanı burdannnn   
    ///  bu arada çift tab sevdim...
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag == "F")
        {
            Puans+=5;
            GetComponent<AudioSource>().pitch=1.5F;
            GetComponent<AudioSource>().PlayOneShot(Sesler[0]);
            
          // Ses.PlayOneShot(FuelSes);
           //SesKod.PlaySes("Fuel");
            //  Destroy(collision.gameObject); //çarpılan cisim yok olur
           // Ses.Play();
        }
    }
    void UcakMove()
    {

        Dikey = Input.GetAxis("Vertical");
        if (Dikey > 0)
            UcakHiz = 1;
        else
         if (Dikey < 0)
            UcakHiz = -1;
        else
            UcakHiz = -0.7F;

        Yatay = Input.GetAxis("Horizontal");
       
        if (Yatay>0)
        {
            Yatis = 5;
           Yatay = 0;
            transform.Rotate(new Vector3(0, 1, 0)); 
        }
        else if (Yatay < 0)
        {
            Yatis = -5;
           Yatay = 0;
            transform.Rotate(new Vector3(0, -1, 0));
        } 
        else if (Yatay == 0)
            Yatis = 0;
       // transform.Rotate(new Vector3(0, 0, 0));
        Rigi.AddForce(new Vector3(Yatis, UcakHiz, 0));


    }

    private void AtesEtmek ()
    {

        GameObject m = Instantiate(Mermi, this.gameObject.transform.Find("FirePoint"));

        m.transform.position = FirePoint.transform.position;
        m.transform.rotation = FirePoint.transform.rotation;
         m.GetComponent<Rigidbody2D>().AddForce(transform.forward * MermiHiz, ForceMode2D.Impulse);
      //  m.GetComponent<Rigidbody2D>().AddForce(transform.forward * MermiHiz);

        // Mermi yönü vermek
        Vector3 MermiScale = m.transform.localScale;
        if (transform.localScale.x < 0)  //x y z dikkat
        {
           
            MermiScale.x = -1;
        }
        else
            MermiScale.x = 1;


    }
}
