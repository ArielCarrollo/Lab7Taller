using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample : BasePlayerController, IAimable, IMoveable, IAttackable
{
    public Vector2 Position
    {
        get
        {
            return _aimPosition;
        }

        set
        {
            _aimPosition = value;

            Debug.Log("Aim from " + this.name);
        }
    }
    private IAttackable attackStrategy;

    public void SetAttackStrategy(IAttackable newStrategy)
    {
        attackStrategy = newStrategy;
    }

    public void Attack(Vector2 position)
    {
        attackStrategy?.Attack(position);
    }
    protected override void Awake()
    {
        base.Awake();

        Debug.Log("Child Awake");
    }

    protected override void Start()
    {
        base.Start();

        Debug.Log("Child Start");
    }

    public void Move(Vector2 direction)
    {
        Debug.Log("Move from " + this.name);
    }


}
