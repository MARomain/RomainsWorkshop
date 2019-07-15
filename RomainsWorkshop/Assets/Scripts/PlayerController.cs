using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public float rotationSpeed;

    public InputMaster inputs; //InputMaster est la class créer à l'aide du InputAsset InputMaster

    // Start is called before the first frame update
    void Start()
    {
        inputs.Player.Shoot.performed += context => Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        AimAtCursor();
        Shoot();
    }

    public void AimAtCursor()
    {
        LayerMask ground = 1 << 9;

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
        {
            Debug.DrawRay(hit.point, Vector3.up, Color.red, 5f);
        }

        Quaternion newRotation = Quaternion.LookRotation(hit.point - transform.position, Vector3.up);
        newRotation.x = 0f;
        newRotation.z = 0f;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
    }

    public void Shoot()
    {
        Debug.Log("I shot");
    }

    private void OnEnable()
    {
        inputs.Player.Enable();
    }

    private void OnDisable()
    {
        inputs.Player.Disable();
    }
}
