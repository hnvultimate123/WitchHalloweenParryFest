using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Ouput the Collision to the console
        if(collision.gameObject.tag == "Bullet") {
            Debug.Log("Collision : " + collision.gameObject.name);
            PauseGame();
            button.SetActive(true);
        }
    } 

    void PauseGame()
    {
        Time.timeScale = 0f;
    }

}
