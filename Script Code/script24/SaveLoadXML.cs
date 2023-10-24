using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;
using System.Xml.Serialization;

public class SaveLoadXML : MonoBehaviour {

	public string fileName = "PlayerData.xml";
	public InputField SaveNama;
	public InputField SaveNilai;
	public InputField LoadNama;
	public InputField LoadNilai;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SaveXML(){
		var sr = File.CreateText (fileName);
		sr.WriteLine ("<PlayerCollection>");
		sr.WriteLine ("<Player>");
		sr.WriteLine ("\t<Nama>"+SaveNama.text+"</Nama>");
		sr.WriteLine ("\t<Nilai>"+SaveNilai.text+"</Nilai>");
		sr.WriteLine ("</Player>");
		sr.WriteLine ("</PlayerCollection>");
		sr.Close ();
	}

	public void LoadXML(){
		string xmlfile = System.IO.File.ReadAllText (fileName);
		XmlDocument xmldoc;
		XmlNodeList xmlnodelist;
		XmlNode xmlnode;
		xmldoc = new XmlDocument ();
		xmldoc.LoadXml (xmlfile);
		xmlnodelist = xmldoc.GetElementsByTagName ("Player");
		for (int i = 0; i <= xmlnodelist.Count - 1; i++) {
			xmlnode = xmlnodelist.Item (i);	
			LoadNama.text = xmlnode.FirstChild.InnerText;
			LoadNilai.text = xmlnode.FirstChild.NextSibling.InnerText;
		}

	}	

}
