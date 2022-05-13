using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScore : MonoBehaviour
{
    public GameObject checking;
    public Vector3 pos;
    public TextMesh textanim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textanim.text = "Current Score: " + ScoreScript.scoreValue;
        textanim.transform.position = checking.transform.position + pos;
    }
}
