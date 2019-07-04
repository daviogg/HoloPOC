using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerManager : MonoBehaviour, IFocusable {

	public VideoPlayer Video;

	private HandDraggable handDraggable;
	private bool isOnFocus;
	private void Awake()
	{
		handDraggable = gameObject.transform.parent.transform.gameObject.GetComponentInParent<HandDraggable>();
	}

	void Start () {
		
	}

	void FixedUpdate () {
		if (handDraggable.isDraggingUpdate && isOnFocus && Video.isPlaying)
			Video.Pause();
		
		if(!handDraggable.isDraggingUpdate && isOnFocus && !Video.isPlaying)
			Video.Play();
	}

	public void OnFocusEnter()
	{
		isOnFocus = true;
		//Video.Play();
	}

	public void OnFocusExit()
	{
		isOnFocus = false;
		Video.Pause();
	}


}
