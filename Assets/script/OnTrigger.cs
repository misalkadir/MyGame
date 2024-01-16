using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnColission : MonoBehaviour
{
    // Araba nesnesi Deathbox nesnesine çarparsa baþlangýça dönmesi için
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba") 
        {
            SceneManager.LoadScene(0);// Baþlangýç sahnesini yükle
        }
        
    }
}
