using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5;

    void Update()
    {
        _PlayerMovement();
    }

    private void _PlayerMovement()
    {
        float HorizontalMovement = _moveSpeed * Input.GetAxisRaw("Horizontal");
        float VerticalMovement = _moveSpeed * Input.GetAxisRaw("Vertical");
        transform.Translate(HorizontalMovement, 0f, VerticalMovement);
    }
}
