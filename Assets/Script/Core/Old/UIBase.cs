using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// 所有UI的基类
/// </summary>
public class UIBase : MonoBehaviour 
{
    void Awake()
    {
        OnAwake();
    }

    void Start()
    {
        UIButton[] btnArr = GetComponentsInChildren<UIButton>(true);
        for (int i = 0; i < btnArr.Length; i++)
        {
            UIEventListener.Get(btnArr[i].gameObject).onClick = BtnClick;
        }
        OnStart();
    }

    void OnDestroy()
    {
        BeforeOnDestroy();
    }

    private void BtnClick(GameObject go)
    {
        OnBtnClick(go);
    }

    protected virtual void OnAwake() { }
    protected virtual void OnStart() { }
    protected virtual void BeforeOnDestroy() { }
    protected virtual void OnBtnClick(GameObject go) { }
}