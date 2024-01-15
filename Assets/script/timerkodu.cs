using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class timerkodu : MonoBehaviour
{
    private Text info;
    private float sayac;
    private Slider zaman;



    private void Awake()
    {
        zaman = GameObject.Find("Timer").GetComponent<Slider>();
        info = GameObject.FindWithTag("info").GetComponent<Text>();
    }

    void Start()
    {
        zaman.maxValue = 120;
        zaman.minValue = 0;
        zaman.wholeNumbers = false;
        zaman.value = zaman.maxValue;
        sayac = zaman.value;
    }

    void Update()
    {
        if (zaman.value > zaman.minValue)
        {
            sayac -= Time.deltaTime;
            zaman.value = sayac;
            info.text = ((int)zaman.value).ToString();
        }
        else
        {

            StartCoroutine(bekle());
            
        }
    }
    IEnumerator bekle()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
       
    }
}
