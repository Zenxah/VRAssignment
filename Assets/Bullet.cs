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

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Target")
        {
            targetObject = collider.gameObject;
        }

        targetObject.SetActive(false);
        Destroy(gameObject);
    }            

}
