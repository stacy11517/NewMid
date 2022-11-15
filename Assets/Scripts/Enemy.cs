using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private HealthSystem healthSystem;
    public float hp = 100f;


    

    
    
    private void Awake()
    {
        healthSystem = new HealthSystem(hp);

        healthSystem.OnDead += HealthSystem_OnDead;
    }

    private void HealthSystem_OnDead(object sender, System.EventArgs e)
    {
        // drop coin

        Destroy(gameObject);
    }

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
        //�p�G�I���쪺�l�u
        if(other.tag == "Bullet")
        {
            Bullet bullet = other.GetComponent<Bullet>();
            //������(�ˮ`��)
            healthSystem.Damage(bullet.Attack_Damage);
/*
            hp -= bullet.atk;

            Debug.Log(hp);

            //�p�G��S�F�A�N�R���ۤv
            if (hp <= 0)
            {
                
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
*/
        }
    }

}
