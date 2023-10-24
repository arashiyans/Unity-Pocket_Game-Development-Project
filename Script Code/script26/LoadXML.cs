using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;
using System.Xml.Serialization;

public class LoadXML : MonoBehaviour {

	public string fileName = "PlayerData.xml";
	public GameObject ParentObject;
	public GameObject DataRow;

	// Use this for initialization
	void Start () {
		LoadData ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadData(){
		string xmlfile = System.IO.File.ReadAllText (fileName);
		XmlDocument xmldoc;
		XmlNodeList xmlnodelist;
		XmlNode xmlnode;
		xmldoc = new XmlDocument ();
		xmldoc.LoadXml (xmlfile);
		xmlnodelist = xmldoc.GetElementsByTagName ("Player");
		for (int i = 0; i <= xmlnodelist.Count - 1; i++) {
			xmlnode = xmlnodelist.Item (i);	
			GameObject temp = GameObject.Instantiate (DataRow);
			temp.transform.SetParent (ParentObject.transform);
			temp.transform.Find ("Nama").GetComponent<Text> ().text = xmlnode.FirstChild.InnerText;
			temp.transform.Find ("Nilai").GetComponent<Text> ().text = xmlnode.FirstChild.NextSibling.InnerText;
		}

	}	

}
