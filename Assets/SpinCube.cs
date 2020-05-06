using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCube : MonoBehaviour
{
    public float spinForce;

    private void Update()
    {
        transform.Rotate(0, spinForce * Time.deltaTime, 0);
    }

    public void ChangeSpin()
    {
        spinForce = -spinForce;
    }

    //Vector3 spin;

    // Update is called once per frame
    //void Update()
    //{
    //spin = new Vector3(5f, 5f, 0f);
    //  spin = new Vector3(0, 0, 2);
    //transform.Rotate(spin);
    //}

    //public void Spin()
    //{
    //spin = new Vector3(5f, 5f, 0f);
    //  spin = new Vector3(0, 0, 2);
    //transform.Rotate(spin);
    //}

    //public GameObject player;

    //public void TeleportPlayer()
    //{
    //Debug.Log("Inside TeleportPlayer()");
    //  player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    //}
}
