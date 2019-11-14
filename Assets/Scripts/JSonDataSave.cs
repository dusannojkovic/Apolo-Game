using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using SimpleJSON;

public class JSonDataSave : MonoBehaviour {

	public Text name;


	// void Start () {
	// 	name = GetComponent<Text>();
	// }

	public void Save()
	{

		JSONObject jsonName = new JSONObject();
		jsonName.Add("Username", name.text);
		// string path = Application.persistentDataPath + "/JsonData.json";
		// File.WriteAllText(path,jsonName.ToString());
		
	}
	public void Load()
	{

	}
	// // Use this for initialization
	// void Start () {
		
	// }
	
	// // Update is called once per frame
	// void Update () {
		
	// }
}
