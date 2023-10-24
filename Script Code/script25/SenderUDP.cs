using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Text;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SenderUDP : MonoBehaviour {

	static UdpClient sender;
	public int PubRemotePort;
	public int PubHostPort;
	public static int remotePort; 
	public static int hostPort;
	public InputField SendNama;
	public InputField SendNilai;

	public void Awake(){
		remotePort = PubRemotePort;
		hostPort = PubHostPort;
		initIP ();
	}

	public static void initIP()
	{
		sender = new UdpClient (hostPort, AddressFamily.InterNetwork);
		IPEndPoint groupEP = new IPEndPoint (IPAddress.Broadcast, remotePort);
		sender.Connect (groupEP);
	}

	public static void SendData (string DataMessage)
	{
		string customMessage = DataMessage;
		if (customMessage != "") {
			sender.Send (Encoding.ASCII.GetBytes (customMessage), customMessage.Length);
		}
	}

	public void ZipData (){
		string data;
		data = SendNama.text + "#" + SendNilai.text;
		SendData (data);
	}
}
