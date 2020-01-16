using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootable : MonoBehaviour {
    public GameObject create;
    public int currentHealth;
    public UnityEngine.UI.Text enemiesKilled;
    public AudioSource die;
    public GameObject explodeSound;
    public bool createAnother = true;

    public GameObject newEnemySound;
    private AudioSource newEnemy;
    public int GrowShrink;
    // Use this for initialization
    void Start () {
        
        //counter = GetComponent<Playermover>();
        die = explodeSound.GetComponent<AudioSource>();
        newEnemy = newEnemySound.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void Damage(int damageAmount)

    {

        //subtract damage amount when Damage function is called

        currentHealth -= damageAmount;

        //Check if health has fallen below zero

        if (currentHealth <= 0)

        {

            //die.Play();
            //newEnemy.Play();
            //if health has fallen below zero, deactivate it
            GameObject clone;
            if (createAnother)
            {
                 clone = Instantiate(create);
                clone.transform.position = new Vector3(0, 10, 0);
            }
            
            //clone.transform.localScale -= new Vector3(GrowShrink,GrowShrink,GrowShrink);
            
            //counter.CountUp();
            string enemiesKilledToString = enemiesKilled.text;
            string enemyKilledAsNumString = "";
            foreach (char letter in enemiesKilledToString)
            
            {
                if (letter =='0'|| letter == '1' || letter == '2' || letter == '3' || letter == '4' || letter == '5' || letter == '6' || letter == '7' || letter == '8' || letter == '9' )
                {
                    enemyKilledAsNumString += letter;
                }
                
            }
            int enemiesKilledNum = System.Convert.ToInt32(enemyKilledAsNumString) +1;
            enemiesKilled.text = "Enemies Killed: " + enemiesKilledNum.ToString();

            this.gameObject.SetActive(false);
            


        }

    }
}
