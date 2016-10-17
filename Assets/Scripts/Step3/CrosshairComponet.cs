using UnityEngine;
using System.Collections;

public class CrosshairComponet : MonoBehaviour {
	public Texture CrossHairTexture=null;
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void OnApplicationFocus (bool focusStatus) {
		if (focusStatus) {
			Screen.lockCursor=true;
		}
	}

	void OnGUI()
	{
		if (CrossHairTexture != null) {
			GUI.color=new Color(1,1,1,0.8f);
			Rect drawrect=new Rect(
				(Screen.width*0.5f)-(CrossHairTexture.width*0.5f),
				(Screen.height*0.5f)-(CrossHairTexture.height*0.5f),
				CrossHairTexture.width,
				CrossHairTexture.height
				);
			GUI.DrawTexture(drawrect,CrossHairTexture);
			GUI.color=Color.white;
		}
	}
}
