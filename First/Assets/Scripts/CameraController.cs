using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Cam1; // animation camera
    public GameObject Cam2; // regular camera
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SqueneceCamera());
    }

    IEnumerator SqueneceCamera()
    {
        ScoreScript.updatedscore();
        Cam1.SetActive(true);
        Cam2.SetActive(false);
        yield return new WaitForSeconds(16);
        Cam1.SetActive(false);
        Cam2.SetActive(true);
    }
}
