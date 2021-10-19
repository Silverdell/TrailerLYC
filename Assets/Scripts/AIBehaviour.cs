using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBehaviour : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private float minTimeBetweenSwitchSide = 10;
    [SerializeField] private float maxTimeBetweenSwitchSide = 30;
    private void Start()
    {
        animator = GetComponent<Animator>();
        LaunchMovement();
    }
    private void LaunchMovement()
    {
        StartCoroutine(nameof(HoverAndMove));
    }
    private IEnumerator HoverAndMove()
    {
        Loop: 

        yield return new WaitForSeconds(Random.Range(minTimeBetweenSwitchSide, maxTimeBetweenSwitchSide));
        animator.SetTrigger("ChangeSideToLeft");

        yield return new WaitForSeconds(Random.Range(minTimeBetweenSwitchSide, maxTimeBetweenSwitchSide));
        animator.SetTrigger("ChangeSideToRight");

        goto Loop;
        
    }
}
