using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kodlar : MonoBehaviour
{
    // Oyun i�inde puan� g�stermek i�in kullan�lacak text nesnesid
    public Text puan_text;

    
    void Start()
    {
        puan_text.text = money.puan.ToString();// money de�erini stringe d�n��t�r�p puan_text de�i�kenine atar.
    }

    // Oyunu ba�latmak i�in kullan�lan metot
    public void OyunuBaslat()
    {
        SceneManager.LoadScene(1);// Oyun sahnesi
        money.puan = 0; // Oyun ba�lad���nda puan� s�f�rlar
    }
    // Oyundan ��kmak i�in kullan�lan metot
    public void OyundanCik()
    {
        Application.Quit();// Uygulamadan ��k�� yap
    }
    
    public void surebittii()
    {
        SceneManager.LoadScene(0);// S�re bitti sahnesine ge�i� yapar
    }

}
