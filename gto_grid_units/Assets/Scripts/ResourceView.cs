using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour
{
	public Resource ResourceModel;
	public Text TextComponent;
	
	private	void OnEnable()
	{
		ResourceModel.OnChanged += ModelChanged;
	}

	private void ModelChanged()
	{
		TextComponent.text = "Gold: " + ResourceModel.GetAmount();
	}
}
