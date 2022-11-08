using System;

public class HealthSystem
{
    public event EventHandler OnDead;

    private float Max_Health;
    private float Current_Health;

    public HealthSystem(float maxHealthAmount)
    {
        Max_Health = maxHealthAmount;
        Current_Health = Max_Health;
    }
    public void Damage(float dmageAmount)
    {
        Current_Health -= dmageAmount;

        if (Current_Health <= 0)
        {
            if (OnDead != null) OnDead(this, EventArgs.Empty);
        }
    }
    public void Recover(float RecoverAmount)
    {
        Current_Health += RecoverAmount;

        if (Current_Health >= Max_Health)
        {
            Current_Health = Max_Health;
        }
    }
    public float GetCurrentHealthAmount()
    {
        return Current_Health;
    }
    public float GetCurrentHealthPercentage()
    {
        return 1 / Current_Health;
    }
}
