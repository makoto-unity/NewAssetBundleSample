using UnityEngine;
using System.Collections;

public class LoadAssets : BaseLoader {

	public string assetBundleName = "cube.unity3d";
	public string assetName = "cube";

	public GameObject cube;

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );

		yield return new WaitForSeconds(3.0f);
		// Load asset.
		yield return StartCoroutine(LoadAs<Texture> (assetBundleName, assetName) );

//		yield return new WaitForSeconds(1.0f);
//		yield return StartCoroutine(LoadAs<Texture> (assetBundleName, assetName) );

		// Unload assetBundles.
		AssetBundleManager.UnloadAssetBundle(assetBundleName);
	}
}
