using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIIncubator : MonoBehaviour {

    int menuItemWidth = 100;
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width/2.0f, Screen.height/2.0f, 325.0f, 325.0f));
            GUILayout.BeginHorizontal();

                if (GUILayout.Button("Home", GUILayout.Width(menuItemWidth), GUILayout.Height(100)))
                {
                    //Do something...
                }

                GUILayout.BeginVertical();
                    if (GUILayout.Button("#1", GUILayout.Width(menuItemWidth), GUILayout.Height(22)))
                    {
                        //Do something...
                    }
                    if (GUILayout.Button("#2", GUILayout.Width(menuItemWidth), GUILayout.Height(22)))
                    {
                        //Do something...
                    }
                    if (GUILayout.Button("#3", GUILayout.Width(menuItemWidth), GUILayout.Height(22)))
                    {
                        //Do something...
                    }
                    if (GUILayout.Button("#4", GUILayout.Width(menuItemWidth), GUILayout.Height(22)))
                    {
                    //Do something...
                    }
                GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        GUILayout.EndArea();
    } // End OnGUI()
}


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