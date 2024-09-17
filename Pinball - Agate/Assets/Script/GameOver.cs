using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Collider bola;
    public GameObject gameOverCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            // kembali ke main menu
            SceneManager.LoadScene("MainMenu");
        }
    }
}
