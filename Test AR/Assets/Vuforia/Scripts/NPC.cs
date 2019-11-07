using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

	//Initilise Navigation Mesh Agent
	private UnityEngine.AI.NavMeshAgent agent;


	//Player Target for AI NPC
	//private GameObject target;
	public GameObject ArrowO;
	public GameObject NPC1;

	private float rayLength = 20f;	


	//WayPoint Destination for AI NPC
	protected Vector3 destPos;

	//WayPoints for AI NPC
	GameObject[] pointList1;
	GameObject[] pointList2;
	GameObject[] pointList3;
	GameObject[] pointList4;
	GameObject[] pointList5;
	GameObject[] pointList6;
	GameObject[] pointList7;
	GameObject[] pointList8;
	GameObject[] pointList9;
	GameObject[] DES1;
	GameObject[] DES2;
	GameObject[] DES3;


	//NPC state 
	public enum FSMState
	{
		None,
		Patrol,
	}
		
	//NPC Current State
	public FSMState curState;

	//Store current & last NPC destination 
	private int navPointIndex;
	private int lastNavPoint;


	void Awake () {

		//Set initial state to 'Patrol'
		curState = FSMState.Patrol;

		//Get the list of points
		DES1 = GameObject.FindGameObjectsWithTag ("Destination1");
		DES2 = GameObject.FindGameObjectsWithTag ("Destination2");
		DES3 = GameObject.FindGameObjectsWithTag ("Destination3");
		pointList1 = GameObject.FindGameObjectsWithTag ("Waypoint1");
		pointList2 = GameObject.FindGameObjectsWithTag ("Waypoint2");
		pointList3 = GameObject.FindGameObjectsWithTag ("Waypoint3");
		pointList4 = GameObject.FindGameObjectsWithTag ("Waypoint4");
		pointList5 = GameObject.FindGameObjectsWithTag ("Waypoint5");
		pointList6 = GameObject.FindGameObjectsWithTag ("Waypoint6");
		pointList7 = GameObject.FindGameObjectsWithTag ("Waypoint7");
		pointList8 = GameObject.FindGameObjectsWithTag ("Waypoint8");
		pointList9 = GameObject.FindGameObjectsWithTag ("Waypoint9");

		//Set Random destination point


		//Setup Nav Mesh Agent 
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		//Set Player as a target

	}
		
	public int future =0;
	void Update () {	
		ActualPosition ();
		Destination1();
		FSMUpdate (); 
		checkRayHitPlayer ();
		//PathReset ();
		future++;
	
	


		//State Machine Update
	}

	void FSMUpdate(){ 	//Determime the current state 

		switch (curState) {
		case FSMState.Patrol:
			UpdatePatrolState ();
			break;
	//	case FSMState.Chase:
		//	UpdateChaseState ();
		//	break;
		}
	}
	void PathReset(){
		if(future>=200){
	agent.ResetPath ();
			future = 0;
	}
	}
	void Destination1() {
		
	

		if (Input.GetKeyDown("a")) {
		
			print ("DESTINATION_1" + destPos);
			navPointIndex = 0;
			destPos = DES1 [navPointIndex].transform.position;
			agent.SetDestination(destPos);
		}

		if (Input.GetKeyDown("s")) {

			print ("DESTINATION_2" + destPos);
			navPointIndex = 0;
			destPos = DES2 [navPointIndex].transform.position;
			agent.SetDestination(destPos);
		}

		if (Input.GetKeyDown("d")) {

			print ("DESTINATION_3" + destPos);
			navPointIndex = 0;
			destPos = DES3 [navPointIndex].transform.position;
			agent.SetDestination(destPos);
		}	
	}
	
	protected Vector3 ActualPos;
	void ActualPosition() {

		NPC1 = GameObject.FindGameObjectWithTag ("NPC1");


		if (GameObject.Find ("Image1").GetComponent<ARHandler1> ().AAA == 5) {
			navPointIndex = 0;
			ActualPos = pointList1 [navPointIndex].transform.position;
			GameObject.Find ("Image1").GetComponent<ARHandler1> ().AAA = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_1" + ActualPos);
		}
		if (GameObject.Find ("Image2").GetComponent<ARHandler2> ().BBB == 10) {
			navPointIndex = 0;
			ActualPos = pointList2 [navPointIndex].transform.position;
			GameObject.Find ("Image2").GetComponent<ARHandler2> ().BBB = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_2" + ActualPos);
		}

		if (GameObject.Find ("Image3").GetComponent<ARHandler3> ().CCC == 15) {
			navPointIndex = 0;
			ActualPos = pointList3 [navPointIndex].transform.position;
			GameObject.Find ("Image3").GetComponent<ARHandler3> ().CCC = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_3" + ActualPos);
		}

		if (GameObject.Find ("Image4").GetComponent<ARHandler4> ().DDD == 20) {
			navPointIndex = 0;
			ActualPos = pointList4 [navPointIndex].transform.position;
			GameObject.Find ("Image4").GetComponent<ARHandler4> ().DDD = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_4" + ActualPos);
		}

		if (GameObject.Find ("Image5").GetComponent<ARHandler5> ().EEE == 25) {
			navPointIndex = 0;
			ActualPos = pointList5 [navPointIndex].transform.position;
			GameObject.Find ("Image5").GetComponent<ARHandler5> ().EEE = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_5" + ActualPos);
		}
		if (GameObject.Find ("Image6").GetComponent<ARHandler6> ().FFF == 30) {
			navPointIndex = 0;
			ActualPos = pointList6 [navPointIndex].transform.position;
			GameObject.Find ("Image6").GetComponent<ARHandler6> ().FFF = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_6" + ActualPos);
		}

		if (GameObject.Find ("Image7").GetComponent<ARHandler7> ().GGG == 35) {
			navPointIndex = 0;
			ActualPos = pointList7 [navPointIndex].transform.position;
			GameObject.Find ("Image7").GetComponent<ARHandler7> ().GGG = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_7" + ActualPos);
		}

		if (GameObject.Find ("Image8").GetComponent<ARHandler8> ().HHH == 40) {
			navPointIndex = 0;
			ActualPos = pointList8 [navPointIndex].transform.position;
			GameObject.Find ("Image8").GetComponent<ARHandler8> ().HHH = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_8" + ActualPos);
		}

		if (GameObject.Find ("Image9").GetComponent<ARHandler9> ().III == 45) {
			navPointIndex = 0;
			ActualPos = pointList9 [navPointIndex].transform.position;
			GameObject.Find ("Image9").GetComponent<ARHandler9> ().III = 0;
			NPC1.transform.position = ActualPos;
			agent.SetDestination(destPos);
			print ("IMAGE_9" + ActualPos);
		}






	}
public Transform arr;
	void UpdatePatrolState (){}
		
	public bool checkRayHitPlayer(){

		//Visualise Raycast from NPC
	Vector3 Or = new Vector3(0,0,0);
	Vector3 fwd = transform.TransformDirection (Vector3.forward) * rayLength;
	Debug.DrawRay (Or, fwd, Color.red); //(origin,vectors direction,color)


	// Arrow direction took from the characters movement
	
	ArrowO = GameObject.FindGameObjectWithTag ("Arrow1");
	Quaternion rotation = Quaternion.LookRotation (-fwd, Vector3.up);
	ArrowO.transform.rotation = rotation;
	ArrowO.transform.Rotate (90,0,0);


		//Check if Raycast has hit Player tagged object	


			return true;  //yes

	}
}