using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PicLoader : MonoBehaviour {

	Coroutine webCoroutine = null;

	public void LoadPic(string typeName, string fileName, Image sprImg)
	{
		if ( sprImg.sprite != null ) {
			if ( sprImg.sprite.texture ) {
				Resources.UnloadAsset(sprImg.sprite.texture);
			}
		}
		sprImg.sprite = null;
		if ( webCoroutine != null ) {
			StopCoroutine( webCoroutine );
			webCoroutine = null;
		}
		StartCoroutine(CreateCardEnumrator(typeName, fileName, sprImg));
	}

	IEnumerator CreateCardEnumrator(string typeName, string fileName, Image sprImg) {
		while( AssetBundleManager.AssetBundleManifestObject == null ) {
			yield return null;
		}
		
		string assetBundleName = "assets/jewel-s-free101j/image/" + typeName + "/" + fileName + ".png";
		string assetName = fileName;
		AssetBundleLoadAssetOperation request;
		
		// Load asset from assetBundle.
		request = AssetBundleManager.LoadAssetAsync(assetBundleName, assetName, typeof(Texture2D) );
		if (request == null) yield break;
		webCoroutine = StartCoroutine(request);
		yield return webCoroutine;
		webCoroutine = null;
		
		Texture2D tex = request.GetAsset<Texture2D>();
		Sprite spr = Sprite.Create(tex, new Rect(0,0,tex.width,tex.height), Vector2.zero, 1.0f);
		spr.name = tex.name;
		AssetBundleManager.UnloadAssetBundle(assetBundleName);
		sprImg.sprite = spr;
	}
}
