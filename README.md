# DebugUtils

이 패키지는 **Unity 에디터에서만** 사용할 수 있는 **Debug Utils Tool**입니다.  
메시지를 지정한 색상으로 출력할 뿐 아니라, 메시지 앞에 태그, 넘버링, 타임스탬프를 붙여 로그를 체계적으로 관리할 수 있도록 도와줍니다.  
또한, 경고 및 에러 로그 출력과 조건부 로그 기능까지 지원하여 디버깅 시 필요한 모든 기능을 한 곳에 모았습니다.

---

## 설치 방법

### Unity Package Manager로 설치

1. Unity 에디터에서 프로젝트를 엽니다.
2. **Window > Package Manager**를 선택합니다.
3. 좌측 상단의 **"+" 버튼**을 클릭한 후 "Add package from git URL..."를 선택합니다.
4. 아래 URL 형식으로 입력합니다:
https://github.com/KimJinWooDa/DebugUtils.git

5. **Add** 버튼을 클릭하면 Unity가 자동으로 패키지를 다운로드하고 설치합니다.

---

## 사용 예시

다음 코드를 복사하여 바로 사용해보세요.

```csharp
using UnityEngine;
using DebugHelper;  // 패키지에 포함된 네임스페이스

public class Example : MonoBehaviour
{
    void Start()
    {
        // 전체 메시지를 초록색으로 출력 (태그: [Greeting], 넘버링: 1, 타임스탬프 표시)
        Debug.LogColor("안녕하세요, 세계!", Color.green, 1, "Greeting", true);
        
        // 메시지의 특정 부분 "에러"를 빨간색으로 출력 (태그: [Error], 넘버링: 2, 타임스탬프 표시)
        Debug.LogColorPart("에러: 문제가 발생했습니다", "에러", Color.red, 2, "Error", true);
        
        // 경고 메시지를 노란색으로 출력 (태그: [Warning], 넘버링: 3, 타임스탬프 표시)
        Debug.LogColorWarning("주의: 메모리가 부족합니다.", Color.yellow, 3, "Warning", true);
        
        // 에러 메시지를 자홍색으로 출력 (태그: [Error], 넘버링: 4, 타임스탬프 표시)
        Debug.LogColorError("에러: 파일을 찾을 수 없습니다.", Color.magenta, 4, "Error", true);
        
        // 조건부 로그: isDebugMode가 true일 때만 출력 (태그: [Debug], 넘버링: 5, 타임스탬프 표시)
        bool isDebugMode = true;
        Debug.LogIf(isDebugMode, "디버그 모드가 활성화되었습니다.", Color.cyan, 5, "Debug", true);
    }
}
```

# 라이선스
이 패키지는 MIT 라이선스 하에 배포됩니다.
