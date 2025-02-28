﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyRoomMgrCtrl : MonoBehaviour
{
    string currentScene;
    bool isMain = true;

    // 버튼 누를시 변수 넣을 곳
    private GameObject myRoomUI;
    private GameObject mainCamera;
    private GameObject myroomCamera;

    public int setcamera = 0;

    //private CatUI catUI;
    public ObjectCtrl objectCtrl;

    void Start()
    {
        CheckScene();
        myRoomUI = GameObject.Find("MyRoomUI");
        mainCamera = GameObject.Find("MainCamera");
        myroomCamera = GameObject.Find("MyRoomCamera");
        objectCtrl = FindObjectOfType(typeof(ObjectCtrl)) as ObjectCtrl;
        //catUI = gameObject.GetComponent<CatUI>();
        //objectCtrl = gameObject.GetComponent<ObjectCtrl>();
    }

    void Update()
    {
        CheckScene();
        ChangeUI();
    }

    void CheckScene()
    {
        if (setcamera == 0)
        {
            currentScene = "main";
        }
        else
        {
            currentScene = "myroom";
        }
    }

    // 변수 조건 currentState == "main", "myroom"

    void ChangeUI()
    {
        if (currentScene == "main")
        {
            MainUI();
        }
        else if(currentScene == "myroom")
        {
            MyRoomUI();
        }
    }

    void MainUI()
    {
        mainCamera.SetActive(true);
        myroomCamera.SetActive(false);
        myRoomUI.SetActive(false);
       // catUI.enabled = true;
     //objectCtrl.enabled = false;
    }

    void MyRoomUI()
    {
        myroomCamera.SetActive(true);
        mainCamera.SetActive(false);
        myRoomUI.SetActive(true);
        //catUI.enabled = false;
       // objectCtrl.enabled = true;
    }
}
