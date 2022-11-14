using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GenerateEnemy()
    {
        int EnemyNum;
        EnemyNum = Random.Range(0, 5);
        //開始生成怪物
        for (int i = 0; i < EnemyNum; i++)
        {
            //宣告生成的Y座標
            float y;

            //產生隨機的y座標(-4到4之間)
            y = Random.Range(-4, 5);

            //生成怪物
            Instantiate(Enemy, new Vector3(7.15f, y, 0), Quaternion.identity);
        }
    }

}
