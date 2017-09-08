using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestGUI : MonoBehaviour
{
    TheDash td;
    int gameMenu;
    float buttonWidth;
    float buttonHeight;
    float buttonSpace;
    float menuWidth;
    float menuHeight;
 
	void Start()
    {
        td = GameObject.FindGameObjectWithTag("The Dash").
 GetComponent<TheDash>();

        gameMenu = 0;
        buttonWidth = 60.0f;
        buttonHeight = 30.0f;
        buttonSpace = 10.0f;
        menuWidth = 150.0f;
        menuHeight = 250.0f;
    }

    void OnGUI()
    {
        //GUILayout.BeginHorizontal();
        //GUILayout.FlexibleSpace();
        //GUILayout.BeginVertical(); 
        //GUILayout.FlexibleSpace();

        //if(GUILayout.Button("Save Game"))
        //      {
        //	GetComponent<DataInserter> ().enabled = true;
        //	return;
        //}

        //if(GUILayout.Button("Load Game"))
        //      {
        //	GetComponent<DataLoader>().enabled = true;
        //	return;
        //}

        //      //if (GUILayout.Button("Incubator"))
        //      //{
        //      //    SceneManager.LoadSceneAsync("Incubator");
        //      //}

        //      GUILayout.FlexibleSpace();
        //GUILayout.EndVertical();
        //GUILayout.FlexibleSpace();
        //GUILayout.EndHorizontal();
        switch (gameMenu)
        {
            case 0: // Main Hand Menu
                //GUILayout.BeginArea(new Rect(Screen.width / 2.0f - menuWidth, Screen.height / 2.0f - menuHeight, menuWidth, menuHeight));
                GUILayout.BeginArea(new Rect(Screen.width / 2.0f - menuWidth, Screen.height / 2.0f - menuHeight, 325.0f, 325.0f));
                GUILayout.BeginHorizontal();
                if (GUILayout.Button("Incubator", GUILayout.Width(100), GUILayout.Height(100)))
                {
                    SceneManager.LoadSceneAsync("Incubator");
                }
                GUILayout.BeginVertical();
                if (GUILayout.Button("File", GUILayout.Width(100), GUILayout.Height(22)))
                {
                    gameMenu = 1;
                }
                if (GUILayout.Button("Dash Toggle", GUILayout.Width(100), GUILayout.Height(22)))
                {
                    td.ToggleActive();
                }
                if (GUILayout.Button("Account", GUILayout.Width(100), GUILayout.Height(22)))
                {
                    gameMenu = 2;
                }
                if (GUILayout.Button("Settings", GUILayout.Width(100), GUILayout.Height(22)))
                {
                    gameMenu = 3;
                }
                GUILayout.EndVertical();

                //GUILayout.BeginVertical();
                //    if (GUILayout.Button("Save", GUILayout.Width(100), GUILayout.Height(18)))
                //    {

                //    }
                //    if (GUILayout.Button("Open", GUILayout.Width(100), GUILayout.Height(18)))
                //    {

                //    }
                //    if (GUILayout.Button("Recents", GUILayout.Width(100), GUILayout.Height(18)))
                //    {

                //    }
                //    if (GUILayout.Button("New", GUILayout.Width(100), GUILayout.Height(18)))
                //    {

                //    }
                //    if (GUILayout.Button("Close", GUILayout.Width(100), GUILayout.Height(18)))
                //    {

                //    }
                //GUILayout.EndVertical();

                GUILayout.EndHorizontal();
                GUILayout.EndArea();

                //GUIStyle gsAlterQuest = new GUIStyle();
                //gsAlterQuest.normal.background = MakeTex(600, 1, new Color(1.0f, 1.0f, 1.0f, 0.1f));
                //GUIStyle gsAlterQuestTwo = new GUIStyle();
                //gsAlterQuestTwo.normal.background = MakeTex(600, 1, new Color(100.0f, 100.0f, 100.0f, 0.5f));

                //for (int i = 0; i < 10; i++)
                //{
                //    if (i % 2 == 0)
                //        GUILayout.BeginHorizontal(gsAlterQuest);
                //    else
                //        GUILayout.BeginHorizontal(gsAlterQuestTwo);
                //    GUILayout.Label("EPIC WIN!!!");
                //    GUILayout.EndHorizontal();
                //}
                break;
            case 1: // File
                GUILayout.BeginArea(new Rect(Screen.width / 2.0f - menuWidth, Screen.height / 2.0f - menuHeight, 325.0f, 325.0f));
                    GUILayout.BeginHorizontal();
                        if (GUILayout.Button("Incubator", GUILayout.Width(100), GUILayout.Height(100)))
                        {
                            SceneManager.LoadSceneAsync("Incubator");
                        }
                        GUILayout.BeginVertical();
                            if (GUILayout.Button("File", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Dash Toggle", GUILayout.Width(100), GUILayout.Height(22)))
                            {
                                td.ToggleActive();
                            }
                            if (GUILayout.Button("Account", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Settings", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                        GUILayout.EndVertical();
                        GUILayout.BeginVertical();
                            if (GUILayout.Button("Save", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Open", GUILayout.Width(100), GUILayout.Height(22)))
                            {
                                td.ToggleActive();
                            }
                            if (GUILayout.Button("Recents", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("New", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Close", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                        GUILayout.EndVertical();
                    GUILayout.EndHorizontal();
                GUILayout.EndArea();
                break;
            case 2: // Account
                GUILayout.BeginArea(new Rect(Screen.width / 2.0f - menuWidth, Screen.height / 2.0f - menuHeight, 325.0f, 325.0f));
                    GUILayout.BeginHorizontal();
                        if (GUILayout.Button("Incubator", GUILayout.Width(100), GUILayout.Height(100)))
                        {
                            SceneManager.LoadSceneAsync("Incubator");
                        }
                        GUILayout.BeginVertical();
                            if (GUILayout.Button("File", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Dash Toggle", GUILayout.Width(100), GUILayout.Height(22)))
                            {
                                td.ToggleActive();
                            }
                            if (GUILayout.Button("Account", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Settings", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                        GUILayout.EndVertical();
                        GUILayout.BeginVertical();
                            if (GUILayout.Button("Profile", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Activity", GUILayout.Width(100), GUILayout.Height(22)))
                            {
                                // td.ToggleActive();
                            }
                            if (GUILayout.Button("Orders", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Payment", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Membership", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                        GUILayout.EndVertical();
                    GUILayout.EndHorizontal();
                GUILayout.EndArea();
                break;
            case 3: // Settings
                GUILayout.BeginArea(new Rect(Screen.width / 2.0f - menuWidth, Screen.height / 2.0f - menuHeight, 325.0f, 325.0f));
                    GUILayout.BeginHorizontal();
                            if (GUILayout.Button("Incubator", GUILayout.Width(100), GUILayout.Height(100)))
                            {
                                SceneManager.LoadSceneAsync("Incubator");
                            }
                            GUILayout.BeginVertical();
                            if (GUILayout.Button("File", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Dash Toggle", GUILayout.Width(100), GUILayout.Height(22)))
                            {
                                td.ToggleActive();
                            }
                            if (GUILayout.Button("Account", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Settings", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                        GUILayout.EndVertical();
                        GUILayout.BeginVertical();
                            if (GUILayout.Button("Lighting", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Preferences", GUILayout.Width(100), GUILayout.Height(22)))
                            {
                                // td.ToggleActive();
                            }
                            if (GUILayout.Button("Privacy", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Mode", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                            if (GUILayout.Button("Connections", GUILayout.Width(100), GUILayout.Height(22)))
                            {

                            }
                        GUILayout.EndVertical();
                    GUILayout.EndHorizontal();
                GUILayout.EndArea();
                break;
            default:
                break;
        }
        
    }

    private Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];

        for (int i = 0; i < pix.Length; i++)
            pix[i] = col;

        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();

        return result;
    }

}
