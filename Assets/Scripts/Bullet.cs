using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    float speed = 8;
    Gun gun;
    public Vector3 dir = Vector3.zero;


    public void Init(Vector3 direction, Gun _gun)
    {
        rb = GetComponent<Rigidbody>();
        dir = direction;
        rb.velocity = dir * speed;

        gun = _gun;

        Destroy(gameObject, 3);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gun.SendStopMessage();
            Debug.Log("게임 오버");
        }
    }
}
