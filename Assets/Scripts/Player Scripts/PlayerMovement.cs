using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public float speed = 5.0f;
    // Use this for initialization
    void Start()
    {

        // _rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        //float move = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
    }



}
