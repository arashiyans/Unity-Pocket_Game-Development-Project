using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ListenerUDP : MonoBehaviour {

	UdpClient receiver;
	public int PubHostPort;
	public static int hostPort;
	public string receivedString;
	public static bool Activate;
	bool isReceived = false;
	public Toggle toggle;
	public InputField ListenNama;
	public InputField ListenNilai;

	// Use this for initialization
	void Awake () {
		hostPort = PubHostPort;
	}

	// Update is called once per frame
	void Update () {
		if (Activate) {
			StartReceivingIP ();
			if (isReceived) {
				isReceived = false;
				UnZipData (receivedString);
			}
		}
	}

	public void ToggleListener(){
		ListenerUDP.Activate = toggle.isOn; 
	}

	public void StartReceivingIP ()
	{
		try {
			if (receiver == null) {
				receiver = new UdpClient (hostPort);
				receiver.BeginReceive (new AsyncCallback (ReceiveData), null);
			}
		} catch (SocketException e) {
			Debug.Log (e.Message);
		}
	}

	private void ReceiveData (IAsyncResult result)
	{
		IPEndPoint receiveIPGroup = new IPEndPoint (IPAddress.Any, hostPort);
		byte[] received;
		if (receiver != null) {
			received = receiver.EndReceive (result, ref receiveIPGroup);
		} else {
			return;
		}
		receiver.BeginReceive (new AsyncCallback (ReceiveData), null);
		receivedString = Encoding.ASCII.GetString (received);
		isReceived = true;
	}

	void UnZipData (string rcv){
		string[] temp = rcv.Split ('#');
		ListenNama.text = temp [0];
		ListenNilai.text = temp [1];
	}

}
