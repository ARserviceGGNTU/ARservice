using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneTransitions : MonoBehaviour
{
    public void TransitionMethod(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
    public void ExitMethod()
    {
        Application.Quit();
    }
}
