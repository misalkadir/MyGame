using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timerkodu : MonoBehaviour
{
    private Text info;// Oyun s�resini g�steren metin
    private float sayac;// Sayac�n ba�lang�� de�eri
    private Slider zaman; // Timer'�n de�erini g�steren slider


    // Bu metot, oyun nesnesi olu�turuldu�unda �a�r�l�r
    private void Awake()
    {
        //Timer Slider'�n� bul ve zaman de�i�kenine at
        zaman = GameObject.Find("Timer").GetComponent<Slider>();
        //"info" tag�na sahip metin nesnesini bul ve info de�i�kenine at
        info = GameObject.FindWithTag("info").GetComponent<Text>();
    }

    // Bu metot, oyun ba�lad���nda �a�r�l�r
    void Start()
    {
        zaman.maxValue = 25;// Timer'�n maksimum de�erini ayarlama
        zaman.minValue = 0; // Timer'�n minimum de�erini ayarlama
        zaman.wholeNumbers = false;// Say�sal de�erlerin tam say� olup olmad���n� belirle
        zaman.value = zaman.maxValue;// Timer'� ba�lang�� de�eriyle ayarla
        sayac = zaman.value;// Sayac� Timer'�n ba�lang�� de�eriyle e�itle
    }

    // Bu metot, her harektte bir �a�r�l�r
    void Update()
    {
        // E�er zaman de�eri minimum de�erden b�y�kse
        if (zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;// Sayac� zaman ge�tik�e azalt
            zaman.value = sayac;// Slider'�  g�ncelle
            info.text = ((int)zaman.value).ToString();// Metni g�ncelle
        }
        else
        {
            SceneManager.LoadScene(2);// S�re bitti sahnesini y�kle
        }
    }
   
      
       
   
}
