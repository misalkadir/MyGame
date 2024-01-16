using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kodlar : MonoBehaviour
{
    // Oyun içinde puaný göstermek için kullanýlacak text nesnesid
    public Text puan_text;

    
    void Start()
    {
        puan_text.text = money.puan.ToString();// money deðerini stringe dönüþtürüp puan_text deðiþkenine atar.
    }

    // Oyunu baþlatmak için kullanýlan metot
    public void OyunuBaslat()
    {
        SceneManager.LoadScene(1);// Oyun sahnesi
        money.puan = 0; // Oyun baþladýðýnda puaný sýfýrlar
    }
    // Oyundan çýkmak için kullanýlan metot
    public void OyundanCik()
    {
        Application.Quit();// Uygulamadan çýkýþ yap
    }
    
    public void surebittii()
    {
        SceneManager.LoadScene(0);// Süre bitti sahnesine geçiþ yapar
    }

}
