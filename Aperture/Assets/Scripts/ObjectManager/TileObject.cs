﻿using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public enum ObjectType
{
	Light,
	Switch,
	Box,
	Teleporter
}

[System.Serializable]
public class TileObject
{
	public ObjectType type;
	public Vector3 position;
}
