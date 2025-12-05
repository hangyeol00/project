-- nutritionist schema bootstrap
-- 순서: 마스터 → 교차 → 업무 테이블

CREATE TABLE AppUser (
    UserID           VARCHAR2(50) PRIMARY KEY,
    UserName         VARCHAR2(100) NOT NULL,
    UserType         VARCHAR2(10) CHECK (UserType IN ('ADMIN','DIET')) NOT NULL,
    PasswordHash     VARCHAR2(200) NOT NULL,
    PasswordSalt     VARCHAR2(100) NOT NULL,
    Status           VARCHAR2(10) DEFAULT 'ACTIVE' NOT NULL,
    FailedLoginCount NUMBER(3) DEFAULT 0 NOT NULL,
    LastLoginAt      DATE,
    CreatedAt        DATE DEFAULT SYSDATE NOT NULL,
    CreatedBy        VARCHAR2(50) REFERENCES AppUser(UserID),
    UpdatedAt        DATE,
    UpdatedBy        VARCHAR2(50) REFERENCES AppUser(UserID)
);

CREATE TABLE RawCategory (
    RawCategoryID NUMBER PRIMARY KEY,
    CategoryCode  VARCHAR2(20) NOT NULL,
    CategoryName  VARCHAR2(50) NOT NULL,
    Description   VARCHAR2(200),
    ActiveFlag    CHAR(1) DEFAULT 'Y' NOT NULL
);

CREATE TABLE RawMaterial (
    RawID          NUMBER PRIMARY KEY,
    RawName        VARCHAR2(100) NOT NULL,
    RawCategoryID  NUMBER NOT NULL REFERENCES RawCategory,
    PurchaseUnit   VARCHAR2(20) NOT NULL,
    BaseUnitQty    NUMBER(10,3) NOT NULL,
    StorageType    VARCHAR2(20),
    ShelfLifeDays  NUMBER(5),
    ActiveFlag     CHAR(1) DEFAULT 'Y' NOT NULL
);

CREATE TABLE Nutrient (
    NutrientID   NUMBER PRIMARY KEY,
    NutrientCode VARCHAR2(20) NOT NULL,
    NutrientName VARCHAR2(50) NOT NULL,
    Unit         VARCHAR2(10) NOT NULL,
    Description  VARCHAR2(200),
    ActiveFlag   CHAR(1) DEFAULT 'Y' NOT NULL
);

CREATE TABLE RawNutrient (
    RawID         NUMBER NOT NULL REFERENCES RawMaterial,
    NutrientID    NUMBER NOT NULL REFERENCES Nutrient,
    AmountPerBase NUMBER(12,4) NOT NULL,
    Notes         VARCHAR2(200),
    CONSTRAINT PK_RawNutrient PRIMARY KEY (RawID, NutrientID)
);

CREATE TABLE Allergy (
    AllergyID   NUMBER PRIMARY KEY,
    AllergyCode VARCHAR2(10) NOT NULL,
    AllergyName VARCHAR2(50) NOT NULL,
    Description VARCHAR2(200)
);

CREATE TABLE RawAllergy (
    RawID     NUMBER NOT NULL REFERENCES RawMaterial,
    AllergyID NUMBER NOT NULL REFERENCES Allergy,
    EvidenceNote VARCHAR2(200),
    CONSTRAINT PK_RawAllergy PRIMARY KEY (RawID, AllergyID)
);

CREATE TABLE Ingredient (
    IngredientID       NUMBER PRIMARY KEY,
    IngredientName     VARCHAR2(100) NOT NULL,
    Type               VARCHAR2(30) NOT NULL,
    BatchYieldGram     NUMBER(10,2) NOT NULL,
    DefaultPortionGram NUMBER(8,2),
    ActiveFlag         CHAR(1) DEFAULT 'Y' NOT NULL
);

