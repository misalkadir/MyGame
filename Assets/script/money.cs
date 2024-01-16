using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    
    public static int puan = 0;// Toplam puan i�in static de�i�ken tan�mlad�m
    public Text puan_text; // Puan�n texti i�in public bir Text de�i�keni tan�mlad�m
    public AudioSource ses; // Ses dosyas� i�in public AudioSource de�i�keni tan�mlad�m

    // OnTriggerEnter, bu nesne bir ba�ka nesneyle temas etti�inde �a�r�l�r
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba")// E�er temas eden nesnenin ad� "Araba" ise
        {
            Destroy(gameObject);// Para nesnesini yok et
            puan += 10;// Puan� 10 artt�r
            ses.PlayOneShot(ses.clip);// Ses dosyas�n� �al
        }

        puan_text.text = Convert.ToString(puan);// Puan� ekranda g�steren metni g�ncelle
    }
}
