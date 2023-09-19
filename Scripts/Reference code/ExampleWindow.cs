using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    string myString = "Hello, world!";

    [MenuItem("Window/Example")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<ExampleWindow>("Example");
    }

    void OnGUI()
    {
        GUILayout.Label("This is a label.", EditorStyles.boldLabel);

        EditorGUILayout.TextField("Name", myString);

        if(GUILayout.Button("Press me"))
        {
            Debug.Log("Button was pressed");
            CreateScene(myString);
        }
    }

    public void CreateScene(string _string)
    {
        Scene newScene = SceneManager.CreateScene(_string);
    }

    //Selection.gameObjects
}
