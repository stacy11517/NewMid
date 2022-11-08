using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;

    public float Attack_Damage = 25f;

    void Start()
    {
        //
        Destroy(gameObject, 10);
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //如果碰撞到的敵人
        if (other.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
