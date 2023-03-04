using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : BasicStats
{
    private CharacterController CharCont;
    public Transform cam;
    private Vector3 PlayerVelocity;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    private Inventory inventory;

    [SerializeField] private UIInventory uiInventory;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        CharCont = gameObject.GetComponent<CharacterController>();

        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

        if(move.magnitude >= 1)
        {
            float targetAngle = Mathf.Atan2(move.x, move.z)* Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 MoveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            CharCont.Move(MoveDir.normalized * Speed * Time.deltaTime);
        }

        PlayerVelocity.y += -9.81f * Time.deltaTime;
        CharCont.Move(PlayerVelocity * Time.deltaTime);
        if(hp <= 0)
        {
            this.enabled = false;
        }
    }
}
