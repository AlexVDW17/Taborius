using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {
    public GameObject player;
    public GameObject enemy;
    public int numberOfEnemies;
    public string xAxisGreaterOrLess;
    public string zAxisGreaterOrLess;
    public float xSpawnPos;
    public float zSpawnPos;
    private int x;
    private int z;
    public bool passed = true;
    private PlayerChaser[] playerChasers;
    public float enemySpeed;
	// Use this for initialization
	void Start () {
        PlayerChaser[] playerChasers = new PlayerChaser[numberOfEnemies];
        if (xAxisGreaterOrLess == "+")
        {
            x = 1;
        }
        else if (xAxisGreaterOrLess == "-")
        {
            x = 2;
        }
        else
        {

        }
        if (zAxisGreaterOrLess == "+")
        {
            z = 1;
        }
        else if(zAxisGreaterOrLess=="-")
        {
            z = 2;
        }
        else { }
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (x ==1 &&z==1 && passed == true)
        {
            
            if (player.transform.position.z>=transform.position.z && player.transform.position.x>=transform.position.x)
            {
                EnemyMaker(numberOfEnemies);
            }
        }
        if (x == 2 && z == 1 && passed == true)
        {

            if (player.transform.position.z >= transform.position.z && player.transform.position.x <= transform.position.x)
            {
                EnemyMaker(numberOfEnemies);
            }
        }
        if (x == 1 && z == 2 && passed == true)
        {

            if (player.transform.position.z <= transform.position.z && player.transform.position.x >= transform.position.x)
            {
                EnemyMaker(numberOfEnemies);
            }
        }
        if (x == 2 && z == 2 && passed == true)
        {

            if (player.transform.position.z <= transform.position.z && player.transform.position.x <= transform.position.x)
            {
                EnemyMaker(numberOfEnemies);
            }
        }
    }
    
    private void EnemyMaker( int numberOfEnemies)
    {
        passed = false;
        GameObject[] enemyArray = new GameObject[numberOfEnemies];
        for ( int i = 0; i < numberOfEnemies; i++)
        {

            GameObject clone = Instantiate(enemy);
            //enemyArray[i] = enemy;
            //Instantiate(enemyArray[i]);
            //enemyArray[i].transform.position = new Vector3(0,2,0);
            //enemyArray[i].transform.position = enemy.transform.position;
            clone.transform.position= new Vector3(xSpawnPos, 2f, zSpawnPos);
            //enemyArray[i].SetActive(true);

            try
            {

                playerChasers[i] = enemyArray[i].GetComponent<PlayerChaser>();

                playerChasers[i].speed = enemySpeed;
            }
            catch
            { }
        }
    }

}
