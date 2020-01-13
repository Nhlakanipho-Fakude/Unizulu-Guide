using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;

class inputBox : EditorWindow {

	public string valueSearch;

	void OnGUI() {
		valueSearch = EditorGUILayout.TextField("Search", valueSearch);

		if (GUILayout.Button("Search")) {
			OnClickSavePrefab();
			GUIUtility.ExitGUI();
		}
	}

	void OnClickSavePrefab() {
		valueSearch = valueSearch.Trim();

		if (string.IsNullOrEmpty (valueSearch)) {
			EditorUtility.DisplayDialog ("Unable to search", "Please provide a valid input.", "Close");
			return;
		} 
		// You may also want to check for illegal characters :)

		// Save your prefab

		Close();
	}

}
#endif