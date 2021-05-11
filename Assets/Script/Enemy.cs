using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //敌人被击退的速度
    public float hitSpeed;
    //被击退的方向
    private Vector2 direction;
    //受击状态
    private bool isHit;
    //获取动画进度
    private AnimatorStateInfo info;
    private Animator animator;
    public Rigidbody2D rb;
    private Animator hitAnimator;

    // Start is called before the first frame update
    void Start()
    {
        animator = transform.GetComponent<Animator>();
        hitAnimator = transform.GetChild(0).GetComponent<Animator>();
        rb = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //获取动画进度
        info = animator.GetCurrentAnimatorStateInfo(0);
        if (isHit)
        {
            rb.velocity = direction * hitSpeed;
            if (info.normalizedTime >= 0.6f)
            {
                isHit = false;
            }
        }
    }
    public void AAGetHit(Vector2 direction)
    {
        transform.localScale = new Vector3(direction.x * 9, 9, 9);
        isHit = true;
        this.direction = direction;
        animator.SetTrigger("Hit");
        hitAnimator.SetTrigger("Hit");
    }
 
 
}