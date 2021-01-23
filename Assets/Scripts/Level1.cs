﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour
{
     public void PlayPressed()
     {
         SceneManager.LoadScene("SampleScene");
     }
   
     public void ExitPressed()
     {
         Application.Quit();
     }
}


