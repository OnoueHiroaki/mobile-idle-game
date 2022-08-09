using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class TestWebRequest : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(TestRequest());
    }
    IEnumerator TestRequest()
    {
        yield return null;
        UnityWebRequest test = UnityWebRequest.Get("https://pxm2p49mp8.execute-api.ap-northeast-1.amazonaws.com/default/TestFunc");
        yield return test.SendWebRequest();
    }
}
