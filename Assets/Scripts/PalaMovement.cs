using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(0, y) * speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
         //rb.velocity = new Vector2(0, y) * speed;
    }
}
