using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnColission : MonoBehaviour
{
    // Araba nesnesi Deathbox nesnesine �arparsa ba�lang��a d�nmesi i�in
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Araba") 
        {
            SceneManager.LoadScene(0);// Ba�lang�� sahnesini y�kle
        }
        
    }
}
