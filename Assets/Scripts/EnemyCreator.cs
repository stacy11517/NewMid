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
        //�}�l�ͦ��Ǫ�
        for (int i = 0; i < EnemyNum; i++)
        {
            //�ŧi�ͦ���Y�y��
            float y;

            //�����H����y�y��(-4��4����)
            y = Random.Range(-4, 5);

            //�ͦ��Ǫ�
            Instantiate(Enemy, new Vector3(7.15f, y, 0), Quaternion.identity);
        }
    }

}
