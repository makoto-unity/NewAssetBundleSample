using UnityEngine;
using System.Collections;

public class LoadAllAssets : BaseLoader {

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );

		// Load asset.
		AssetBundleManifest manifest = AssetBundleManager.AssetBundleManifestObject;
		string [] bundles = manifest.GetAllAssetBundles();
		foreach( string bundle in bundles ) {
			string assetName = System.IO.Path.GetFileNameWithoutExtension(bundle);
			print ( assetName + ":" + bundle );
			yield return StartCoroutine(Load(bundle,assetName));
			AssetBundleManager.UnloadAssetBundle(bundle);
		}
	}
}
