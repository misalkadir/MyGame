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
        // Oyunun zaman�n� s�f�ra ayarla, yani oyunu durdur
        Time.timeScale = 0.0f;  
        durdurButonu.SetActive(false); // Durdur butonunu g�r�nmez yap
        devamEttirButonu.SetActive(true); // Devam et butonunu g�r�n�r yap
    }

    public void OyunuDevamEttir() 
    {
        // Oyunun zaman �l�e�ini bir olarak ayarla, yani oyunu devam ettir
        Time.timeScale = 1.0f; 
        durdurButonu.SetActive(true);  // Durdur butonunu g�r�n�r yap
        devamEttirButonu.SetActive(false);  // Devam et butonunu g�r�nmez yap
    }
}
