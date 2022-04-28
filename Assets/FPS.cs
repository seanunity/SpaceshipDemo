using UnityEngine;
using System.Collections;

public class FPS : MonoBehaviour 
{
	readonly GUIStyle style = new GUIStyle();
	string label = "";
    int resetFrame = 30, frame = 0;
    float accumulator = 0f;

    void Awake ()
    {
        style.fontSize = 35;
		style.alignment = TextAnchor.MiddleRight;
		style.fontStyle = FontStyle.Bold;
		style.normal.textColor = Color.white;
    }

    void Update ()
	{
        accumulator += 1 / Time.deltaTime;

        if (++frame >= resetFrame)
        {
            label = (accumulator / resetFrame).ToString("F2");

            accumulator = 0f;
            frame = 0;
        }
	}
	
	void OnGUI () => GUI.Label(new Rect(Screen.width - 150, Screen.height - 35, 150, 35), label, style);
}

