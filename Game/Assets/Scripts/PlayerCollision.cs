using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public GameObject button1;
    public GameObject button2;
    public AudioSource audioSource;
    public AudioClip collisionSound;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public BGM bgm;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 120;
        button1.SetActive(false);
        button2.SetActive(false);
        m_Rigidbody = GetComponent<Rigidbody2D>();
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        
            
    }
    
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Ouput the Collision to the console
        if(collision.gameObject.tag == "Bullet") {
            if (bgm != null)
            {
                bgm.StopMusic();
            }
            if (audioSource != null && collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }
            ChangeSprite();
            Debug.Log("Collision : " + collision.gameObject.name);
            PauseGame();
            button1.SetActive(true);
            button2.SetActive(true);
        }
    } 

    void PauseGame()
    {
        Time.timeScale = 0f;
    }

}
