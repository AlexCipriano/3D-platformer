using UnityEngine;
using System.Collections;

public class examplescene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = (Material)Resources.Load("Skybox3");
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		int x = 50;
		int y = 50;
		int dy = 40;
		int cnt = 0;
		int sx = 300;
		int sy = 30;
		if (GUI.Button(new Rect(x, y+dy*cnt++, sx, sy), "Skybox 1 - hubble deep field")) {
			RenderSettings.skybox = (Material)Resources.Load("Skybox1");
		}
		
		
	}
}
