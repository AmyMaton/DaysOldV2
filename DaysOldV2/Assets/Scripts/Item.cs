﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Rock,
        Wood,
    }

    public ItemType itemType;
    public int amount;
}
