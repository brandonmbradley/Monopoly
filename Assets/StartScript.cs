using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public void StartButton(string loading)
    {
        SceneManager.LoadScene(loading);
    }

    public void Exitgame()
        {
        Application.Quit();
        }
}
