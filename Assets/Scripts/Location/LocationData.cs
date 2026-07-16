using UnityEngine;

[CreateAssetMenu(fileName = "New Location", menuName = "Temple Guide/Location")]
public class LocationData : ScriptableObject
{
    public string locationName;

    public Sprite photo;
}