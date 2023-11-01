using UnityEngine;

namespace HamsterVsDinosaurs
{
    public class MainDataCharacters : MonoBehaviour
    {
        [SerializeField, Range(-10f,10f)]
        protected float _moveSpeed;

        [SerializeField, Range(0.1f, 10f)]
        protected float _moveRotation;
        
        protected Rigidbody _rb;

        protected Animator _animator;

        protected Transform _transform;
    }
}