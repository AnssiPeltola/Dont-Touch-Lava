using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelaajaControl : MonoBehaviour
{
    // Referenssit:
    public Rigidbody pelaajaRB;
    public float speed = 3f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

       pelaajaRB.velocity = new Vector3(movementHorizontal * speed, -3f, movementVertical * speed);
    }
}
