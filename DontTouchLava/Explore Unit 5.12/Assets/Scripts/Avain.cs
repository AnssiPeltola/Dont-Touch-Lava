using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avain : MonoBehaviour
{
    // Referenssit:
    public GameObject ovi;

    public void OnTriggerEnter(Collider other)
    {
        // Tarkistaa onko other eli kuka osuu niin tag Pelaaja
        if (other.CompareTag("Pelaaja"))
        {
            // Jos oli niin t�m� objekti katoaa
            this.gameObject.SetActive(false);

            // Ja my�s objekti ovi katoaa
            ovi.SetActive(false);
        }
    }
}
