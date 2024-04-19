using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 5;
    GameObject targetObject;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            targetObject = collision.gameObject;
        }

        targetObject.SetActive(false);
        Destroy(gameObject);
    }            
}