CREATE TABLE IngredientComp (
    IngredientID     NUMBER NOT NULL REFERENCES Ingredient,
    RawID            NUMBER NOT NULL REFERENCES RawMaterial,
    QuantityPerBatch NUMBER(10,2) NOT NULL,
    LossRatePct      NUMBER(5,2),
    CONSTRAINT PK_IngredientComp PRIMARY KEY (IngredientID, RawID)
);

CREATE TABLE FinalMenu (
    FinalMenuID      NUMBER PRIMARY KEY,
    MenuCode         VARCHAR2(30) NOT NULL,
    MenuName         VARCHAR2(100) NOT NULL,
    MenuType         VARCHAR2(20) NOT NULL,
    ServingSizeGram  NUMBER(8,2) NOT NULL,
    ActiveFlag       CHAR(1) DEFAULT 'Y' NOT NULL
);

CREATE TABLE MenuTag (
    MenuTagID  NUMBER PRIMARY KEY,
    TagName    VARCHAR2(50) NOT NULL,
    TagType    VARCHAR2(20) NOT NULL,
    Description VARCHAR2(200),
    ActiveFlag CHAR(1) DEFAULT 'Y' NOT NULL
);

CREATE TABLE MenuTagMap (
    FinalMenuID NUMBER NOT NULL REFERENCES FinalMenu,
    MenuTagID   NUMBER NOT NULL REFERENCES MenuTag,
    TagPriority NUMBER(3),
    CONSTRAINT PK_MenuTagMap PRIMARY KEY (FinalMenuID, MenuTagID)
);

CREATE TABLE MenuComp (
    MenuCompID            NUMBER PRIMARY KEY,
    FinalMenuID           NUMBER NOT NULL REFERENCES FinalMenu,
    ComponentType         CHAR(1) CHECK (ComponentType IN ('R','I')),
    ComponentRawID        NUMBER REFERENCES RawMaterial,
    ComponentIngredientID NUMBER REFERENCES Ingredient,
    QuantityPerServing    NUMBER(10,3) NOT NULL
);

CREATE TABLE MealPlan (
    MealPlanID   NUMBER PRIMARY KEY,
    PlanName     VARCHAR2(100) NOT NULL,
    PeriodStart  DATE NOT NULL,
    PeriodEnd    DATE NOT NULL,
    Status       VARCHAR2(20) NOT NULL,
    CreatedBy    VARCHAR2(50) NOT NULL REFERENCES AppUser(UserID)
);

CREATE TABLE Meal (
    MealID          NUMBER PRIMARY KEY,
    MealPlanID      NUMBER NOT NULL REFERENCES MealPlan,
    MealDate        DATE NOT NULL,
    MealType        VARCHAR2(10) NOT NULL,
    TargetGradeFrom NUMBER,
    TargetGradeTo   NUMBER,
    TargetGroup     VARCHAR2(30),
    Notes           VARCHAR2(200)
);

CREATE TABLE MealComp (
    MealID       NUMBER NOT NULL REFERENCES Meal,
    FinalMenuID  NUMBER NOT NULL REFERENCES FinalMenu,
    PortionCount NUMBER(6) NOT NULL,
    IsMainDish   CHAR(1),
    CONSTRAINT PK_MealComp PRIMARY KEY (MealID, FinalMenuID)
);

CREATE TABLE Consumer (
    ConsumerID    NUMBER PRIMARY KEY,
    ConsumerType  CHAR(1) CHECK (ConsumerType IN ('S','T')) NOT NULL,
    Grade         NUMBER,
    Class         VARCHAR2(5),
    Name          VARCHAR2(50) NOT NULL,
    Status        VARCHAR2(20) NOT NULL,
    BirthDate     DATE
);

CREATE TABLE ConsumerAllergy (
    ConsumerID NUMBER NOT NULL REFERENCES Consumer,
    AllergyID  NUMBER NOT NULL REFERENCES Allergy,
    CONSTRAINT PK_ConsumerAllergy PRIMARY KEY (ConsumerID, AllergyID)
);

