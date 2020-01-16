using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCounter : MonoBehaviour {
    public int enemiesKilled;
    public UnityEngine.UI.Text enemiesDead;


    public void CountUp()
    {
        enemiesKilled++;
        enemiesDead.text = "Enemies Killed: " + enemiesKilled.ToString();
    }
}
