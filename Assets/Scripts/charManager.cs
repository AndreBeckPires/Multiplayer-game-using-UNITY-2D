using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class charManager : MonoBehaviour
{
    public SpriteRenderer sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin =0;
    public GameObject playerskin;

    public void NextOption()
    {
        selectedSkin += 1;
        if(selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = skins[selectedSkin];
    }
    public void BackOption()
    {
        selectedSkin -= 1;
        if(selectedSkin < 0)
        {
            selectedSkin = skins.Count - 1;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        #if UNITY_EDITOR

  PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Prefabs/selected.prefab");

#endif
        
        SceneManager.LoadScene("SampleScene");
    }

}
