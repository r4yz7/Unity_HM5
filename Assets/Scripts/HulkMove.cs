using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HulkMove : MonoBehaviour
{
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float right = Input.GetAxis("Horizontal");
        if (right != 0)
        {
            var pos = transform.position;
            pos += Vector3.right * right * Time.deltaTime * 30;
            rigidbody.MovePosition(pos);
        }
        float up = Input.GetAxis("Vertical");
        if(up != 0)
        {
            var pos = transform.position;
            pos += Vector3.up * up * Time.deltaTime * 50;
            rigidbody.MovePosition(pos);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Meat")
        {
            Destroy(collision.gameObject);

        }
        if(collision.tag == "Diamond")
        {
            Destroy(collision.gameObject);
        }
        if (collision.tag == "Wither")
        {
            Destroy(collision.gameObject);
        }
    }
}
