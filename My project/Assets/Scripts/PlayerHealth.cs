using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

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
    
    void Update() {

        if(health > maxHealth){
            health = maxHealth;
        }

        for (int i = 0; i < hearts.Length; i++) {
            if (i < maxHealth) {
                hearts[i].sprite = fullHeart;
            }
            else {
                hearts[i].sprite = emptyHeart;
            }
            if(i < health){
                hearts[i].enabled = true;
            }
            else {
                hearts[i].enabled = false;
            }
        }
    }
}
