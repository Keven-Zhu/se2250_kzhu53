using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public float speed;
    public Text Count;

    private Rigidbody body;
    private int c;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        c = 0;
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        body.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.SetActive(false);
            Color objColor = other.GetComponent<MeshRenderer>().material.color;

            if (objColor == Color.yellow)
            {
                c = c + 4;
            }
            else if(objColor == Color.cyan)
            {
                c = c + 3;
            }
            else
            {
                c = c + 2;
            }

            SetCountText();
        }
    }

    void SetCountText()
    {
        Count.text = "Score: " + c.ToString();
    }
}
