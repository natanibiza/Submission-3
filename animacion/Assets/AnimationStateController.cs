using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isWarmingHash;
    int isAdvancingHash;
    int isFinalizingHash;
    int isDancingHash;

    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>();

        isWarmingHash = Animator.StringToHash("isWarming");
        isAdvancingHash = Animator.StringToHash("isAdvancing");
        isFinalizingHash = Animator.StringToHash("isFinalizing");
        isDancingHash = Animator.StringToHash("isDancing");
    }

    // Update is called once per frame
    void Update()
    {
        bool isDancing = animator.GetBool(isDancingHash);
        bool isFinalizing = animator.GetBool(isFinalizingHash);
        bool isAdvancing = animator.GetBool(isAdvancingHash);
        bool isWarming = animator.GetBool(isWarmingHash);
        bool forwardPressed = Input.GetKey("q");
        bool advancePressed = Input.GetKey("e");
        bool finalizePressed = Input.GetKey("r");
        bool dancePressed = Input.GetKey("w");

        // if player presses q key
        if (!isWarming && forwardPressed)
        {
            // then set the isWarming boolean to be true
            animator.SetBool(isWarmingHash, true);
        }

        // if player is not pressing q key
        if (isWarming && !forwardPressed)
        {
            // then set the isWarming boolean to false
            animator.SetBool(isWarmingHash, false);
        }


        // if player presses e key
        if (!isAdvancing && (advancePressed))
        {
            // then set the isAdvancing boolean to be true
            animator.SetBool(isAdvancingHash, true);
        }

        // if player is not pressing e key
        if (isAdvancing && (!advancePressed))
        {
            // then set the isAdvancing boolean to be false
            animator.SetBool(isAdvancingHash, false);
        }


        // if player presses r key
        if (!isFinalizing && (finalizePressed))
        {
            // then set the isFinalizing boolean to be true
            animator.SetBool(isFinalizingHash, true);
        }

        // if player is not pressing r key
        if (isFinalizing && (!finalizePressed))
        {
            // then set the isFinalizing boolean to be true
            animator.SetBool(isFinalizingHash, false);
        }


        // if player presses w key
        if (!isDancing && (dancePressed))
        {
            // then set the isDancing boolean to be true
            animator.SetBool(isDancingHash, true);
        }

        // if player is not pressing w key
        if (isDancing && (!dancePressed))
        {
            // then set the isDancing boolean to be false
            animator.SetBool(isDancingHash, false);
        }
    }

}
