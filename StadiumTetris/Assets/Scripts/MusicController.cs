using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicController : MonoBehaviour
{
    public static MusicController BgInstance;
    Scene scene;

    void Update()
    {
        scene = SceneManager.GetActiveScene();
        SoundsCheck(scene);
    }


    private void SoundsCheck(Scene s)
    {

        if ((BgInstance != null && BgInstance!=this) || s.name == "TestingField" || s.name == "NormalMode" || s.name == "DifficultMode")
        {
            Destroy(this.gameObject);
            return;

        }

        BgInstance = this;
        //Debug.Log(BgInstance);
        DontDestroyOnLoad(this);
    }
}
