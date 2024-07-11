using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator anim;
    private int atkNum = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void PlayAnimation(int atkNum)
    {
        anim.SetFloat("Blend", atkNum);
        anim.SetTrigger("Atk");
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayAnimation(atkNum++);
            if(atkNum >2)
            {
                atkNum = 0;
            }
        }
    }

}
