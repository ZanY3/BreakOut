using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{
    public string thisScene;
    public AudioSource source;
    public AudioClip clickSound;

    public void Restart()
    {
        source.PlayOneShot(clickSound);
        SceneManager.LoadScene(thisScene);
        Time.timeScale = 1f;
    }
}
