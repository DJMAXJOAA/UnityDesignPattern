using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 다양한 타입의 컴포넌트에 대해 Singleton 사용 가능
public class Singleton <T> : MonoBehaviour where T : Component
{
    // 싱글톤 인스턴스의 저장
    private static T _instance;

    public static T instance
    {
        get
        {
            // 싱글톤 인스턴스가 없으면 (최초 생성이면)
            if(_instance == null )
            {
                // 씬에서 해당 타입에 해당하는 오브젝트를 찾아서 등록
                _instance = FindObjectOfType<T>();
                if( _instance == null )
                {
                    // 만약 없으면, 새로 생성하고, 인스턴스 등록
                    GameObject obj = new GameObject();
                    obj.name = typeof( T ).Name;
                    _instance = obj.AddComponent<T>();
                }
            }

            return _instance;
        }
    }
    // 
    public virtual void Awake()
    {
        // 인스턴스가 없으면, 새로 등록하고 씬이 넘어가도 
        if(_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
