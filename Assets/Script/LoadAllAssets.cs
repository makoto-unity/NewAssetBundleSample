using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadAllAssets : BaseLoader {

	// Use this for initialization
	IEnumerator Start () {

		yield return StartCoroutine(Initialize() );
	}
}
