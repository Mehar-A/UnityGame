using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DectectCollison : MonoBehaviour
{
    Scene scene;
    public static string newname;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detect when there is a collision starting
    void OnCollisionEnter(Collision collision)
    {
        //Ouput the Collision to the console
        //Debug.Log("Collision : " + collision.gameObject.name);
        /*
            Destroy(gameObject);
            Destroy(other.gameObject);
         */

        //Destroy(collision.gameObject);
        Debug.Log("We collide with eachother ");
        Debug.Log("Scene name after collosion is " + scene.name);
        SceneManager.LoadScene(4);
        newname = scene.name;

    }
}
