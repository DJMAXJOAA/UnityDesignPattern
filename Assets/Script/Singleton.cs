using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �پ��� Ÿ���� ������Ʈ�� ���� Singleton ��� ����
public class Singleton <T> : MonoBehaviour where T : Component
{
    // �̱��� �ν��Ͻ��� ����
    private static T _instance;

    public static T instance
    {
        get
        {
            // �̱��� �ν��Ͻ��� ������ (���� �����̸�)
            if(_instance == null )
            {
                // ������ �ش� Ÿ�Կ� �ش��ϴ� ������Ʈ�� ã�Ƽ� ���
                _instance = FindObjectOfType<T>();
                if( _instance == null )
                {
                    // ���� ������, ���� �����ϰ�, �ν��Ͻ� ���
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
        // �ν��Ͻ��� ������, ���� ����ϰ� ���� �Ѿ�� 
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
