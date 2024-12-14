using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance==null)
            {
                Debug.LogError("can not find MonoSingleton");
            }
            return instance;
        }
    }

    public virtual void Awake()
    {
        instance = this as T;
        Debug.log("单例创建成功")
    }
}
