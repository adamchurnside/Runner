using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;

    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public GameObject effect;
    public Text healthDisplay;
    public GameObject gameOver;
    public GameObject popSound;
    public GameObject gameOverSound;

    // Update is called once per frame
    private void Update()
    {
        healthDisplay.text = health.ToString();
        // on death
        if (health <= 0)
        {
            // restart scene
            Instantiate(gameOverSound, transform.position, Quaternion.identity);
            
            gameOver.SetActive(true);            
            Destroy(gameObject); 

            //SceneManager.LoadScene("GameOver");
            //Restart Scene --OLD--
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // smoothly transition player between positions      
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // check if the players y position is less than the max height
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(popSound, transform.position, Quaternion.identity);

            PlayerEffect();
            // move the player up the y axis on up arrow
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);


        } // check if the players y position is greater than the min height
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(popSound, transform.position, Quaternion.identity);
            PlayerEffect();
            // move the player down the y axis on down arrow
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);

        }
    }

    public void PlayerEffect()
    {
        Instantiate(effect, transform.position, Quaternion.identity);
    }

}
