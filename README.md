# Utility Package

유니티 프로젝트를 진행하며 자주 사용하는 유틸리티 모음

## System

### Debug

유니티 로그 출력을 스크립트 수정 없이 변경할 수 있도록 한다. 릴리즈와 에디터로 구분하였으며, 매번 Debug Log를 따로 처리하기 싫어서 만들었다. `Build Settings/Player Settings/Player/Other Settings/Script Compilation/Scripting Define Symbols`에서 전처리기를 등록하여 스위칭한다.

* `EDITOR`: 기본로그 모두 포함하여 출력
* `RELEASE`: Error, Warning만 출력

### ListExtensios

리스트 확장 기능을 포괄한다. 요소 전체 출력, 랜덤 요소 반환같이 자주 쓰는데 간단한 기능들을 추가할 예정이다. 마이크로 소프트 독스 중, [Extention Method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) 코딩 가이드라인이 있어서 참고했다.

### YieldInstructionProvider

유니티 코루틴에서 사용하는 지시문을 매번 생성하지 않고 관리하며 제공한다. 초(t)를 id로 `WaitForSeconds(t)`를 중복 생성하지 않게 한다.

### SavedGameSystem

게임 로컬 저장 시스템으로 로드, 생성, 저장, 삭제 제공한다. [Application.persistentDataPath](https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html)을 기본 path로 사용한다. 앱 업데이트가 일어나도 파일이 손상되지 않는다.

## Data Loader

### CSVReader

CSV는 Json과 다르게 따로 리더를 유니티에서 제공해주지 않는다. 그래서 늘 적당히 column이름을 키로 하는 딕셔너리를 반환하는 리더를 만들어서 썼는데, 이 참에 편하게 쓸만한 CSV Reader를 구현해보고자 했다.

제네릭 메소드를 통해 원하는 class 구조로 데이터를 읽어올 수 있게 구성하였다. 변수 이름을 csv 데이터에 맞추는 것은 좋지 않다고 생각해, 커스텀 Attribute를 따로 만들어 column 이름을 따로 명시할 수 있게 했다.

제네릭 타입에 해당하는 인스턴스를 생성하고, csv 파일 첫 라인을 통해 가져온 column 이름 순서로 프로퍼티에 값을 세팅하는 방식이다. 인스턴스의 프로퍼티 중에서 column 이름과 동일한 이름을 가지고 있는 CSVPropertyAttribute를 찾아, 해당 프로퍼티에 값을 전달한다.

매번 서치가 일어나긴 하지만 csv 리딩은 런타임 중 자주 사용하는 기능이 아니어서, 사용하기 편한 것을 우선으로 생각했다.

### JsonHelper

Json은 Unity에서 제공하는 JsonUtility 기능을 이용하면 편하게 읽어올 수 있다. 그러나 배열로 관리되는 요소들을 읽어올 때 굳이 배열만 포함한 class를 만들고 싶지 않은 경우가 종종 있어서 해당 일을 처리하는 Helper를 만들었다.

