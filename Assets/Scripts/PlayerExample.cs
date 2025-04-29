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
    [SerializeField] private List<MonoBehaviour> attackBehaviors;
    private List<IAttackable> attackStrategies = new List<IAttackable>();
    private int currentAttackIndex = 0;
    public void Attack(Vector2 position)
    {
        if (attackStrategies.Count > 0)
        {
            attackStrategies[currentAttackIndex].Attack(position);
        }
    }
    protected override void Awake()
    {
        base.Awake();

        Debug.Log("Child Awake");
        foreach (var behavior in attackBehaviors)
        {
            if (behavior is IAttackable attack)
            {
                attackStrategies.Add(attack);
            }
        }
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

    public void NextAttack()
    {
        currentAttackIndex = (currentAttackIndex + 1) % attackStrategies.Count;
    }

    public void PreviousAttack()
    {
        currentAttackIndex = (currentAttackIndex - 1 + attackStrategies.Count) % attackStrategies.Count;
    }
}
