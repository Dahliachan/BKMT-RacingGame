﻿using UnityEngine;
using System.Collections;

public class CharacterSelect : SceneBase
{
    public override void Initialize()
    {
        StartCoroutine(DoInitialize());
    }
    IEnumerator DoInitialize()
    {
        var op = LoadSceneFile("CharacterSelect");
        if (null == op)
            yield break;

        while (!op.isDone)
        {
            yield return null;
        }
        
        base.Initialize();
    }

    private void Update()
    {
        if (!isInitialized)
            return;

        if (Input.GetKeyDown("z"))
        {
            Accessor.I.sceneManager.ChangeScene("CourseSelect");
        }
    }
}
