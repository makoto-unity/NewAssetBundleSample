using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : UIBehaviour 
{
	[SerializeField]
	Text uiText;

	[SerializeField]
	Image uiIcon;
	public GameObject cardObj;
	
	public void UpdateItem (int count) 
	{
		uiText.text = (count + 1).ToString("000");
		string iconName = "f" + uiText.text;
		PicLoader picLoader = GetComponent<PicLoader>();
		picLoader.LoadPic("icon", iconName, uiIcon);
	}

	public void OnClickIcon() {
		Image cardImg = cardObj.GetComponent<Image>();
		PicLoader cardLoader = cardObj.GetComponent<PicLoader>();
		string cardName = "f" + uiText.text;
		cardLoader.LoadPic("card", cardName, cardImg);
	}
}
