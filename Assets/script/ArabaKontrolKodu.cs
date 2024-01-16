using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaKontrolKodu : MonoBehaviour
{
    // Araba kontrol parametreleri
    private float yatayGiris, dikeyGiris;
    private float guncelDireksiyonAci, guncelFrenGucu;
    private bool frenYapiliyor;

    // Ayarlar
    [SerializeField] private float motorGucu, frenGucu, maxDireksiyonAci;

    // Tekerlek Colliders
    [SerializeField] private WheelCollider solOnTekerlekCollider, sagOnTekerlekCollider;
    [SerializeField] private WheelCollider solArkaTekerlekCollider, sagArkaTekerlekCollider;

    // Tekerleklerin g�r�nen transform halleri
    [SerializeField] private Transform solOnTekerlekTransform, sagOnTekerlekTransform;
    [SerializeField] private Transform solArkaTekerlekTransform, sagArkaTekerlekTransform;

    // Hareket giri�leri
    bool zHareketArti;
    bool zHareketEksi;
    bool xHareketArti;
    bool xHareketEksi;

    // Oyun her fizik ad�m�nda �al��acak olan metot
    private void FixedUpdate()
    {
        // Kullan�c� giri�lerini al ve arac�n kontrol metodlar�n� �a��r
        GirisAl();
        MotoruKontrolEt();
        DireksiyonuKontrolEt();
        TekerlekleriGuncelle();
    }

    // Klavyeden giri�lerini okuyan metot
    private void GirisAl()
    {
        
        zHareketArti = Input.GetKey(KeyCode.W);
        zHareketEksi = Input.GetKey(KeyCode.S);
        xHareketArti = Input.GetKey(KeyCode.D);
        xHareketEksi = Input.GetKey(KeyCode.A);

        // Yatay eksende hareket giri�ini belirle (sa�a veya sola d�nme)
        yatayGiris = Convert.ToInt32(xHareketArti) - Convert.ToInt32(xHareketEksi);

        // Dikey eksende hareket giri�ini belirle (ileri veya geri gitme)
        dikeyGiris = Convert.ToInt32(zHareketArti) - Convert.ToInt32(zHareketEksi);

        // Fren Giri�i
        frenYapiliyor = Input.GetKey(KeyCode.Space);
    }

    // Motor g�c�n� kontrol eden metot
    private void MotoruKontrolEt()
    {
        // Tekerlek motor g��lerini belirle
        solOnTekerlekCollider.motorTorque = dikeyGiris * motorGucu;
        sagOnTekerlekCollider.motorTorque = dikeyGiris * motorGucu;

        // Fren g�c�n� uygula
        guncelFrenGucu = frenYapiliyor ? frenGucu : 0f;
        FrenUygula();
    }
    // Fren uygulayan metot
    private void FrenUygula()
    {
        // Tekerleklerin fren torque'lar�n� belirleme
        sagOnTekerlekCollider.brakeTorque = guncelFrenGucu;
        solOnTekerlekCollider.brakeTorque = guncelFrenGucu;
        solArkaTekerlekCollider.brakeTorque = guncelFrenGucu;
        sagArkaTekerlekCollider.brakeTorque = guncelFrenGucu;
    }
    // Direksiyon a��s�n� kontrol eden metottur.
    private void DireksiyonuKontrolEt()
    {
        // Direksiyon a��s�n� belirler
        guncelDireksiyonAci = maxDireksiyonAci * yatayGiris;

        // Tekerleklerin steerAngle'lar�n� belirle
        solOnTekerlekCollider.steerAngle = guncelDireksiyonAci;
        sagOnTekerlekCollider.steerAngle = guncelDireksiyonAci;
    }
    // Tekerlek transform'lar�n� g�ncelleyen metot
    private void TekerlekleriGuncelle()
    {
        // Her tekerlek i�in g�r�nen ve fiziksel hallerini g�ncelle
        TekerlegiGuncelle(solOnTekerlekCollider, solOnTekerlekTransform);
        TekerlegiGuncelle(sagOnTekerlekCollider, sagOnTekerlekTransform);
        TekerlegiGuncelle(sagArkaTekerlekCollider, sagArkaTekerlekTransform);
        TekerlegiGuncelle(solArkaTekerlekCollider, solArkaTekerlekTransform);
    }

    // Tekerlek transform'unu g�ncelleyen metot
    private void TekerlegiGuncelle(WheelCollider tekerlekCollider, Transform tekerlekTransform)
    {
        // Tekerlek Collider(�arp��t�r�c�)'�n�n d�nya pozisyonunu ve rotasyonunu al, Transform'a uygula (d�n��t�rme)
        Vector3 pozisyon;
        Quaternion rotasyon;
        tekerlekCollider.GetWorldPose(out pozisyon, out rotasyon);
        tekerlekTransform.rotation = rotasyon;
        tekerlekTransform.position = pozisyon;
    }
}
