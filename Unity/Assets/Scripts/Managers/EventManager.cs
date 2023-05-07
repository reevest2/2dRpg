using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager
{
    public static event Action OnPlayerMoved;
    public static void PlayerMoved() => OnPlayerMoved?.Invoke();
}
