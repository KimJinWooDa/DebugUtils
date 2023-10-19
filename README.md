# DebugUtils
디버그를 할 때 글씨가 전부 하얀색이여서 중요한 정보를 골라내기 힘들어서 직접 디버깅 함수를 업그레이드 해봤습니다.

사용방법은 간단합니다.

# LogColor
* 전체적인 Text의 색을 바꿔줍니다.
  
![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/d5d16e81-ce2b-47ab-927b-cd43405225c7)

* 사용방법은 Text를 입력해준 다음 색을 정해주면 됩니다!

![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/922edf08-7511-48e6-b3c5-d3cd755cb225)


# LogColorPart
* 부분적으로 강조하고 싶은 Text의 색을 바꿉니다
  
![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/d35a26e2-15dc-4f30-913d-c6c5461aa402)

* 사용방법은 Text을 입력 후 강조하고 싶은 Text만 한 번 더 작성해줍니다.

![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/c76b3e24-51c4-471d-8710-741c625aed2c)

# LogColorParts
* 부분적으로 강조하고 싶은 Text가 2개 이상일 때 사용합니다.

![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/dc46aea5-9bb3-4c59-8ef5-344fafd10aec)

* 사용방법이 약간 다릅니다. Color을 먼저 지정해준 다음 강조하고자 하는 Text들을 입력합니다. 

![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/d38091f9-af51-4959-974b-f746a3d5b939)

# 마지막으로 응용하는 방법입니다.
![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/340ed8af-7129-4c07-b080-fc4aa8847302)

* 문자열 보간법을이용합니다.

![image](https://github.com/KimJinWooDa/DebugUtil/assets/76438011/b9a44312-9d48-43df-b9d7-8cea105d2b36)


추가적인 기능이 생각나면 추가하러오겠습니다!
# 패치 노트
- 2023.10.19

유니티에 내장되어 있는 Color만을 사용해서 Debug을 출력하기에 Color 종류가 부족해지는 경우가 생깁니다.
프리셋을 만들어 사용할 수 있는 Color종류의 제한을 풀었습니다.

Debug Color Preset을 추가하였습니다.

![image](https://github.com/KimJinWooDa/DebugUtils/assets/76438011/230e343d-22c6-4b82-bce7-9084a992acfc)


사용방법은 아래와 같습니다.
(하이러키창에 Debug Preset Container을 미리 만드셔야 합니다)

![image](https://github.com/KimJinWooDa/DebugUtils/assets/76438011/49977936-bb12-43a4-a0db-d54cc7bf0509)


![image](https://github.com/KimJinWooDa/DebugUtils/assets/76438011/4a094630-e02e-4020-aa8c-90c1b538bae6)

Color Preset의 경우 Scriptable Object로 관리합니다.
