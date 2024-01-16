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

    // Tekerleklerin görünen transform halleri
    [SerializeField] private Transform solOnTekerlekTransform, sagOnTekerlekTransform;
    [SerializeField] private Transform solArkaTekerlekTransform, sagArkaTekerlekTransform;

    // Hareket giriþleri
    bool zHareketArti;
    bool zHareketEksi;
    bool xHareketArti;
    bool xHareketEksi;

    // Oyun her fizik adýmýnda çalýþacak olan metot
    private void FixedUpdate()
    {
        // Kullanýcý giriþlerini al ve aracýn kontrol metodlarýný çaðýr
        GirisAl();
        MotoruKontrolEt();
        DireksiyonuKontrolEt();
        TekerlekleriGuncelle();
    }

    // Klavyeden giriþlerini okuyan metot
    private void GirisAl()
    {
        
        zHareketArti = Input.GetKey(KeyCode.W);
        zHareketEksi = Input.GetKey(KeyCode.S);
        xHareketArti = Input.GetKey(KeyCode.D);
        xHareketEksi = Input.GetKey(KeyCode.A);

        // Yatay eksende hareket giriþini belirle (saða veya sola dönme)
        yatayGiris = Convert.ToInt32(xHareketArti) - Convert.ToInt32(xHareketEksi);

        // Dikey eksende hareket giriþini belirle (ileri veya geri gitme)
        dikeyGiris = Convert.ToInt32(zHareketArti) - Convert.ToInt32(zHareketEksi);

        // Fren Giriþi
        frenYapiliyor = Input.GetKey(KeyCode.Space);
    }

    // Motor gücünü kontrol eden metot
    private void MotoruKontrolEt()
    {
        // Tekerlek motor güçlerini belirle
        solOnTekerlekCollider.motorTorque = dikeyGiris * motorGucu;
        sagOnTekerlekCollider.motorTorque = dikeyGiris * motorGucu;

        // Fren gücünü uygula
        guncelFrenGucu = frenYapiliyor ? frenGucu : 0f;
        FrenUygula();
    }
    // Fren uygulayan metot
    private void FrenUygula()
    {
        // Tekerleklerin fren torque'larýný belirleme
        sagOnTekerlekCollider.brakeTorque = guncelFrenGucu;
        solOnTekerlekCollider.brakeTorque = guncelFrenGucu;
        solArkaTekerlekCollider.brakeTorque = guncelFrenGucu;
        sagArkaTekerlekCollider.brakeTorque = guncelFrenGucu;
    }
    // Direksiyon açýsýný kontrol eden metottur.
    private void DireksiyonuKontrolEt()
    {
        // Direksiyon açýsýný belirler
        guncelDireksiyonAci = maxDireksiyonAci * yatayGiris;

        // Tekerleklerin steerAngle'larýný belirle
        solOnTekerlekCollider.steerAngle = guncelDireksiyonAci;
        sagOnTekerlekCollider.steerAngle = guncelDireksiyonAci;
    }
    // Tekerlek transform'larýný güncelleyen metot
    private void TekerlekleriGuncelle()
    {
        // Her tekerlek için görünen ve fiziksel hallerini güncelle
        TekerlegiGuncelle(solOnTekerlekCollider, solOnTekerlekTransform);
        TekerlegiGuncelle(sagOnTekerlekCollider, sagOnTekerlekTransform);
        TekerlegiGuncelle(sagArkaTekerlekCollider, sagArkaTekerlekTransform);
        TekerlegiGuncelle(solArkaTekerlekCollider, solArkaTekerlekTransform);
    }

    // Tekerlek transform'unu güncelleyen metot
    private void TekerlegiGuncelle(WheelCollider tekerlekCollider, Transform tekerlekTransform)
    {
        // Tekerlek Collider(Çarpýþtýrýcý)'ýnýn dünya pozisyonunu ve rotasyonunu al, Transform'a uygula (dönüþtürme)
        Vector3 pozisyon;
        Quaternion rotasyon;
        tekerlekCollider.GetWorldPose(out pozisyon, out rotasyon);
        tekerlekTransform.rotation = rotasyon;
        tekerlekTransform.position = pozisyon;
    }
}
