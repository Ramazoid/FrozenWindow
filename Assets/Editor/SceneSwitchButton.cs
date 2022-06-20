using UnityEditor;
using UnityEngine;
using UnityToolbarExtender;

[InitializeOnLoad]
public class SceneSwitchLeftButton
{

	static SceneSwitchLeftButton()
	{
		ToolbarExtender.LeftToolbarGUI.Add(OnToolbarGUI);
	}

	static void OnToolbarGUI()
	{
		GUILayout.FlexibleSpace();

		if (GUILayout.Button(new GUIContent("Camera", "Select Camera")))
		{
			Selection.activeObject = Camera.main.gameObject;
		}
		if (GUILayout.Button(new GUIContent("Runner", "Select Runner")))
		{
			Selection.activeObject = GameObject.Find("RUNNER_ Variant");
			SceneView.lastActiveSceneView.FrameSelected();
		}
		if (GUILayout.Button(new GUIContent("Selected", "Selected centerr")))
		{
			//Selection.activeObject = GameObject.Find("RUNNER_ Variant");
			SceneView.lastActiveSceneView.FrameSelected();
		}
	}
}