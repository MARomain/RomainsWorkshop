using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public float speed;
    public Vector3 targetPosition;

    public Animator anim;
    public int id;

    void Start()
    {
        anim = GetComponent<Animator>();

        GameEvents.current.onDoorwayTriggerEnter += OnDoorWayOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorWayExit;
    }

    private void OnDoorWayOpen(int id)
    {
        //targetPosition = transform.position + targetPosition;
        //float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, step);

        if(id == this.id)
        {
            anim.SetTrigger("OpenDoor");
        }
    }

    private void OnDoorWayExit(int id)
    {
        if(id == this.id)
        {
            anim.SetTrigger("CloseDoor");
        }
    }

    private void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= OnDoorWayOpen;
        GameEvents.current.onDoorwayTriggerExit -= OnDoorWayExit;
    }
}
