# EasyInputs
XR Inputs Done Easily.
# Documentation

Easy Hand Let's You Select Which Hand You Want To Get The Input From,
There Are Two Values. LeftHand And RightHand
Here Are Some Examples On How To Use It


![RightHand](https://user-images.githubusercontent.com/104727812/206534907-c3d7eb3f-4f4f-4e9b-97c6-c3c840188f67.png)

![LeftHand](https://user-images.githubusercontent.com/104727812/206534910-96358b1d-f2f2-4c29-b9e4-c60cc7fba729.png)

You Can Also Do A Value That You Can Edit In The Unity Editor

![Value](https://user-images.githubusercontent.com/104727812/206534902-9097e8a1-393e-4bf7-8f05-3331a9b1e1aa.png)

![HandAnimations](https://user-images.githubusercontent.com/104727812/206535108-a717fc40-3e10-4eab-898e-1b8ced3dc913.png)


You Need To Use easyInputs If You Wanna Use EasyInputs!

```cs 
using easyInputs;
```

If The Grip Button Is Down/Pressed. 

```cs 
EasyInputs.GetGripButtonDown(EasyHand easyHand);
```

Get's If The Trigger Button Is Down/Pressed. 

```cs 
EasyInputs.GetTriggerButtonDown(EasyHand easyHand);
```

Get's If The Trigger Button Is Touched. Only Works On Quest And You Need To Build For It To Work

```cs 
EasyInputs.GetTriggerButtonTouched(EasyHand easyHand);
```

Get's The Grip Float.

```cs 
EasyInputs.GetGripButtonFloat(EasyHand easyHand);
```

Get's The Trigger Float.

```cs 
EasyInputs.GetTriggerButtonFloat(EasyHand easyHand);
```

Get's If The Primary Button is Down/Pressed. Example. A & X Button On Quest

```cs 
EasyInputs.GetPrimaryButtonDown(EasyHand easyHand);
```

Get's If The Primary Button Is Touched. Example. A & X Button On Quest
```cs 
EasyInputs.GetPrimaryButtonTouched(EasyHand easyHand);
```

Get's If The Secondary Button Is Down. Example. B & Y Button On Quest
```cs 
EasyInputs.GetSecondaryButtonDown(EasyHand easyHand);
```

Get's If The Secondary Button Is Touched. Example. B & Y Button On Quest
```cs 
EasyInputs.GetSecondaryButtonTouched(EasyHand easyHand);
```
Get's If The Thumbstick Is Down/Pressed.
```cs 
EasyInputs.GetThumbStickButtonDown(EasyHand easyHand);
```

Get's If The Thumbstick Is Touched.
```cs 
EasyInputs.GetThumbStickButtonTouched(EasyHand easyHand);
```

Get's The Thumbsticks Vector2, This Can Be Used For Movement And Turning
```cs 
EasyInputs.GetThumbStick2DAxis(EasyHand easyHand);
```

Vibrates the Controller
```cs 
StartCoroutine(EasyInputs.Vibration(easyHand, 0.15f, 0.15f))
```
# How To Use

To Use A Button Down Function You Need To Do A If Statement
```cs 
if (EasyInputs.GetThumbStickButtonDown(EasyHand.RightHand))
{
  Jump();
}
```
Or You Can Make It Equal A Boolean
```cs 
bool CanJump = EasyInputs.GetThumbStickButtonDown(EasyHand.RightHand);
```

To Use A Button Float Function You Need To Make A Float
```cs 
float GripValue = EasyInputs.GetGripButtonFloat(EasyHand.LeftHand);
```

To Use A Button Vector2 Function You Need To Make A Vector2
```cs 
Vector2 JoyStick = EasyInputs.GetThumbStick2DAxis(EasyHand.LeftHand);
```

To Vibrate The Controller There is Multiple Settings, There is Amplitude And Duration

To Vibrate The Controller
```cs 
//You choose which hand first then Amplitude And Then Duration
StartCoroutine(EasyInputs.Vibration(EasyHand.LeftHand, 0.15f, 0.15f))
```
