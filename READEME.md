# Utility Package

유니티 프로젝트를 진행하며 자주 사용하는 유틸리티 모음

## System

### Debug

* 유니티 로그 출력을 스크립트 수정 없이 변경할 수 있도록 함.
* `Build Settings/Player Settings/Player/Other Settings/Script Compilation/Scripting Define Symbols`에서 전처리기 등록
* `EDITOR`: 기본로그 모두 포함하여 출력
* `RELEASE`: Error, Warning만 출력

### ListExtensios

* 리스트 확장 기능을 포괄함.

## YieldInstructionProvider

* 유니티 코루틴에서 사용하는 지시문을 매번 생성하지 않고 관리하며 제공함.
