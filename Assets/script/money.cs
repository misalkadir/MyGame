using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    public static int puan = 0;
    public Text puan_text;
    public AudioSource ses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "money")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba")
        {
            Destroy(gameObject);
            puan+=10;
            ses.PlayOneShot(ses.clip);
        }
        puan_text.text = Convert.ToString(puan);
    }
}
