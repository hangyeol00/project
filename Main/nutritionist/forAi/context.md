# Nutritionist WinForms & Schema Notes

## 앱/로그인 개편
- `NutritionistForm`은 RawMaterial, FinalMenu, MealPlan, PurchaseRequest를 직접 조회하며, 영양사 계정(`diet01`, `diet02`)은 식단/발주 등록 다이얼로그(`MealPlanDialog`, `PurchaseRequestDialog`)를 실행하고, 관리자(`admin`)는 승인 버튼만 활성화된다.
- `LoginForm`은 `APPUSER` 테이블의 `PASSWORDHASH`/`PASSWORDSALT`를 PBKDF2(SHA-256, 10,000회)로 검증한다. `seed_data.sql`에 삽입된 계정은 `admin/Admin#2024`, `diet01/Diet#2024`, `diet02/Diet#2024`이며, 로컬 테스트용 내장 계정은 제거됨.
- DB 스크립트를 반복 실행할 때는 `cleanup.sql → schema.sql → seed_data.sql` 순으로 `school/1324@XE` 계정에서 실행하고, SQL*Plus는 UTF-8 환경(`chcp 65001`, `NLS_LANG=.AL32UTF8`)에서 사용한다.

## 데이터/스키마
- `schema.sql`에는 모든 테이블 정의가 들어 있으며, `Raw` 대신 `RawMaterial`, `MealReview.CommentText` 등 Oracle 예약어 충돌을 피한 이름을 사용한다.
- `seed_data.sql`은 TRUNCATE 후 각 테이블에 50~60개의 RawMaterial, 6개의 MealPlan, 40개의 PurchaseRequest 등 실제 테스트에 쓸 수 있는 데이터를 넣는다.
- 2024-XX 정비
  - `PurchaseUnit='KG'`인 원재료는 `BaseUnitQty`를 kg 개수(예: 20kg 포대 → 20)로, `UnitGramQty`는 UI에 표시되는 “1단위(g)” 값(예: 1,000g)으로 통일했다.
  - `RawNutrient.AmountPerBase`는 이제 “1g당 영양소” 값을 저장하며, 레시피 영양 계산 쿼리는 `AmountPerBase × 사용그램`으로 누적한다. 기존 seed 데이터는 스크립트로 일괄 변환했고, DB를 다시 적재해야 한다.

## AdminForm 상태
- 관리자 폼(`AdminForm`)은 아직 UI만 있고 로딩/저장 로직이 없다. 추후 탭별로 DB 조회 함수를 추가해야 화면이 채워진다.
