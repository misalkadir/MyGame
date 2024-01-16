using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timerkodu : MonoBehaviour
{
    private Text info;// Oyun süresini gösteren metin
    private float sayac;// Sayacýn baþlangýç deðeri
    private Slider zaman; // Timer'ýn deðerini gösteren slider


    // Bu metot, oyun nesnesi oluþturulduðunda çaðrýlýr
    private void Awake()
    {
        //Timer Slider'ýný bul ve zaman deðiþkenine at
        zaman = GameObject.Find("Timer").GetComponent<Slider>();
        //"info" tagýna sahip metin nesnesini bul ve info deðiþkenine at
        info = GameObject.FindWithTag("info").GetComponent<Text>();
    }

    // Bu metot, oyun baþladýðýnda çaðrýlýr
    void Start()
    {
        zaman.maxValue = 25;// Timer'ýn maksimum deðerini ayarlama
        zaman.minValue = 0; // Timer'ýn minimum deðerini ayarlama
        zaman.wholeNumbers = false;// Sayýsal deðerlerin tam sayý olup olmadýðýný belirle
        zaman.value = zaman.maxValue;// Timer'ý baþlangýç deðeriyle ayarla
        sayac = zaman.value;// Sayacý Timer'ýn baþlangýç deðeriyle eþitle
    }

    // Bu metot, her harektte bir çaðrýlýr
    void Update()
    {
        // Eðer zaman deðeri minimum deðerden büyükse
        if (zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;// Sayacý zaman geçtikçe azalt
            zaman.value = sayac;// Slider'ý  güncelle
            info.text = ((int)zaman.value).ToString();// Metni güncelle
        }
        else
        {
            SceneManager.LoadScene(2);// Süre bitti sahnesini yükle
        }
    }
   
      
       
   
}
