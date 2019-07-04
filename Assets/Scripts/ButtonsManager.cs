using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour {

	#region Public Variables

	[Header("Video")]
	[Space(10)]
	public GameObject FirstVideo;
	public GameObject SecondVideo;
	public GameObject ThirdVideo;

	[Header("Video Warnings")]
	[Space(10)]
	public GameObject FirstVideoWarnings;
	public GameObject SecondVideoWarnings;
	public GameObject ThirdVideoWarnings;



	[Header("Transforms")]
	[Space(10)]
	public Transform FirstVideoPosition;
	public Transform SecondVideoPosition;
	public Transform ThirdVideoPosition;

	[Header("Transforms Warnings")]
	[Space(10)]
	public Transform FirstVideoWarningPosition;
	public Transform SecondVideoWarningPosition;
	public Transform ThirdVideoWarningPosition;



	[Header("Buttons")]
	[Space(10)]
	public GameObject FirstButton;
	public GameObject SecondButton;
	public GameObject ThirdButton;

	[Header("Buttons Warnings")]
	[Space(10)]
	public GameObject FirstButtonWarnings;
	public GameObject SecondButtonWarnings;
	public GameObject ThirdButtonWarnings;


	#endregion

	#region Private Variables

	private GameObject InstantiatedObject;

	private GameObject InstantiatedWarningObject;

	#endregion


	#region Methods video
	
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

	#region Methods video warnings

	public void SpawnFirstWarningVideo()
	{
		if (InstantiatedWarningObject != null)
			Destroy(InstantiatedWarningObject);

		if (FirstVideoWarnings != null)
			InstantiatedWarningObject = Instantiate(FirstVideoWarnings, FirstVideoWarningPosition);
	}

	public void SpawnSecondWarningVideo()
	{
		if (InstantiatedWarningObject != null)
			Destroy(InstantiatedWarningObject);

		if (SecondVideoWarnings != null)
			InstantiatedWarningObject = Instantiate(SecondVideoWarnings, FirstVideoWarningPosition);
	}

	public void SpawnThirdWarningVideo()
	{
		if (InstantiatedWarningObject != null)
			Destroy(InstantiatedWarningObject);

		if (ThirdVideoWarnings != null)
			InstantiatedWarningObject = Instantiate(ThirdVideoWarnings, FirstVideoWarningPosition);
	}

	public void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	#endregion






}
