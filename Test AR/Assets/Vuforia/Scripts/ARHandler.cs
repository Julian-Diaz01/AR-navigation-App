

using UnityEngine;
using Vuforia;


public class ARHandler : MonoBehaviour, ITrackableEventHandler
{
	#region PROTECTED_MEMBER_VARIABLES

	protected TrackableBehaviour mTrackableBehaviour;
	protected TrackableBehaviour.Status m_PreviousStatus;
	protected TrackableBehaviour.Status m_NewStatus;



	#endregion // PROTECTED_MEMBER_VARIABLES

	#region UNITY_MONOBEHAVIOUR_METHODS
	public static int Test2=0;
	public int BBB = 0;
	public GameObject TestTarget;
	protected virtual void Start()
	{

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
			mTrackableBehaviour.RegisterTrackableEventHandler(this);



	}

	protected virtual void OnDestroy()
	{
		if (mTrackableBehaviour)
			mTrackableBehaviour.UnregisterTrackableEventHandler(this);
	}

	#endregion // UNITY_MONOBEHAVIOUR_METHODS

	#region PUBLIC_METHODS

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		m_PreviousStatus = previousStatus;
		m_NewStatus = newStatus;

		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
		
			OnTrackingFound();
		}
		else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
			newStatus == TrackableBehaviour.Status.NO_POSE)
		{
			
			OnTrackingLost();
		}
		else
		{
		
			OnTrackingLost();
		}
	}

	#endregion // PUBLIC_METHODS

	#region PROTECTED_METHODS

	protected virtual void OnTrackingFound()
	{
		var rendererComponents = GetComponentsInChildren<Renderer>(true);
		var colliderComponents = GetComponentsInChildren<Collider>(true);
		var canvasComponents = GetComponentsInChildren<Canvas>(true);

		// Enable rendering:
		foreach (var component in rendererComponents)
			component.enabled = true;

		// Enable colliders:
		foreach (var component in colliderComponents)
			component.enabled = true;

		// Enable canvas':
		foreach (var component in canvasComponents)
			component.enabled = true;


		Test2++;
		print ("Test2=" + Test2);
		BBB= 5 ;
		//	Test123 ();


	}


	protected virtual void OnTrackingLost()
	{
		var rendererComponents = GetComponentsInChildren<Renderer>(true);
		var colliderComponents = GetComponentsInChildren<Collider>(true);
		var canvasComponents = GetComponentsInChildren<Canvas>(true);

		// Disable rendering:
		foreach (var component in rendererComponents)
			component.enabled = false;

		// Disable colliders:
		foreach (var component in colliderComponents)
			component.enabled = false;

		// Disable canvas':
		foreach (var component in canvasComponents)
			component.enabled = false;
	}

	#endregion // PROTECTED_METHODS
}

