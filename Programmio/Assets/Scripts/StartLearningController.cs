using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLearningController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject CourseOverview;
    public GameObject CourseList;
    public void SwitchToCourseList()
    {
        CourseOverview.SetActive(false);
        CourseList.SetActive(true);
    }
}
