using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float Jumpforce = 0;
    public Rigidbody2D Rb2D;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rb2D.AddForce(transform.up * Jumpforce, ForceMode2D.Impulse);

        }
    }
}
