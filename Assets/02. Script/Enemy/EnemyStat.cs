using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : MonoBehaviour
{
    public float speed; // 이동속도
    public float hp; // 체력
    public float power; // 힘
    public float attackSpeed; // 공격속도
    public float defense; // 방어력
    public float magicResistance; // 마법 저항력

    public string _name;
    public bool isdie = false;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    
    public void Hit(float Damage)
    {
        hp -= Damage;
        if(hp<=0)
        {
            Die();
        }
    }

    void Die()
    {
        if (isdie) return;
        isdie = true;
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerAttack"))
        {
            Debug.Log("1");
        }
    }
}
