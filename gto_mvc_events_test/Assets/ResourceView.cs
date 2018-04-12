using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
	public Resource model;
	public Text text;

	private	void OnEnable()
	{
		model.OnChanged += ModelChanged;
	}

	private void ModelChanged()
	{
		text.text = "Amount of gold: " + model.GetAmount();
	}
}
