using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multipressuredoor : MonoBehaviour
{
    public multipressurehandler handler;
    private bool Up = false;
    private float startHeight;
    public BoxCollider doorCollider;
    private float targetY;
    public float Speed;


    // Start is called before the first frame update
    void Start()
    {
        handler.Reset();
        handler.maxcount = 2;

        startHeight = transform.position.y;

        if (Up)
        {
            targetY = transform.position.y + doorCollider.bounds.size.y / 2;
        }
        else
        {
            targetY = transform.position.y - doorCollider.bounds.size.y / 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Up = handler.both();
        if (Up)//go down
        {
            if (transform.position.y + doorCollider.bounds.size.y / 2 >= targetY)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + -Speed * Time.deltaTime, transform.position.z);
            }
        }
        else//go up
        {
            if (transform.position.y - doorCollider.bounds.size.y / 2 <= targetY)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + Speed * Time.deltaTime, transform.position.z);
            }
        }
    }
}
