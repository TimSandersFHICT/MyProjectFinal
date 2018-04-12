using UnityEngine;

public class Resource : MonoBehaviour
{
	public delegate void ChangeAmount();
	public event ChangeAmount OnChanged;
	
    private int amount;
    
	private void Start ()
	{
		amount = 20;
		if (OnChanged != null) OnChanged();
	}

	public void Add(int amount)
	{
		this.amount += amount;
		if (OnChanged != null) OnChanged();
	}

	public int GetAmount()
	{
		return amount;
	}
}
