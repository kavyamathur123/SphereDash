using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    [SerializeField]
    Vector3 vector;

    [SerializeField]
    KeyCode positive;

    [SerializeField]
    KeyCode negative;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate(){
        if (Input.GetKey(positive))
            GetComponent<Rigidbody>().velocity += vector;
        if (Input.GetKey(negative))
            GetComponent<Rigidbody>().velocity -= vector;
    }
}

