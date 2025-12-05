# FinalMenu / MenuComp 엔티티 정의

## FinalMenu (최종 메뉴)
| 영문 속성 | 한글 표기 | 설명 |
| --- | --- | --- |
| FinalMenuID | 최종메뉴 ID | 기본키 |
| MenuCode | 메뉴 코드 | 내부 식별 코드 |
| MenuName | 메뉴명 | UI에 노출되는 이름 |
| MenuType | 메뉴 분류 | 국/반찬/후식 등 |
| ServingSizeGram | 1회 제공량(g) | 1인분 중량 |
| ActiveFlag | 사용 여부 | Y/N |

## MenuComp (메뉴 구성)
| 영문 속성 | 한글 표기 | 설명 |
| --- | --- | --- |
| MenuCompID | 구성 ID | 기본키 |
| FinalMenuID | 최종메뉴 ID | FinalMenu FK |
| ComponentType | 구성 타입 | R(원재료)/I(재료) |
| ComponentRawID | 원재료 ID | ComponentType='R'일 때 사용 |
| ComponentIngredientID | 재료 ID | ComponentType='I'일 때 사용 |
| QuantityPerServing | 1인분 사용량(g) | 메뉴 내 해당 구성 비중 |

### 파생 정보
- 메뉴 영양소는 `MenuComp → RawMaterial → RawNutrient → Nutrient` 경로 기준으로 계산.
- 재료형 구성은 `MenuComp.ComponentIngredientID → IngredientComp → RawMaterial`로 펼쳐 원재료 단위로 환산 후 합산한다.
