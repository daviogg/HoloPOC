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
		handDraggable = gameObject.GetComponentInParent<HandDraggable>();
	}

	void Start () {
		
	}

	void Update () {
		if (handDraggable.isDragging && isOnFocus)
			Video.Pause();
		
		if(!handDraggable.isDragging && isOnFocus)
			Video.Play();
	}

	public void OnFocusEnter()
	{
		isOnFocus = true;
		Video.Play();
	}

	public void OnFocusExit()
	{
		isOnFocus = false;
		Video.Pause();
	}


}
