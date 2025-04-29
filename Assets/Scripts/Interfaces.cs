using UnityEngine;

public interface IAimable
{
    Vector2 Position { get; set; }
}

public interface IMoveable
{
    void Move(Vector2 direction);
}

public interface IAttackable
{
    void Attack(Vector2 position);
}
public class PlayerControlller : IAttackable
{
    public void Attack(Vector2 position)
    {
        throw new System.NotImplementedException();
    }
}