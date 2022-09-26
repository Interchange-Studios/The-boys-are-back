using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargeting : MonoBehaviour
{
    public float speed = 4f;
    private Transform target; 

    private void Update() {
        if (target != null) {
            float moveSpeed = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            target = other.transform;
        }
    }

    private void onTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            target = null;
        }
    }
}
