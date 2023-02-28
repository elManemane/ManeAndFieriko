using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : BasicStats
{
    private CharacterController CharCont;
    private Camera mycam;
    private Vector3 PlayerVelocity;

    private void Start()
    {

        mycam = Camera.main;
        CharCont = gameObject.GetComponent<CharacterController>();
    }
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        CharCont.Move(move * Time.deltaTime * Speed);

        if (move != Vector3.zero)
        {
          //  gameObject.transform.forward = move;
        }

        PlayerVelocity.y += -9.81f * Time.deltaTime;
        CharCont.Move(PlayerVelocity * Time.deltaTime);
        if(hp <= 0)
        {
            this.enabled = false;
        }
        CamLook();
    }

    void CamLook()
    {

    }
}
