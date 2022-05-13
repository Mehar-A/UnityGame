using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingMenu : MonoBehaviour
{
    public static EndingMenu BgInstance;
    Scene scene;

    string LastsceneName;

    void Update()
    {
        scene = SceneManager.GetActiveScene();
        SoundsCheck(scene);
    }

    private void SoundsCheck(Scene s)
    {

        if ((BgInstance != null && BgInstance != this) || s.name == "TestingField" || s.name == "NormalMode" || s.name == "DifficultMode")
        {
            Destroy(this.gameObject);
            return;

        }


    }

    public void RestartMode()
    {
        LastsceneName = DectectCollison.newname;
        //Debug.Log("After pressing restart mode" + LastsceneName);
        SceneManager.LoadScene(LastsceneName);

    }

    public void EndMenuMode()
    {
        //Debug.Log("QuitGame");
        SceneManager.LoadScene(0);
    }

    
}
