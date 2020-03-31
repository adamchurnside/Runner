using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    public GameObject effect;

    private Shake shake;

    public GameObject explosionSound;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    private void Update()
    {
        // move the obstable left
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // check if the player collides with the obstable
        if (other.CompareTag("Player"))
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            // instatiate particle effect on collision
            Instantiate(effect, transform.position, Quaternion.identity);

            shake.CamShake();

            // damage dealt, remove health and destroy the obstable
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
 
}
