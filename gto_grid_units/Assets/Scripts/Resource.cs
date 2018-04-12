using UnityEngine;

public class Resource : MonoBehaviour
{
    public int StartAmount;
    private int amount;
    
    public delegate void ChangeAmount();
    public event ChangeAmount OnChanged;

    private void Start()
    {
        amount = StartAmount;
        if (OnChanged != null) OnChanged();
    }

    public int GetAmount()
    {
        return amount;
    }

    public bool Remove(int amount)
    {
        if (this.amount < amount) return false;
        this.amount -= amount;
        if (OnChanged != null) OnChanged();
        return true;
    }

    public void Add(int amount)
    {
        this.amount += amount;
        if (OnChanged != null) OnChanged();
    }
}
