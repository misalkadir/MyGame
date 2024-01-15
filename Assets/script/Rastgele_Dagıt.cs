using UnityEngine;

public class Rastgele_Dagıt : MonoBehaviour
{
    // Sahnenin rastgele yerlerine dağıtılacak objeyi belirlemek için kullanılan GameObject nesnesi
    public GameObject obje;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 180; i++)
        {
            // Belirlenen objeyi sahnenin rastgele bir konumuna yerleştirme işlemi.
            Instantiate(obje, new Vector3(Random.Range(-200, 200), 1.5f, (Random.Range(-200, 200))), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}