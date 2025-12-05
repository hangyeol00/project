# Composite PK 정리
- `RawNutrient`: PK=(RawID, NutrientID) – 동일 원재료-영양소 조합 하나씩만 보관.
- `RawAllergy`: PK=(RawID, AllergyID) – 원재료×알레르기 중복 방지.
- `IngredientComp`: PK=(IngredientID, RawID) – 한 재료 레시피에서 동일 원재료 중복 금지.
- `MenuTagMap`: PK=(FinalMenuID, MenuTagID) – 메뉴별 태그 1회만 부여.
- `MealComp`: PK=(MealID, FinalMenuID) – 한 식사에 동일 메뉴 중복 편성 금지.
- `ConsumerAllergy`: PK=(ConsumerID, AllergyID) – 소비자별 알레르기 중복 등록 불가.
- `MealReview`: PK=(MealID, ConsumerID); `MealReviewItem`: PK=(MealID, ConsumerID, FinalMenuID).
- `AltReview`: PK=(AltAssignID, ConsumerID).
- `AltAssign`은 여전히 `AltAssignID`로 식별하지만 `TargetFinalMenuID`가 `MealComp(MealID, FinalMenuID)`를 참조한다.
