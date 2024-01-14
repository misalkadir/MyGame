using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rastgele_Dagıt : MonoBehaviour
{
    public GameObject obje;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++) 
        {
            Instantiate(obje, new Vector3(Random.Range(-50, 50), 1.5f,(Random.Range(-50, 50))), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
