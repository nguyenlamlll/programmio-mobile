using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void EnableCourseInformation() {
        transform.parent.parent.Find("Overlay").gameObject.SetActive(true);
        transform.parent.parent.Find("CoursePanel").gameObject.SetActive(true);
        transform.parent.parent.Find("CoursePanel").Find("CourseOverview").gameObject.SetActive(true);
        transform.parent.parent.Find("CoursePanel").Find("CourseList").gameObject.SetActive(false);
    }
}
