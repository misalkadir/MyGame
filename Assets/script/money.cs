using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    
    public static int puan = 0;// Toplam puan için static deðiþken tanýmladým
    public Text puan_text;// Puanýn texti public class
    public AudioSource ses;// Ses dosyasý için public class


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba")//Eðer Araba nesnesine dokunuyorsa tetikle
        {
            Destroy(gameObject);// para nesnesini yok et.
            puan += 10;// Puaný 10 arttýr.
            ses.PlayOneShot(ses.clip);// Ses dosyasýný çal.
        }

        // Puaný ekranda gösteren metni güncelle.
        puan_text.text = Convert.ToString(puan);
    }
}
