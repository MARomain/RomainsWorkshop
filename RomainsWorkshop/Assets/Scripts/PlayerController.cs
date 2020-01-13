using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEditor;

public class PlayerController : MonoBehaviour
{
    //godsent
    //https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/Migration.html

    PlayerControls controls;

    public float moveSpeed;
    public float rotationSpeed;
    public Camera cam;
    public bool mouseInput = true;

    public Vector3 cameraOffset;

    Vector2 move;
    Vector2 look;
    Vector2 rotate;
    bool anyGamepadKeyPressed;

    private void Awake()
    {
        controls = new PlayerControls();

        //gamepad
        controls.GameplayPad.Grow.performed += context => Grow();

        controls.GameplayPad.Move.performed += context => move = context.ReadValue<Vector2>();
        controls.GameplayPad.Move.canceled += context => move = Vector2.zero;

        controls.GameplayPad.Rotate.performed += context => rotate = context.ReadValue<Vector2>();
        controls.GameplayPad.Rotate.canceled += context => rotate = Vector2.zero;

        //mouse keyboard
        controls.GameplayMk.Move.performed += context => move = context.ReadValue<Vector2>();
        controls.GameplayMk.Move.canceled += context => move = Vector2.zero;

        controls.GameplayMk.Look.performed += context => look = context.ReadValue<Vector2>();
    }

    private void Start()
    {

    }

    private void Update()
    {
        Move();
        //InputSwitcher();
        Aim();
    }

    //when you press A the character grows hihi
    private void Grow()
    {
        transform.localScale *= 1.1f;
    }

    private void Move()
    {
        Vector3 m = new Vector3(move.x, 0f, move.y) * Time.deltaTime * moveSpeed;
        transform.Translate(m, Space.World);
    }

    public void AimAtCursor()
    {
        LayerMask ground = 1 << 9;

        Ray ray = cam.ScreenPointToRay(look);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
        {
            Debug.DrawRay(hit.point, Vector3.up, Color.red, 2f);
        }

        Quaternion newRotation = Quaternion.LookRotation(hit.point - transform.position, Vector3.up);
        newRotation.x = 0f;
        newRotation.z = 0f;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        Vector3 stickDir = new Vector3(rotate.x, 0, rotate.y);
        float step = rotationSpeed* Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, stickDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);

    }

    private void Aim()
    {
        if (mouseInput == true)
        {
            AimAtCursor();
        }
        else
        {
            Rotate();
        }
    }

    //void OnDrawGizmos()
    //{
    //    Handles.Label(transform.position, move.ToString());
    //}

    public void InputSwitcher()
    {
        if(Input.anyKeyDown)
        {
            mouseInput = true;
        }
        
        if (Gamepad.current.wasUpdatedThisFrame == true)
        {
            mouseInput = false;
        }
    }

    private void OnEnable()
    {
        controls.GameplayPad.Enable();
        controls.GameplayMk.Enable();
    }

    private void OnDisable()
    {
        controls.GameplayPad.Disable();
        controls.GameplayMk.Disable();
    }
}
