using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will replace the cursor with a new texture you provide when the game starts
/// </summary>
public class CursorChanger : MonoBehaviour
{
    [Header("Settings:")]
    [Tooltip("The cursor to change to")]
    public Texture2D newCursorSprite;
    [Tooltip("Hotspot's x position (from 0 to 1)")]
    [Range(0, 1f)]
    public float hotSpotX = 0;
    [Tooltip("Hotspot's y position (from 0 to 1)")]
    [Range(0, 1f)]
    public float hotSpotY = 0;

    void Start()
    {
        ChangeCursor();
    }

    /// <summary>
    /// Description:
    /// Changes the cursor to the one set in editor
    /// Inputs:
    /// None
    /// Returns:
    /// void (no return)
    /// </summary>
    void ChangeCursor()
    {
        if (newCursorSprite != null)
        {
            Cursor.lockState = CursorLockMode.Confined;

            // The location that clicking actually hits, also positions the clicker
            Vector2 hotSpot = new Vector2();

            // Sets the position of hotspot relative to the cursor
            hotSpot.x = newCursorSprite.width * hotSpotX;
            hotSpot.y = newCursorSprite.height * hotSpotY;


            Cursor.SetCursor(newCursorSprite, hotSpot, CursorMode.Auto);
        }
    }
}
