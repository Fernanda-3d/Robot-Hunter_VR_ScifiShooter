using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XR_Setup : MonoBehaviour
{
    /* Setting up the VR - Unity 2021.1.12f1

obs: *........* =  (only if you want to test without headseat)

1 - Edit - Project Settings - XR Plugin Management - Install XR Plugin Management
2 - Package Manager - enable Preview Packages - click in I understand 
3 - Window - Package Manager - Unity Registry - 
    3.1 - Install Open XR Plugin (this one is going to ask you to confirm to change your Input                  System to the new 2020/2021 version and restart the software)
     3.2 - Install XR Interation Toolkit
         3.2.1 - Click on Samples - Import Default Input Actions 
       * 3.2.2 - Import XR Device Simulator*
4 - Edit - Project Settings - XR Plugin Management - XR Plugin Management
     4.1 - Click on OpenXR - Fix problems 
     4.2 - Click on Oculus - wait install plugins    - leave checked 
     *4.3 - Click on Mock HMD Loader - wait install plugins - leave checked*
5  - Project Settings  - Quality (to help optimize the project)
Pixel Light Count - 1
Anistropic Textures - Per Texture
Anti Aliasing - 4x Multi Sampling
Soft Particles - uncheck
5  - Project Settings  - Preset Manager - (no pressets yet)
      5.1 - Go to the project - Assets - Samples - XR Interation Toolkit - 1.0.0-pre.4 - Default Input Actions - Click in each one of the XRI Default and click and Add Action Based...(5 files with sliders symbols)
      5.1.1 - Click on XRI Default Input Actions(third file with a blue thunder symbol)
6 - Project Settings  - Preset Manager - ActionBasedController - Type Right and Left in the Filter space - make sure matches with the Preset 

7 - In the Hierarchy - left click - XR - XR Rig(Action Based) 
7.1 - In the XR Rig game object  - Add Component - Input Action Manager (Script) - click in Action Assets - Drag the XRI Default Input Actions(third file with a blue thunder symbol) in the 0 element
*7.2 - Search XR Device Simulator - Drag the prefab in the scene*



      */
}
