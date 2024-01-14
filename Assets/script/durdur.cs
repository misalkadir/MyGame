using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class durdur : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Devam_Ettir;
    [SerializeField] GameObject DURDUR;
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void durudur() 
    {
        Time.timeScale = 0.0f;
        DURDUR.SetActive(false);
        Devam_Ettir.SetActive(true); 

    }
    public void devamettir() 
    {
        Time.timeScale = 1.0f;
        DURDUR.SetActive(true);
        Devam_Ettir.SetActive(false);
    }
}
