using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;

    // Start is called before the first frame update
    void Start() {
        health = maxHealth;    
    }

    public void TakeDamage(int amount) {
        health = health - amount;
        if(health <= 0) {
            Destroy(gameObject);
        }
    }
}
