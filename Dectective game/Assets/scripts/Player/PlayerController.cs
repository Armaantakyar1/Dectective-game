using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Rigidbody2D rb;

    [SerializeField] KeyCode right;
    [SerializeField] KeyCode left;
    [SerializeField] KeyCode up;
    [SerializeField] KeyCode down;

    
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(right))
        {
            horizontal = 1f;
        }
        if (Input.GetKey(left))
        {
            horizontal = -1f;
        }
        if (Input.GetKey(up))
        {
            vertical = 1f;
        }
        if (Input.GetKey(down))
        {
            vertical = -1f;
        }
        Vector2 direction = new Vector2(horizontal, vertical);
        rb.velocity = direction * speed;
    }
}
