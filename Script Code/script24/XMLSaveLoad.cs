using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XMLSaveLoad : MonoBehaviour {

	public string fileName = "PlayerData2.xml";
	public InputField SaveNama;
	public InputField SaveNilai;
	public InputField LoadNama;
	public InputField LoadNilai;

	XMLStructure playerdata;
	XMLStructureArray playerdataArray;

	// Use this for initialization
	void Start () {
		playerdata = new XMLStructure ();
		playerdataArray = new XMLStructureArray ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void XMLSave(){
		playerdata.Nama = SaveNama.text;		
		playerdata.Nilai = SaveNilai.text;
		playerdataArray.playerdata.Clear ();
		playerdataArray.playerdata.Add (playerdata); 
		playerdataArray.SaveData (fileName);
	}	

	public void XMLLoad(){
		int index = 0;
		playerdataArray = playerdataArray.LoadData(fileName);
		LoadNama.text = playerdataArray.playerdata [index].Nama;
		LoadNilai.text = playerdataArray.playerdata [index].Nilai;
	}	

}
