using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStat : MonoBehaviour
{
    public float speed; // �̵��ӵ�
    public float hp; // ü��
    public float power; // ��
    public float attackSpeed; // ���ݼӵ�
    public float defense; // ����
    public float magicResistance; // ���� ���׷�

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
