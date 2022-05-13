using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeMenu : MonoBehaviour
{
   
    public void NormalMode()
    {
        SceneManager.LoadScene(2);
    }

    public void DifficultMode()
    {
        SceneManager.LoadScene(3);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }

}
