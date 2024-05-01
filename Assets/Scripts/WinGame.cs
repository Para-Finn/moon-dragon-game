using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Win!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
