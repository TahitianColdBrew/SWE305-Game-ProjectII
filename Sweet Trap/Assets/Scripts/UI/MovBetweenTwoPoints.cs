using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBetweenTwoPoints : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject dialog;
    private SpriteRenderer sr;
    private Animator animator;
    private float speed = 2f;

    private int targetIndex = 0;

    private float stayTime = 5f;
    private float leftTime;

    private bool isWalking = true;
        

    
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        leftTime = stayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            animator.SetBool("isWalking", true);
            var step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, points[targetIndex].position, step);


            if (Vector3.Distance(transform.position, points[targetIndex].position) < 0.01f)
            {
                Debug.Log("I'm here!");
                targetIndex = 1 - targetIndex;
                sr.flipX = !sr.flipX;

                if (targetIndex == 0)
                {
                    isWalking = false;
                    animator.SetBool("isWalking", false);
                    dialog.SetActive(true);
                }
            }
        }

        if (!isWalking)
        {
            leftTime -= Time.deltaTime;
            if(leftTime < 0)
            {
                isWalking = true;
                animator.SetBool("isWalking", false);
                dialog.SetActive(false);
                leftTime = stayTime;
            }
        }
    }
}
