using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour
{
    //GameObject, kas uzglabā visus velkamos objektus
    public GameObject atkritumuMasina;
    public GameObject atroMasina;
    public GameObject autobuss;
    public GameObject b2;
    public GameObject cements;
    public GameObject e46;
    public GameObject eskavators;
    public GameObject policija;
    public GameObject traktors;
    public GameObject traktors2;
    public GameObject ugunsdzesejs;

    /*Uzglabās velkamo objektu sākotnējās pozīcijas
    koordinātas (lai zinātu, kur aizmest objektu, ja tas nolikts nepareizajā vietā)*/
    //Objekti paliek Public, taču paslēpj no Inspector loga
    [HideInInspector]
    public Vector2 atkrKoord;
    [HideInInspector]
    public Vector2 atroKoord;
    [HideInInspector]
    public Vector2 bussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 cementKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 policijaKoord;
    [HideInInspector]
    public Vector2 traktorKoord;
    [HideInInspector]
    public Vector2 traktor2Koord;
    [HideInInspector]
    public Vector2 ugunsdzesejsKoord;
    [HideInInspector]
    public Vector2 eskavatorKoord;
    //Uzglabās ainā esošo kanvu
    public Canvas kanva;
    //Uzglabās skaņas avotu, kurā atskaņot audio failu
    public AudioSource skanasAvots;
    //Masīvs, kas uzglabās visas skaņas
    public AudioClip[] skanaKoAtskanot;
    //Uzglabās objektu, kurš ir pēdējais pārvietotais
    [HideInInspector]
    public GameObject pedejaisVilktais = null;
    //Mainīgais atbild par to vai objekts ir nolikts pareizi vai nepareizi
    [HideInInspector]
    public bool vaiIstajaVieta = false;

    //Funkcija nostrādā tiklīdz nospiesta play poga
    private void Awake()
    {
        atkrKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        atroKoord = atroMasina.GetComponent<RectTransform>().localPosition;
        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;
        b2Koord = b2.GetComponent<RectTransform>().localPosition;
        cementKoord = cements.GetComponent<RectTransform>().localPosition;
        e46Koord = e46.GetComponent<RectTransform>().localPosition;
        policijaKoord = policija.GetComponent<RectTransform>().localPosition;
        traktorKoord = traktors.GetComponent<RectTransform>().localPosition;
        traktor2Koord = traktors2.GetComponent<RectTransform>().localPosition;
        ugunsdzesejsKoord = ugunsdzesejs.GetComponent<RectTransform>().localPosition;
        eskavatorKoord = eskavators.GetComponent<RectTransform>().localPosition;
    }
}
