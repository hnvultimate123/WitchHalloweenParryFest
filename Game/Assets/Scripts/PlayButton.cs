using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField]
    private SceneController _sceneController;

    public void PlayGame()
    {
        _sceneController.LoadScene("WithExplosionSprite");
    }
}
