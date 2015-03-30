using UnityEditor;
using UnityEngine;
using System.Collections;

// Postprocesses all textures that are placed in a folder
// "invert color" to have their colors inverted.
public class CsutomImporter : AssetPostprocessor {
	void OnPostprocessTexture(Texture2D texture) {

		assetImporter.assetBundleName = assetPath;
		Debug.Log("change! asset bundle :" + assetImporter.assetBundleName);
	}
}