using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float hp = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //如果碰撞到的子彈
        if(other.tag == "Bullet")
        {
            Bullet bullet = other.GetComponent<Bullet>();
            //先扣血
            hp -= bullet.atk;

            Debug.Log(hp);

            //如果血沒了，就刪除自己
            if (hp <= 0)
            {
                
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
