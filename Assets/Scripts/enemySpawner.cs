using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject theEnemy;
    public float xPos;
    public float zPos;
    public int enemyCount;
    public Transform myPlayerTrans;

    void Start()
    {
        StartCoroutine(EnemyDrop()); 
    }


    IEnumerator EnemyDrop()
    {
        while(enemyCount < 4)
        {
            xPos = myPlayerTrans.position.x+10;
            zPos = myPlayerTrans.position.z+10;
            Instantiate(theEnemy, new Vector3(xPos, 0, zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.8f);
            enemyCount += 1;
        }
    }

}
