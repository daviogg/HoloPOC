using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour {

	#region Public Variables

	[Header("Video")]
	[Space(10)]
	public GameObject FirstVideo;
	public GameObject SecondVideo;
	public GameObject ThirdVideo;

	[Header("Transforms")]
	[Space(10)]
	public Transform FirstVideoPosition;
	public Transform SecondVideoPosition;
	public Transform ThirdVideoPosition;

	[Header("Buttons")]
	[Space(10)]
	public GameObject FirstButton;
	public GameObject SecondButton;
	public GameObject ThirdButton;

	#endregion

	#region Private Variables

	private GameObject InstantiatedObject;

	#endregion


	#region Methods
	
	public void SpawnFirstVideo()
	{
		if(InstantiatedObject != null)
			Destroy(InstantiatedObject);
		
		if(FirstVideo != null)
			InstantiatedObject = Instantiate(FirstVideo, FirstVideoPosition);
	}

	public void SpawnSecondVideo()
	{
		if (InstantiatedObject != null)
			Destroy(InstantiatedObject);

		if(SecondVideo != null)
		InstantiatedObject = Instantiate(SecondVideo, FirstVideoPosition);
	}

	public void SpawnThirdVideo()
	{
		if (InstantiatedObject != null)
			Destroy(InstantiatedObject);

		if(ThirdVideo != null)
		InstantiatedObject = Instantiate(ThirdVideo, FirstVideoPosition);
	}

	#endregion




}
