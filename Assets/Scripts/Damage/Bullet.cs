using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject target;
    float moveSpeed = 60f;
    Vector2 moveDir;

    private void Start()
    {
        moveDir = (target.transform.position - transform.position).normalized * moveSpeed; 
        Destroy(gameObject, 12f);
    }
    private void Update() {
        if (target!= null) {
            transform.Translate(moveDir * Time.deltaTime);
        }
        transform.Translate(moveDir * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Build")
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
}
