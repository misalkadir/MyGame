using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class durdur : MonoBehaviour
{
    [SerializeField] GameObject durdurButonu;
    [SerializeField] GameObject devamEttirButonu;
    
     public void OyunuDurdur() 
    {
        Time.timeScale = 0.0f;  // Zaman� durdur
        durdurButonu.SetActive(false);  // Durdur butonunu g�r�nmez yap
        devamEttirButonu.SetActive(true);  // Devam et butonunu g�r�n�r yap
    }

    public void OyunuDevamEttir() 
    {
        Time.timeScale = 1.0f;  // Zaman� etkinle�tir
        durdurButonu.SetActive(true);  // Durdur butonunu g�r�n�r yap
        devamEttirButonu.SetActive(false);  // Devam et butonunu g�r�nmez yap
    }
}
