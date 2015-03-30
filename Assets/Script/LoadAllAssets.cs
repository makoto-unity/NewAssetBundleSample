using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadAllAssets : BaseLoader {

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );

//		// Load asset.
//		AssetBundleManifest manifest = AssetBundleManager.AssetBundleManifestObject;
//		string [] bundles = manifest.GetAllAssetBundles();
//		foreach( string bundle in bundles ) {
//			string assetName = System.IO.Path.GetFileNameWithoutExtension(bundle);
//			print ( assetName + ":" + bundle );
//			yield return StartCoroutine(LoadAs<Texture2D>(bundle,assetName));
//
////			GameObject go = Instantiate(prefab,new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f)), Quaternion.identity) as GameObject;
////			Texture2D tex = lastRequest.GetAsset<Texture2D>();
////			go.GetComponent<Renderer>().material.mainTexture = tex;
//
//			AssetBundleManager.UnloadAssetBundle(bundle);
//		}
	}

	public GameObject cardObj;

	public void CreateCard(string cardName) {
		StartCoroutine(CreateCardEnumrator(cardName));
	}

	IEnumerator CreateCardEnumrator(string cardName) {
		string assetBundleName = "assets/jewel-s-free101j/image/card/" + cardName + ".png";
		string assetName = cardName;
		yield return StartCoroutine(LoadAs<Texture2D> (assetBundleName, assetName) );

		Image cardImg = cardObj.GetComponent<Image>();
		Texture2D tex = lastRequest.GetAsset<Texture2D>();
		Sprite spr = Sprite.Create(tex, new Rect(0,0,tex.width,tex.height), Vector2.zero, 1.0f);
		cardImg.sprite = spr;
	}
}
