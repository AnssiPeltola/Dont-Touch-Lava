using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //referenssit:
    public Transform spawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pelaaja"))
        {
            // Siirt‰‰ pallon takaisin spawnPointille eli alkuun
            collision.transform.position = spawnPoint.position;

            // Laukaise DeathCounterin OnPelaaKuoli() Methodin
            DeathCounter.instance.OnPelaajaKuoli();
        }
    }
}
