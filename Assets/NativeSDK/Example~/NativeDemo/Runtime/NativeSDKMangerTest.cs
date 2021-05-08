using System;
using Native.SDK;
using UnityEngine;

public class NativeSDKMangerTest : MonoBehaviour
{
	public void Awake()
	{
		SpeechToText.Init();
		TextToSpeech.Init();
	}
}
