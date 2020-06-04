using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LoadTexture2D : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private string texturePath;
    
    private Texture originalTexture;
    
    private void Start()
    {
        LoadTexture(texturePath);
        Invoke("UnloadTexture", 3f);
    }

    // The first way
    public void LoadTexture(string path)
    {
        Debug.Log($"Load texture from Resources/{path}");
        var texture = Resources.Load<Texture2D>(path);
        originalTexture = image.material.mainTexture;
        image.material.mainTexture = texture;
    }

    public void UnloadTexture()
    {
        Debug.Log($"Unload texture");

        Resources.UnloadAsset(image.material.mainTexture);
    }
    
    // The second way

    public void LoadTexture(string path, int secondWay)
    {
        
    }
}
