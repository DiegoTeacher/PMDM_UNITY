using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public AudioClip bounceAudioClip;

    private Rigidbody2D rb;
    private Vector2 direction;
    private Vector2 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        do
        {
            direction.x = Random.Range(-1, 2);
        } while (direction.x == 0);


        direction.y = Random.Range(-1, 2);
        initialPosition = transform.position;
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
    }

    private void FixedUpdate()
    {
        rb.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioManager.instance.PlayAudio(bounceAudioClip, "BoingBoing");

        // cada vez que ocurra una colision CON LA PALA, reboto
        if(collision.gameObject.GetComponent<PalaMovement>())
        {
            direction.x *= -1; // direction.x = direction.x * -1;
            direction.y = Random.Range(-1, 2);
        }
        else // cada vez que ocurra una colision con cualquier otra cosa
        {
            // solo hay techo o suelo
            direction.y *= -1;
        }
    }
}
