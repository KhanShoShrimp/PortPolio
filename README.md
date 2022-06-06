# PortPolio
## 포트폴리오 페이지입니다.

**1. UDP - 웹캠 통신**

통신 개발에서 중요시했던 부분은 GC가 없도록 구성하는 것이었습니다.
    
    실행방법
     - Example1 씬을 엽니다.
     - 좌 상단에 목록이 있습니다. 웹캠을 선택하세요.
     - 좌측 버튼 "1. WebCam 보내기"로 웹캠을 실행하고 데이터를 보냅니다.
     - 우측 버튼 "2. WebCam 받기"로 웹캠 데이터를 받고 화면을 구성합니다.
---
**2. ECS - Boids(군체 알고리즘)**

ECS는 데이터 지향 프로그래밍으로 데이터를 병렬 처리할 수 있는 시스템입니다.

    실행방법
     - Boids 씬을 엽니다.
     - New Sub Scene을 엽니다.
     - Setting에서 Boids를 설정할 수 있습니다.(미리 설정해두었습니다.)
     - 플레이합니다.

개발시 주변 Entity를 검색할 때, Dots.Physics의 Overlap 기능으로 사용하기보다 직접 Position을 검색하는 것이 편이 더 빨랐습니다.
따라서 Dots.Physics를 사용하지 않았습니다.