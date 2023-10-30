using System;
using System.Collections;
using UnityEngine;

namespace HamsterVsDinosaurs
{
    public class PersonController : MainDataCharacters
    {
        private void Start()
        {
            _animator = GetComponentInChildren<Animator>();

            StartAnimator();
        }

        private void Update()
        {
            MovementTRex();
        }

        private void MovementTRex()
        {
            transform.position += new Vector3(-_moveSpeed * Time.deltaTime, 0f,0f);
        }

        private void StartAnimator()
        {
            if (_animator.GetBool("IsWalking") == true) return;

            _animator.SetBool("IsWalking", true);
        }


    }
}