CREATE TABLE AltAssign (
    AltAssignID          NUMBER PRIMARY KEY,
    MealID               NUMBER NOT NULL REFERENCES Meal,
    TargetFinalMenuID    NUMBER REFERENCES FinalMenu,
    AllergyID            NUMBER NOT NULL REFERENCES Allergy,
    FinalMenuID          NUMBER NOT NULL REFERENCES FinalMenu,
    TargetConsumerCount  NUMBER(5),
    CONSTRAINT FK_AltAssign_TargetMealComp
        FOREIGN KEY (MealID, TargetFinalMenuID)
        REFERENCES MealComp (MealID, FinalMenuID)
);

CREATE TABLE MealReview (
    MealID        NUMBER NOT NULL REFERENCES Meal,
    ConsumerID    NUMBER NOT NULL REFERENCES Consumer,
    OverallRating NUMBER(1) NOT NULL,
    CommentText   VARCHAR2(500),
    CreatedAt     DATE DEFAULT SYSDATE NOT NULL,
    CONSTRAINT PK_MealReview PRIMARY KEY (MealID, ConsumerID)
);

CREATE TABLE MealReviewItem (
    MealID      NUMBER NOT NULL,
    ConsumerID  NUMBER NOT NULL,
    FinalMenuID NUMBER NOT NULL REFERENCES FinalMenu,
    ItemRating  NUMBER(1),
    CONSTRAINT PK_MealReviewItem PRIMARY KEY (MealID, ConsumerID, FinalMenuID),
    CONSTRAINT FK_MealReviewItem_Review
        FOREIGN KEY (MealID, ConsumerID)
        REFERENCES MealReview (MealID, ConsumerID)
);

CREATE TABLE AltReview (
    AltAssignID NUMBER NOT NULL REFERENCES AltAssign,
    ConsumerID  NUMBER NOT NULL REFERENCES Consumer,
    Rating      NUMBER(1) NOT NULL,
    CommentText VARCHAR2(500),
    CreatedAt   DATE DEFAULT SYSDATE NOT NULL,
    CONSTRAINT PK_AltReview PRIMARY KEY (AltAssignID, ConsumerID)
);

CREATE TABLE Vendor (
    VendorID            NUMBER PRIMARY KEY,
    VendorName          VARCHAR2(100) NOT NULL,
    BusinessNumber      VARCHAR2(20),
    ContactName         VARCHAR2(50),
    ContactPhone        VARCHAR2(20),
    Address             VARCHAR2(200),
    DefaultLeadTimeDays NUMBER(3),
    Status              VARCHAR2(20) NOT NULL
);

CREATE TABLE RawContract (
    RawContractID  NUMBER PRIMARY KEY,
    VendorID       NUMBER NOT NULL REFERENCES Vendor,
    RawID          NUMBER NOT NULL REFERENCES RawMaterial,
    ContractPrice  NUMBER(12,2) NOT NULL,
    Currency       CHAR(3) NOT NULL,
    EffectiveStart DATE NOT NULL,
    EffectiveEnd   DATE,
    MinOrderQty    NUMBER(10,2),
    Notes          VARCHAR2(200)
);

CREATE TABLE PurchaseRequest (
    PurchaseRequestID NUMBER PRIMARY KEY,
    RawID             NUMBER NOT NULL REFERENCES RawMaterial,
    RawContractID     NUMBER REFERENCES RawContract,
    RequestedBy       VARCHAR2(50) NOT NULL REFERENCES AppUser(UserID),
    RequestedDate     DATE NOT NULL,
    Quantity          NUMBER(10,2) NOT NULL,
    UnitPriceEstimate NUMBER(12,2),
    ExpectedDeliveryDate DATE,
    Status            VARCHAR2(20) NOT NULL,
    ApprovedBy        VARCHAR2(50) REFERENCES AppUser(UserID),
    ApprovedDate      DATE,
    ReceivedQuantity  NUMBER(10,2),
    ReceivedDate      DATE,
    Remark            VARCHAR2(200)
);
