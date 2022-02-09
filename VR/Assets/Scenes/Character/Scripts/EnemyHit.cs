using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject enemy;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        animator = GetComponent<Animator>();
        // animator.SetBool("die", false);

        while (true)
        {
            yield return new WaitForSeconds(3);
            animator.SetInteger("AttackIndex", Random.Range(0, 4));
            animator.SetTrigger("Attack");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            Debug.Log("I killed the enemy");
            if(Random.Range(0, 2)> 0)
            {
                animator.SetTrigger("die_01");
            }
            else
            {
                animator.SetTrigger("die_02");
            }

            Destroy(gameObject, 4f);
            
        }
    }
}
