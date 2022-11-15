using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatBoss : MonoBehaviour
{

    public GameObject Boss;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 取得所有場上 tag 為 Enemy 的物件
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        // 取得數量
        int enemyCount = enemys.Length;

        Debug.Log(enemyCount);

        if (enemyCount == 1)
        {

            Boss.SetActive(true);
        }
    }
}
