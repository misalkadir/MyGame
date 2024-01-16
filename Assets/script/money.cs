using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    
    public static int puan = 0;// Toplam puan için static deðiþken tanýmladým
    public Text puan_text; // Puanýn texti için public bir Text deðiþkeni tanýmladým
    public AudioSource ses; // Ses dosyasý için public AudioSource deðiþkeni tanýmladým

    // OnTriggerEnter, bu nesne bir baþka nesneyle temas ettiðinde çaðrýlýr
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba")// Eðer temas eden nesnenin adý "Araba" ise
        {
            Destroy(gameObject);// Para nesnesini yok et
            puan += 10;// Puaný 10 arttýr
            ses.PlayOneShot(ses.clip);// Ses dosyasýný çal
        }

        puan_text.text = Convert.ToString(puan);// Puaný ekranda gösteren metni güncelle
    }
}
