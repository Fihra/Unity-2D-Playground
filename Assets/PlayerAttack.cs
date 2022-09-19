using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator animator;

    private float attackTime = 0.25f;
    private float attackCounter = 0.25f;
    private bool isAttacking;

    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isAttacking)
        {
            attackCounter -= Time.deltaTime;
            if(attackCounter <= 0)
            {
                animator.SetBool("isAttacking", false);
                isAttacking = false;
            }
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            attackCounter = attackTime;
            Debug.Log("Do that one attack where you swing your stick or whatever");
            animator.SetBool("isAttacking", true);
            isAttacking = true;
        }

    }
}
