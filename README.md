# DebugUtils

이 패키지는 Unity 에디터에서 사용할 수 있는 Debug 클래스입니다.  
메시지를 지정한 색상으로 출력할 뿐 아니라, 메시지 앞에 태그, 넘버링, 타임스탬프를 붙여 로그를 체계적으로 관리할 수 있도록 도와줍니다.  
또한, 경고 및 에러 로그 출력과 조건부 로그 기능까지 지원하여, 디버깅 시 필요한 모든 기능을 하나의 클래스로 제공합니다.

---

## 기능

- 전체 메시지를 지정한 색상으로 출력
- 메시지의 특정 부분만 지정한 색상으로 변경하여 출력
- 메시지 앞에 태그, 넘버링, 타임스탬프를 추가하여 로그 관리 용이
- 경고 및 에러 로그 출력 기능 지원
- 조건이 참일 때만 로그를 출력하는 조건부 로그 기능 지원

---

## 사용법

### 1. 전체 메시지 색상 로그 출력

```csharp
using UnityEngine;
using DebugHelper;

public class Example : MonoBehaviour
{
    void Start()
    {
        Debug.LogColor("안녕하세요, 세계!", Color.green, 1, "Greeting", true);
        Debug.LogColorPart("에러: 문제가 발생했습니다", "에러", Color.red, 2, "Error", true);
        Debug.LogColorWarning("주의: 메모리가 부족합니다.", Color.yellow, 3, "Warning", true);
        Debug.LogColorError("에러: 파일을 찾을 수 없습니다.", Color.magenta, 4, "Error", true);

        bool isDebugMode = true;
        Debug.LogIf(isDebugMode, "디버그 모드가 활성화되었습니다.", Color.cyan, 5, "Debug", true);
    }
}
```

