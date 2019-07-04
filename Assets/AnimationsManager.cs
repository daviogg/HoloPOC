using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsManager : MonoBehaviour {

	[Header("Video tutorial")]
	[Space(10)]
	public Animator FirstButtonAnimator;
	public Animator SecondButtonAnimator;
	public Animator ThirdButtonAnimator;


	[Header("Video warning")]
	[Space(10)]
	public Animator FirstButtonWarningAnimator;
	public Animator SecondButtonWarningAnimator;
	public Animator ThirdButtonWarningAnimator;

	[Header("New Player video")]
	[Space(10)]
	public GameObject WarningsButton;
	public GameObject PlayerVideoWarnings;
	public Transform secondPlayerSpawn;

	private  GameObject PlayerInstanciated;


	private bool forward = true;

	private void Awake()
	{
		InitializeAnimation();
		InitializeWarningAnimation();
	}

	private void InitializeWarningAnimation()
	{
		FirstButtonWarningAnimator.speed = 0;
		SecondButtonWarningAnimator.speed = 0;
		ThirdButtonWarningAnimator.speed = 0;
	}

	private void InitializeAnimation()
	{
		FirstButtonAnimator.speed = 0;
		SecondButtonAnimator.speed = 0;
		ThirdButtonAnimator.speed = 0;
	}


	#region public methods

	public void StartAnimation()
	{
		SetSpeedToOne();
		#region stuff
		//if (!forward)
		//{
		//	FirstButtonAnimator.SetFloat("rewind", -1f);
		//	SecondButtonAnimator.SetFloat("rewind", -1f);
		//	ThirdButtonAnimator.SetFloat("rewind", -1f);
		//	forward = true;
		//}
		//else
		//{

		//	FirstButtonAnimator.SetFloat("rewind", 1f);
		//	SecondButtonAnimator.SetFloat("rewind", 1f);
		//	ThirdButtonAnimator.SetFloat("rewind", 1f);
		//	forward = false;
		//}
		#endregion
	}

	public void StartAnimationWarning()
	{
		SetSpeedWarningToOne();
	}

	public void NewPlayerVideo()
	{
		WarningsButton.SetActive(false);
		PlayerVideoWarnings.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.0f ;
		PlayerVideoWarnings.SetActive(true);
		
	}

	#endregion



	#region private methods
	private void SetSpeedToOne()
	{
		FirstButtonAnimator.speed = 1;
		SecondButtonAnimator.speed = 1;
		ThirdButtonAnimator.speed = 1;
	}

	private void SetSpeedWarningToOne()
	{
		FirstButtonWarningAnimator.speed = 1;
		SecondButtonWarningAnimator.speed = 1;
		ThirdButtonWarningAnimator.speed = 1;
	}

	#endregion





}
