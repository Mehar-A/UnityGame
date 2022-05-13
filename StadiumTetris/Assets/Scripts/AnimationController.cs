using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public GameObject checking;
    public Vector3 pos;
    public TextMesh textanim;
    private string[] message = { "Hit me baby one more time", " You suck", "Keep Going", "This is boring", "Die" ,  "Hes One Shot"};
    private int randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        //textanim.text = "Hello World";
        InvokeRepeating("SelectMessageAnimation", 0, 5);
        
    }

    void SelectMessageAnimation()
    {
        //Debug.Log(checking.transform.position);

        randomNumber = Random.Range(0, 5);
        textanim.text = message[randomNumber];
        textanim.transform.position = checking.transform.position + pos;
        //Debug.Log(textanim.transform.position);
    }
    
}
