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
        // ���o�Ҧ����W tag �� Enemy ������
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        // ���o�ƶq
        int enemyCount = enemys.Length;

        Debug.Log(enemyCount);

        if (enemyCount == 1)
        {

            Boss.SetActive(true);
        }
    }
}
