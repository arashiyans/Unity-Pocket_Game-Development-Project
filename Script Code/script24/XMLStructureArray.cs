using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot("XMLStructureArray")]
public class XMLStructureArray {

	[XmlArray("XMLStructureArray"),XmlArrayItem("XMLStructure")]
	public List<XMLStructure> playerdata = new List<XMLStructure>();

	public void SaveData (string path) {
		var serializer = new XmlSerializer(typeof(XMLStructureArray));
		var stream = new FileStream(path, FileMode.Create);
		serializer.Serialize(stream, this);
		stream.Close();
	}

	public XMLStructureArray LoadData (string path){
		XMLStructureArray result = new XMLStructureArray();
		var serializer = new XmlSerializer(typeof(XMLStructureArray));
		var stream = new FileStream(path, FileMode.Open);
		result = serializer.Deserialize(stream) as XMLStructureArray;
		stream.Close();
		return result; 
	}
}