using UnityEngine;

public class Rastgele_Dagıt : MonoBehaviour
{
    // Sahnenin rastgele yerlerine dağıtılacak obje için public değişken oluşturdum.
    public GameObject obje;

    // Bu metot, oyun başladığında çağrılır
    void Start()
    {
        //  180 kez döngü çalıştırılır.
        for (int i = 0; i < 180; i++)
        {
            // Belirlenen objeyi sahnenin rastgele bir konumuna yerleştirme işlemi
            // Random.Range, verilen iki değer arasında rastgele bir sayı üretir
            // Instantiate fonksiyonu, belirtilen objeyi belirtilen konum ve rotasyonla sahneye ekler
            Instantiate(obje, new Vector3(Random.Range(-200, 200), 1.5f, (Random.Range(-200, 200))), Quaternion.identity);
        }

    }

    
}