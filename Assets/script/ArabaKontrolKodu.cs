using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaKontrolKodu : MonoBehaviour
{
    private float yatayGiris, dikeyGiris;
    private float guncelDireksiyonAci, guncelFrenGucu;
    private bool frenYapiliyor;

    // Ayarlar
    [SerializeField] private float motorGucu, frenGucu, maxDireksiyonAci;

    // Tekerlek Colliders
    [SerializeField] private WheelCollider solOnTekerlekCollider, sagOnTekerlekCollider;
    [SerializeField] private WheelCollider solArkaTekerlekCollider, sagArkaTekerlekCollider;

    // Tekerlekler
    [SerializeField] private Transform solOnTekerlekTransform, sagOnTekerlekTransform;
    [SerializeField] private Transform solArkaTekerlekTransform, sagArkaTekerlekTransform;

    bool zHareketArti;
    bool zHareketEksi;
    bool xHareketArti;
    bool xHareketEksi;

    private void FixedUpdate()
    {
        GirisAl();
        MotoruKontrolEt();
        DireksiyonuKontrolEt();
        TekerlekleriGuncelle();
    }

    private void GirisAl()
    {
        
        zHareketArti = Input.GetKey(KeyCode.W);
        zHareketEksi = Input.GetKey(KeyCode.S);
        xHareketArti = Input.GetKey(KeyCode.D);
        xHareketEksi = Input.GetKey(KeyCode.A);

        // Direksiyon Giriþi
        yatayGiris = Convert.ToInt32(xHareketArti) - Convert.ToInt32(xHareketEksi);

        // Hýzlanma Giriþi
        dikeyGiris = Convert.ToInt32(zHareketArti) - Convert.ToInt32(zHareketEksi);

        // Fren Giriþi
        frenYapiliyor = Input.GetKey(KeyCode.Space);
    }

    private void MotoruKontrolEt()
    {
        solOnTekerlekCollider.motorTorque = dikeyGiris * motorGucu;
        sagOnTekerlekCollider.motorTorque = dikeyGiris * motorGucu;
        guncelFrenGucu = frenYapiliyor ? frenGucu : 0f;
        FrenUygula();
    }

    private void FrenUygula()
    {
        sagOnTekerlekCollider.brakeTorque = guncelFrenGucu;
        solOnTekerlekCollider.brakeTorque = guncelFrenGucu;
        solArkaTekerlekCollider.brakeTorque = guncelFrenGucu;
        sagArkaTekerlekCollider.brakeTorque = guncelFrenGucu;
    }

    private void DireksiyonuKontrolEt()
    {
        guncelDireksiyonAci = maxDireksiyonAci * yatayGiris;
        solOnTekerlekCollider.steerAngle = guncelDireksiyonAci;
        sagOnTekerlekCollider.steerAngle = guncelDireksiyonAci;
    }

    private void TekerlekleriGuncelle()
    {
        TekerlegiGuncelle(solOnTekerlekCollider, solOnTekerlekTransform);
        TekerlegiGuncelle(sagOnTekerlekCollider, sagOnTekerlekTransform);
        TekerlegiGuncelle(sagArkaTekerlekCollider, sagArkaTekerlekTransform);
        TekerlegiGuncelle(solArkaTekerlekCollider, solArkaTekerlekTransform);
    }

    private void TekerlegiGuncelle(WheelCollider tekerlekCollider, Transform tekerlekTransform)
    {
        Vector3 pozisyon;
        Quaternion rotasyon;
        tekerlekCollider.GetWorldPose(out pozisyon, out rotasyon);
        tekerlekTransform.rotation = rotasyon;
        tekerlekTransform.position = pozisyon;
    }
}
