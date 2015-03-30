using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateCard : MonoBehaviour {

	LoadAllAssets loader;
	string cardName;

	// Use this for initialization
	void Start () {
		loader = GameObject.Find ("Loader").GetComponent<LoadAllAssets>();
		Image [] imgs = GetComponentsInChildren<UnityEngine.UI.Image>();
		foreach( Image img in imgs ) {
			if ( img != this.GetComponent<Image>() ) {
				cardName = img.sprite.name;
			}
		}

	}

	public void OnClickCard() {
		loader.CreateCard(cardName);
	}
}
