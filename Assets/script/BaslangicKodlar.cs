using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class kodlar : MonoBehaviour
{
    public Text puan_text;

    // Start is called before the first frame update
    void Start()
    {
        puan_text.text = money.puan.ToString();//money de�erini texte at
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OyunuBaslat()
    {
        SceneManager.LoadScene(1);
        money.puan = 0;
    }

    public void OyundanCik()
    {
        Application.Quit();//oyundan ��kar
    }
    public void oyundon()
    {
        SceneManager.LoadScene(0);//Ba�lang�� ekran�na atar
    }

}
