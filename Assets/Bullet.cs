using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 5;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "Target")
        {
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
