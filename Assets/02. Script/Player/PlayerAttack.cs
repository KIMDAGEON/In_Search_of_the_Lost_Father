using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeReference] private Collider2D attackCollider;

    private Animator anim;
    private int atkNum = 0;
    private float attackTime = 0.5f;
    private bool attack;
    void Start()
    {
        attack = true;
        attackCollider.enabled = false;
        anim = GetComponent<Animator>();
    }
    public void PlayAnimation(int atkNum)
    {
        anim.SetFloat("Blend", atkNum);
        anim.SetTrigger("Atk");
    }
    
    void Update()
    {
        Attack();
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0) && attack == true)
        {
            StartCoroutine(AttackCooltime());
        }
    }

    IEnumerator AttackCooltime()
    {
        attack = false;
        attackCollider.enabled = true;
        PlayAnimation(atkNum++);

        if (atkNum > 2)
        {
            atkNum = 0;
        }
        yield return new WaitForSeconds(attackTime-0.2f);
        attackCollider.enabled = false;
        yield return new WaitForSeconds(0.2f);

        attack = true;

        yield return null;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("2");
            collision.gameObject.GetComponent<Enemy>().Hit(10f);
            
        }
    }
}
