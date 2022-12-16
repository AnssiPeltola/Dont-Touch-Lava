using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win : MonoBehaviour
{
    // Referenssit:
    public TextMeshProUGUI maaliLabel;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pelaaja"))
        {
            Destroy(other);
            maaliLabel.text = "Voitit pelin!";
        }
    }
}
