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
        Time.timeScale = 0.0f;  // Zamaný durdur
        durdurButonu.SetActive(false);  // Durdur butonunu görünmez yap
        devamEttirButonu.SetActive(true);  // Devam et butonunu görünür yap
    }

    public void OyunuDevamEttir() 
    {
        Time.timeScale = 1.0f;  // Zamaný etkinleþtir
        durdurButonu.SetActive(true);  // Durdur butonunu görünür yap
        devamEttirButonu.SetActive(false);  // Devam et butonunu görünmez yap
    }
}
