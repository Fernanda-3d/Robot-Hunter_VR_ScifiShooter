using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    ScoreManager scoreManager;   
    [SerializeField] int scorePerHit = 1;

    Animator animator;
    [SerializeField] GameObject enemy;

    CapsuleCollider capsule;

    // Start is called before the first frame update

    private void Awake()
    {
        capsule = GetComponent<CapsuleCollider>();
        scoreManager = FindObjectOfType<ScoreManager>();        
    }
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
            capsule.isTrigger = false;

            if (Random.Range(0, 2)> 0)
            {
                animator.SetTrigger("die_01");
            }
            else
            {
                animator.SetTrigger("die_02");
            }

            scoreManager.IncreaseScore(scorePerHit); 

            Destroy(gameObject, 4f);
            
        }
    }
}
