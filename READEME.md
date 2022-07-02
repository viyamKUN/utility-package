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

### YieldInstructionProvider

* 유니티 코루틴에서 사용하는 지시문을 매번 생성하지 않고 관리하며 제공함.

### SavedGameSystem

* 게임 로컬 저장 시스템으로 로드, 생성, 저장, 삭제 제공함.

## Data Loader

### CSVReader

* CSVProperty 어트리뷰트에 column이름을 지정하여 CSV를 원하는 타입으로 읽어옴.
