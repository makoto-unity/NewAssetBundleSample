using UnityEngine;
using UnityEditor;
using System.Collections;

public class BuildAB  
{
	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles ()
	{
		BuildPipeline.BuildAssetBundles ("AssetBundles");
	}
}
