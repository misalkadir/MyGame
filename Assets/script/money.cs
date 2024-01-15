using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    
    public static int puan = 0;// Toplam puan i�in static de�i�ken tan�mlad�m
    public Text puan_text;// Puan�n texti public class
    public AudioSource ses;// Ses dosyas� i�in public class


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba")//E�er Araba nesnesine dokunuyorsa tetikle
        {
            Destroy(gameObject);// para nesnesini yok et.
            puan += 10;// Puan� 10 artt�r.
            ses.PlayOneShot(ses.clip);// Ses dosyas�n� �al.
        }

        // Puan� ekranda g�steren metni g�ncelle.
        puan_text.text = Convert.ToString(puan);
    }
}
