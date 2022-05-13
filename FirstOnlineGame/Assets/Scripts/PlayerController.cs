using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    PhotonView view;
    public CharacterController controller;
    //public Transform cam;

    public float speed = 10f;
    private float Hinput;
    //private float Vinput;

    //private float turnsmoothtime = 0.1f;
    //private float turnSmoothVel; 
    private void Start()
    {
        view = GetComponent<PhotonView>();
    }


    // Update is called once per frame
    void Update()
    {
        

        if (view.IsMine)
        {
            Hinput = Input.GetAxisRaw("Horizontal");
            //Vinput = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(Hinput, 0f, 0f).normalized;
            controller.Move(direction * speed * Time.deltaTime);
        }

        
        /*
        if(direction.magnitude >= 0.1f)
        {
            
            float targetAngel = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngel, ref turnSmoothVel, turnsmoothtime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngel, 0f) * Vector3.forward;
            
        controller.Move(direction * speed * Time.deltaTime);
        }
    */
    }

    
}
