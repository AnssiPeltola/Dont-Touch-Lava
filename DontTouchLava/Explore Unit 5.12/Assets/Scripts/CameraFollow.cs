using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Referenssit:
    public Transform cameraRoot;
    public Transform pelaaja;

    // Update is called once per frame
    void Update()
    {
        // Liikuttaa cameraRoottia kohti pelaajan positiota Lerp-Toiminnin kautta
        cameraRoot.position = Vector3.Lerp(cameraRoot.position, pelaaja.position, 0.05f);
    }
}
