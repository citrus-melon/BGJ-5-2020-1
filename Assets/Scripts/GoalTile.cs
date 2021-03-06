using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTile : MonoBehaviour
{
    public int stage = 1;
    public LayerMask trigger;
    public float triggerRadius = 0.05f;
    private bool active;
    public bool fufilled;
    private void Update() {
        Collider2D overlap = Physics2D.OverlapPoint(transform.position, trigger);
        if(overlap && Vector2.Distance(overlap.transform.position, transform.position) <= triggerRadius) {
            if (active) return;
            if (overlap.GetComponent<PlayerMerge>().stage == stage) {
                fufilled = true;
            } else {
                fufilled = false;
            }
            active = true;
        } else {
            active = false;
            fufilled = false;
        }
    }
}