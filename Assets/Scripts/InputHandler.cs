using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private GameObject PlayerController;

    private IAimable _characterAim;
    private IMoveable _characterMovement;
    private PlayerExample _playerExample;

    private void Awake()
    {
        _characterAim = PlayerController.GetComponent<IAimable>();
        _characterMovement = PlayerController.GetComponent<IMoveable>();
        _playerExample = PlayerController.GetComponent<PlayerExample>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        _characterMovement.Move(context.ReadValue<Vector2>());
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        _characterAim.Position = context.ReadValue<Vector2>();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        _playerExample.Attack(_characterAim.Position);
    }

    public void OnNextAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerExample.NextAttack();
        }
    }

    public void OnPreviousAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _playerExample.PreviousAttack();
        }
    }
}
