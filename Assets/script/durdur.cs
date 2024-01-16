using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class durdur : MonoBehaviour
{
    // Oyun Nesneleri
    [SerializeField] GameObject durdurButonu;
    [SerializeField] GameObject devamEttirButonu;
    
     public void OyunuDurdur() 
    {
        // Oyunun zamanýný sýfýra ayarla, yani oyunu durdur
        Time.timeScale = 0.0f;  
        durdurButonu.SetActive(false); // Durdur butonunu görünmez yap
        devamEttirButonu.SetActive(true); // Devam et butonunu görünür yap
    }

    public void OyunuDevamEttir() 
    {
        // Oyunun zaman ölçeðini bir olarak ayarla, yani oyunu devam ettir
        Time.timeScale = 1.0f; 
        durdurButonu.SetActive(true);  // Durdur butonunu görünür yap
        devamEttirButonu.SetActive(false);  // Devam et butonunu görünmez yap
    }
}
