using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KierreEste : MonoBehaviour
{
    public Rigidbody este;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        if (este == null)
        {
            este = this.GetComponent<Rigidbody>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        este.angularVelocity = new Vector3(0f, speed, 0f);
    }
}
